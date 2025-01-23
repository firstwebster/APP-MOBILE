using APPMOBMEDIA.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace APPMOBMEDIA.Views
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