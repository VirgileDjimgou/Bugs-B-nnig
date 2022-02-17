using System.ComponentModel;
using Xamarin.Forms;
using XamTrack.ViewModels;

namespace XamTrack.Views
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