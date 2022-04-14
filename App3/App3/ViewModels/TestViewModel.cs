using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ProgressBar;

namespace App3.ViewModels
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Bar1 { get; set; }
        public string Bar2 { get; set; }
        public string Bar3 { get; set; }
        public int iBar1 { get; set; }
        public int iBar2 { get; set; }
        public int iBar3 { get; set; }
        public string BarWidth { get; set; }
        public string BColor { get; set; }
    }
    public class TestViewModel : BaseViewModel
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

        public TestViewModel()
        {
            Title = "Test";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            Items = new ObservableCollection<Monkey>();
            Items.Add(new Monkey
            {
                Name = "test",
                Bar1 = "50*",
                Bar2 = "40*",
                Bar3 = "10*",
                iBar1 = 1,
                iBar2 = 2,
                iBar3 = 3,
                BarWidth = "400",
                BColor = "Black"
            });
            Items.Add(new Monkey
            {
                Name = "tes4t",
                Bar1 = "50*",
                Bar2 = "40*",
                Bar3 = "10*",
                iBar1 = 1,
                iBar2 = 2,
                iBar3 = 3,
                BarWidth = "400",
                BColor = "Black"
            });
            Items.Add(new Monkey
            {
                Name = "tuuest",
                Bar1 = "50*",
                Bar2 = "40*",
                Bar3 = "10*",
                iBar1 = 1,
                iBar2 = 2,
                iBar3 = 3,
                BarWidth = "400",
                BColor = "Red"
            });
        }

        public ICommand OpenWebCommand { get; }
    }
}