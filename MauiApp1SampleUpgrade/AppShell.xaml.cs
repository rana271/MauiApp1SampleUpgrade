using System;
using System.Collections.Generic;
using UpgradeXamarinForms.ViewModels;
using UpgradeXamarinForms.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace UpgradeXamarinForms
{
    public partial class AppShell : Microsoft.Maui.Controls.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
