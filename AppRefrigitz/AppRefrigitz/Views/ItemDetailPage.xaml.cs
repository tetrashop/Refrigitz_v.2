using AppRefrigitz.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppRefrigitz.Views
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