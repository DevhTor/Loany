using Loany.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Loany.Views
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