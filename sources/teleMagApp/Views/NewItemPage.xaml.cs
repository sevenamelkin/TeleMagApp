using System;
using System.Collections.Generic;
using System.ComponentModel;
using teleMagApp.Models;
using teleMagApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace teleMagApp.Views
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