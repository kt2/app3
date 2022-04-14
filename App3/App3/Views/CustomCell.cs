using System;
using Xamarin.Forms;
using System.Diagnostics;
using ProgressBar;
namespace App3.Views
{
    /// <summary>
    /// For custom renderer on Android (only)
    /// </summary>
    public class ListButton : Button { }


    public class CustomCell : ViewCell
    {
        public CustomCell()
        {
            var label1 = new Label
            {
                Text = "Label 1",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };
            label1.SetBinding(Label.TextProperty, new Binding("Name"));

            var label2 = new Label
            {
                Text = "Label 2",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };

            //var button = new ListButton
            //{
            //    Text = "X",
            //    BackgroundColor = Color.Gray,
            //    HorizontalOptions = LayoutOptions.EndAndExpand
            //};
            //button.SetBinding(Button.CommandParameterProperty, new Binding("."));
            //button.Clicked += (sender, e) =>
            //{
            //    var b = (Button)sender;
            //    var t = b.CommandParameter;
            //    ((ContentPage)((ListView)((StackLayout)b.Parent).Parent).Parent).DisplayAlert("Clicked", t + " button was clicked", "OK");
            //    Debug.WriteLine("clicked" + t);
            //};

            var bar1 = new ProgressBar.BarSegment
            {
                BarColor = Color.LightGreen,
            };
   

            var bar2 = new ProgressBar.BarSegment
            {
                BarColor = Color.DarkGray,
            };
        
            var bar3 = new ProgressBar.BarSegment
            {
                BarColor = Color.Red,
            };

      

            var bp = new ProgressBar.ProgressBar
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                ProgressBarHeight = 10,
                ProgressBarWidth = 100,
                CornerRadius = 0,
                BarList =
                {
                    bar1,
                    bar2,
                    bar3
                }

            };

            bar1.SetBinding(BarSegment.BarWidthProperty, new Binding("Bar1"));
            bar2.SetBinding(BarSegment.BarWidthProperty, new Binding("Bar2"));
            bar3.SetBinding(BarSegment.BarWidthProperty, new Binding("Bar3"));
     


            View = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(15, 5, 5, 15),
                Children = {
                    new StackLayout {
                        Orientation = StackOrientation.Vertical,
                        Children = { label1, label2 }
                    },
                    bp
                }
            };
        }
    }
}

