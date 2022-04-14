using System;
using System.Collections.Generic;

using SkiaSharp;
using SkiaSharp.Views.Forms;
using TouchTracking;
using Xamarin.Forms;

namespace App3.Views
{
    class TouchManipulationBitmap
    {
        SKBitmap bitmap;
        SKCanvas gcanvas;
        float scalex;
        float scaley;

        Dictionary<long, TouchManipulationInfo> touchDictionary =
            new Dictionary<long, TouchManipulationInfo>();

        public TouchManipulationBitmap(SKBitmap bitmap)
        {
            this.bitmap = bitmap;
            scalex = 1;
            scaley = 1;

            Matrix = SKMatrix.MakeIdentity();

            TouchManager = new TouchManipulationManager
            {
                Mode = TouchManipulationMode.ScaleRotate
            };
        }

        public TouchManipulationManager TouchManager { set; get; } 

        public SKMatrix Matrix { set; get; }

        public void Paint(SKCanvas canvas)
        {
            canvas.Save();
            SKMatrix matrix = Matrix;
            
            canvas.Concat(ref matrix);
            canvas.DrawBitmap(bitmap, 0, 0);
            canvas.Restore();
        }

        public bool HitTest(SKPoint location)
        {
            // Invert the matrix
            SKMatrix inverseMatrix;

            if (Matrix.TryInvert(out inverseMatrix))
            {
                // Transform the point using the inverted matrix
                SKPoint transformedPoint = inverseMatrix.MapPoint(location);

                // Check if it's in the untransformed bitmap rectangle
                SKRect rect = new SKRect(0, 0, bitmap.Width, bitmap.Height);
                return rect.Contains(transformedPoint);
            }
            return false;
        }

        public void ProcessTouchEvent(long id, TouchActionType type, SKPoint location, SKCanvasView cview)
        {
            switch (type)
            {
                case TouchActionType.Pressed:
                    touchDictionary.Add(id, new TouchManipulationInfo
                    {
                        PreviousPoint = location,
                        NewPoint = location
                    });
                    break;

                case TouchActionType.Moved:
                    TouchManipulationInfo info = touchDictionary[id];
                    info.NewPoint = location;
                    Manipulate(cview);
                    info.PreviousPoint = info.NewPoint;
                    break;

                case TouchActionType.Released:
                    touchDictionary[id].NewPoint = location;
                    Manipulate(cview);
                    touchDictionary.Remove(id);
                    break;

                case TouchActionType.Cancelled:
                    touchDictionary.Remove(id);
                    break;
            }
        }

        void Manipulate(SKCanvasView cview)
        {
            TouchManipulationInfo[] infos = new TouchManipulationInfo[touchDictionary.Count];
            
            touchDictionary.Values.CopyTo(infos, 0);
            SKMatrix touchMatrix = SKMatrix.MakeIdentity();

            SKPoint prevPoint = infos[0].PreviousPoint;
            SKPoint newPoint = infos[0].NewPoint;
                
            SKPoint pivotPoint = Matrix.MapPoint(bitmap.Width / 2, bitmap.Height / 2);
              
              //  touchMatrix = TouchManager.OneFingerManipulate(prevPoint, newPoint, pivotPoint, bitmap, Matrix, canvasSize);
                
            
            SKPoint delta = newPoint - prevPoint;

            var newScale = 2 + newPoint.Y / 1848 - Matrix.ScaleY;
            SKMatrix.PostConcat(ref touchMatrix, SKMatrix.MakeTranslation(newPoint.X - Matrix.TransX - Matrix.ScaleY * bitmap.Width / 2
                , newPoint.Y - Matrix.TransY - Matrix.ScaleY * bitmap.Height / 2));
            //touchMatrix.SetScaleTranslate(1.1f, 1.1f, 1, 1);
            float w = (float)cview.CanvasSize.Width;
            float h = (float)cview.CanvasSize.Height;
            double cw = cview.Width;
            double ch = cview.Height;

            var scalex = newPoint.X / w;
            var scaley = newPoint.Y / h;

            Console.WriteLine(newPoint.X);
         
           SKMatrix.PostConcat(ref touchMatrix, SKMatrix.MakeScale(newScale, newScale));



            SKMatrix matrix = Matrix;
            SKMatrix.PostConcat(ref matrix, touchMatrix);


            Matrix = matrix;
        }
    }
}
