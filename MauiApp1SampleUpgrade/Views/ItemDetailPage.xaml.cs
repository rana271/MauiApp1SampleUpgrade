using System.ComponentModel;
using UpgradeXamarinForms.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace UpgradeXamarinForms.Views
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