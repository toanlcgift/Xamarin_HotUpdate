using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFApp.HotUpdate.Views;

namespace XFApp.HotUpdate
{
    public class Main
    {
        public static async Task OpenUIAsync()
        {
            Console.WriteLine("OpenUIAsync");
            await (App.Current.MainPage as NavigationPage).PushAsync(new HotUpdatePage());
            Console.WriteLine("done OpenUIAsync");
        }
    }
}
