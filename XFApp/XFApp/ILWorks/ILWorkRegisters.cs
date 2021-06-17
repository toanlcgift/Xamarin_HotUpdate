using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XFApp.ILWorks.Adaptors;
using XFApp.ILWorks.Adaptors.Buttons;
using XFApp.ILWorks.Adaptors.Pages;
using XFApp.ILWorks.Adaptors.ViewModels;
using XFApp.Services;

namespace XFApp.ILWorks
{
    public unsafe static class ILWorkRegisters
    {
        public static void RegisterDelegates(HotUpdateService hotUpdateService)
        {
            hotUpdateService.DelegateManager.RegisterMethodDelegate<Button>();
        }

        internal static void RegisterCLRMethodRedirections(HotUpdateService hotUpdateService)
        {

        }

        public static void RegisterCrossBindingAdaptors(HotUpdateService hotUpdateService)
        {
            hotUpdateService.RegisterCrossBindingAdaptor(new IAsyncStateMachineClassInheritanceAdaptor());
            hotUpdateService.RegisterCrossBindingAdaptor(new ContentPageAdaptors());
            hotUpdateService.RegisterCrossBindingAdaptor(new ButtonAdaptors());
            hotUpdateService.RegisterCrossBindingAdaptor(new ViewModelAdaptors());
        }
    }
}
