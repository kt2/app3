using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ProgressBar;



namespace App3.ViewModels
{

    public class Test2ViewModel : BaseViewModel
    {
        private ObservableCollection<Monkey> items;

        public ObservableCollection<Monkey> Items
        {
            get => items;
            set
            {
                items = value;
            }
        }

        public Test2ViewModel()
        {
            Title = "Test";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            Items = new ObservableCollection<Monkey>();
            Items.Add(new Monkey
            {
                Label = "1K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,

            });
            Items.Add(new Monkey
            {
                Label = "2K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = true,
                Knew = 12,
                ToLearn = 10,
                Uncover = 978,
            });
            Items.Add(new Monkey
            {
                Label = "4K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "4K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "5K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "6K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "7K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "8K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "9K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "10L",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "11K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "12K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "13K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "14K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "15K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "16K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "17K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "18K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "19K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(20, GridUnitType.Star),
                Bar3 = new GridLength(40, GridUnitType.Star),
                Discovering = false,
            });

            Items.Add(new Monkey
            {
                Label = "20K",
                Bar1 = new GridLength(40, GridUnitType.Star),
                Bar2 = new GridLength(50, GridUnitType.Star),
                Bar3 = new GridLength(10, GridUnitType.Star),
                Discovering = false,
            });
        }

        public ICommand OpenWebCommand { get; }
    }
}