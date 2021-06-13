using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XFApp.ViewModels.Base;

namespace XFApp.HotUpdate.ViewModels
{
    
    public class ViewModelTest : ViewModelBase
    {
        string test = string.Empty;
        public string Test
        {
            get { return test; }
            set { SetProperty(ref test, value); }
        }
        public ViewModelTest()
        {
            Test = "Test ViewModel";
        }
    }
}
