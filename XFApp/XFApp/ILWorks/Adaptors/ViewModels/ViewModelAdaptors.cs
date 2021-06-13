using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using System;
using System.Collections.Generic;
using System.Text;
using XFApp.ViewModels.Base;
using AppDomain = ILRuntime.Runtime.Enviorment.AppDomain;

namespace XFApp.ILWorks.Adaptors.ViewModels
{
    public class ViewModelAdaptors : CrossBindingAdaptor
    {
        public override Type BaseCLRType => typeof(ViewModelBase);

        public override Type AdaptorType => typeof(MyViewModel);

        public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
        {
            return new MyViewModel(appdomain, instance);
        }

        class MyViewModel : ViewModelBase, CrossBindingAdaptorType
        {
            ILTypeInstance instance;
            AppDomain appdomain;
            public ILTypeInstance ILInstance => this.instance;


            IMethod mOnAppearing;
            bool mOnAppearingGot;
            bool mOnAppearingInvoking;

            public MyViewModel() { }
            public MyViewModel(AppDomain appdomain, ILTypeInstance instance)
            {
                this.appdomain = appdomain;
                this.instance = instance;
            }

        }
    }
}
