using ClientesApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ClientesApp.Views
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