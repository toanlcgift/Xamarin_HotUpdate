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
            this.BindingContext = new ViewModels.ViewModelTest() { Title = "My test title" };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            (this.BindingContext as ViewModelTest).Title = "My title Onappearing";
            (this.BindingContext as ViewModelTest).Test = "test2 ViewModel";
        }
    }

    public class HotUpdateButton : Button
    {
        public static string ButtonClick(object sender, EventArgs e)
        {
            (sender as Button).Text = Guid.NewGuid().ToString();
            return (sender as Button).Text;
        }
    }
}