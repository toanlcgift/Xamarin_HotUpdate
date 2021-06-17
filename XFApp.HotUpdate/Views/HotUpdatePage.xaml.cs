using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFApp.HotUpdate.ViewModels;

namespace XFApp.HotUpdate.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotUpdatePage : ContentPage
    {
        public HotUpdatePage()
        {
            InitializeComponent();
            MessagingCenter.Instance.Subscribe<Button>(button, "Clicked",
                (obj) =>
                {
                    DisplayAlert("Alert", "Button Clicked!", "OK");
                });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }

    public class HotUpdateButton : Button
    {

    }
}