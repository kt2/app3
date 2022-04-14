using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgressBar
{
    public partial class BarSegment : ContentView
    {

        public static readonly BindableProperty BarWidth2Property =
       BindableProperty.Create(nameof(BarWidth2), typeof(int), typeof(BarSegment), 20);

        public int BarWidth2
        {
            get
            {
                return (int)GetValue(BarWidth2Property);
            }
            set
            {
                SetValue(BarWidth2Property, value);
            }
        }


        public static readonly BindableProperty BarWidthProperty =
            BindableProperty.Create(nameof(BarWidth), typeof(GridLength), typeof(BarSegment), new GridLength(40, GridUnitType.Star));

        public GridLength BarWidth
        {
            get
            {
                return (GridLength)GetValue(BarWidthProperty);
            }
            set
            {
                SetValue(BarWidthProperty, value);
            }
        }

        public static readonly BindableProperty BarColorProperty =
            BindableProperty.Create(nameof(BarColor), typeof(Color), typeof(BarSegment), Color.Red);

        public Color BarColor
        {
            get
            {
                return (Color)GetValue(BarColorProperty);
            }
            set
            {
                SetValue(BarColorProperty, value);
            }
        }
  
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == BarWidthProperty.PropertyName)
            {
                var breakpoint = 1;
            }

            if (propertyName == BarWidth2Property.PropertyName)
            {
                var breakpoint2 = 1;
            }

        }



    }
}