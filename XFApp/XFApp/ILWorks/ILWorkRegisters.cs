﻿using System;
using System.Collections.Generic;
using System.Text;
using XFApp.ILWorks.Adaptors;
using XFApp.ILWorks.Adaptors.Pages;
using XFApp.Services;

namespace XFApp.ILWorks
{
    public unsafe static class ILWorkRegisters
    {
        /// <summary>
        /// 注册委托
        /// </summary>
        /// <param name="hotUpdateService"></param>
        public static void RegisterDelegates(HotUpdateService hotUpdateService)
        {

        }

        internal static void RegisterCLRMethodRedirections(HotUpdateService hotUpdateService)
        {
            //CLR重定向
            //Redirect.RedirectXIL.Register(xil);
            //LitJson.JsonMapper.RegisterILRuntimeCLRRedirection(xil.ILRuntimeAppDomain);
        }

        /// <summary>
        /// 注册跨域适配器
        /// </summary>
        /// <param name="hotUpdateService"></param>
        public static void RegisterCrossBindingAdaptors(HotUpdateService hotUpdateService)
        {
            hotUpdateService.RegisterCrossBindingAdaptor(new IAsyncStateMachineClassInheritanceAdaptor()); //用于Async/await
            hotUpdateService.RegisterCrossBindingAdaptor(new ContentPageAdaptors());
        }
    }
}
