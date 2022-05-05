using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using TouchTracking;
using System.Reflection;
using System.IO;
using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    public partial class TestPage2 : ContentPage
    {
        private ObservableCollection<Monkey> items;

        // public property, bind here, interact with it
        public ObservableCollection<Monkey> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged();
            }
        }
        public TestPage2()
        {
            
            //listView.ItemsSource = items;
            //listView.SetBinding(ListView.ItemsSourceProperty, new Binding("."));
          
            InitializeComponent();

            //var b = new ProgressBar.ProgressBar
            //{
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    HorizontalOptions = LayoutOptions.Center,
            //    ProgressBarHeight = 10,
            //    ProgressBarWidth = 100,
            //    CornerRadius = 0,
            //    BarList =
            //    {
            //        new ProgressBar.BarSegment{
            //          BarWidth = 10,
            //          BarColor = Color.LightGreen,
            //        },
            //        new ProgressBar.BarSegment{
            //          BarWidth = 80,
            //          BarColor = Color.DarkGray,
            //        },
            //        new ProgressBar.BarSegment{
            //          BarWidth = 10,
            //          BarColor = Color.Red,
            //        },
            //    }

            //};

            // Tab2Stack.Children.Add(b);
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");
            ((ListView)sender).SelectedItem = null; // de-select the row
        }

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }
    }
}