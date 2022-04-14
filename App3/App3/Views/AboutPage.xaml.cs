using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

using TouchTracking;
using System.Reflection;
using System.IO;


namespace App3.Views
{
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {

        TouchManipulationBitmap bitmap;
        List<long> touchIds = new List<long>();
        MatrixDisplay matrixDisplay = new MatrixDisplay();
        

        public AboutPage()
        {
            InitializeComponent();




           // var a = canvasView.CanvasSize.Width;

            string resourceID = "App3.Media.MountainClimbers.jpg";
            Assembly assembly = GetType().GetTypeInfo().Assembly;

            using (Stream stream = assembly.GetManifestResourceStream(resourceID))
            {
                SKBitmap bitmap = SKBitmap.Decode(stream);
                this.bitmap = new TouchManipulationBitmap(bitmap);
                this.bitmap.TouchManager.Mode = TouchManipulationMode.ScaleRotate;
            }
        }

        void OnCanvasViewDrawArrow(object sender, SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;

            SKCanvas canvas = surface.Canvas;
            canvas.Clear();
            // canvas.DrawPaint(backgroundFillPaint);

            int width = e.Info.Width;
            int height = e.Info.Height;




            using (SKPaint skPaint = new SKPaint())
            {
                skPaint.Style = SKPaintStyle.Stroke;
                skPaint.IsAntialias = true;
                skPaint.Color = SKColors.Red;
                skPaint.StrokeWidth = 5;
                skPaint.StrokeCap = SKStrokeCap.Round;
                surface.Canvas.DrawLine(0, 0, 200, 50, skPaint);
                surface.Canvas.DrawLine(200, 50, 180, 20, skPaint);
                surface.Canvas.DrawLine(200, 50, 180, 80, skPaint);
            }
        }



        void OnTouchModePickerSelectedIndexChanged(object sender, EventArgs args)
        {
            if (bitmap != null)
            {
                Picker picker = (Picker)sender;
                bitmap.TouchManager.Mode = (TouchManipulationMode)picker.SelectedItem;
            }
        }

        void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            // Convert Xamarin.Forms point to pixels
            Point pt = args.Location;
            SKPoint point =
                new SKPoint((float)(canvasView.CanvasSize.Width * pt.X / canvasView.Width),
                            (float)(canvasView.CanvasSize.Height * pt.Y / canvasView.Height));

            switch (args.Type)
            {
                case TouchActionType.Pressed:
                    if (bitmap.HitTest(point))
                    {
                        touchIds.Add(args.Id);
                        bitmap.ProcessTouchEvent(args.Id, args.Type, point, canvasView);
                        break;
                    }
                    break;

                case TouchActionType.Moved:
                    if (touchIds.Contains(args.Id))
                    {
                        bitmap.ProcessTouchEvent(args.Id, args.Type, point, canvasView);
                        canvasView.InvalidateSurface();
                    }
                    break;

                case TouchActionType.Released:
                case TouchActionType.Cancelled:
                    if (touchIds.Contains(args.Id))
                    {
                        bitmap.ProcessTouchEvent(args.Id, args.Type, point, canvasView);
                        touchIds.Remove(args.Id);
                        canvasView.InvalidateSurface();
                    }
                    break;
            }
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            // Display the bitmap
            bitmap.Paint(canvas);

            // Display the matrix in the lower-right corner
            SKSize matrixSize = matrixDisplay.Measure(bitmap.Matrix);

            matrixDisplay.Paint(canvas, bitmap.Matrix,
                new SKPoint(info.Width - matrixSize.Width,
                            info.Height - matrixSize.Height));
        }
    }
}