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
        public BarSegment()
        {
         

        }


        public static readonly BindableProperty BarWidthProperty =
            BindableProperty.Create(nameof(BarWidth), typeof(GridLength), typeof(BarSegment), new GridLength(40, GridUnitType.Star), BindingMode.TwoWay, propertyChanged: BarWidthPropertyChanged);

        public GridLength BarWidth
        {
            get
            {
                return (GridLength)GetValue(BarWidthProperty);
            }
            set
            {
                SetValue(BarWidthProperty, value);
                OnPropertyChanged();
            }
        }

 
        private static void BarWidthPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BarSegment)bindable;
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


        }



    }
}