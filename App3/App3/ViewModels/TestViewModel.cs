using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ProgressBar;

public class Monkey
{
    public string Label { get; set; }
    public GridLength Bar1 { get; set; }
    public GridLength Bar2 { get; set; }
    public GridLength Bar3 { get; set; }
    public bool Discovering { get; set; }
    public int Knew { get; set; }
    public int ToLearn { get; set; }
    public int Uncover { get; set; }

}

namespace App3.ViewModels
{

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
             //   OnPropertyChanged();
            }
        }

        public TestViewModel()
        {
            Title = "Test";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            Items = new ObservableCollection<Monkey>();
            Items.Add(new Monkey
            {
                Label = "1K",
        
       
            });
            Items.Add(new Monkey
            {
                Label = "2K",

            });
            Items.Add(new Monkey
            {
                Label = "3K",
      
        
            });
        }

        public ICommand OpenWebCommand { get; }
    }
}