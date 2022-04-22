using KlimovPR15.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KlimovPR15.Views
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