using System.ComponentModel;
using teleMagApp.ViewModels;
using Xamarin.Forms;

namespace teleMagApp.Views
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