using System;
using System.Collections.Generic;
using System.ComponentModel;
using UpgradeXamarinForms.Models;
using UpgradeXamarinForms.ViewModels;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace UpgradeXamarinForms.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}