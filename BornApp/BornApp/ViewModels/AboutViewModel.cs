using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BornApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://boernenesbornholm.dk/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}