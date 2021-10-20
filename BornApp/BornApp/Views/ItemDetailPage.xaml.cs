using BornApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BornApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}