﻿#pragma checksum "C:\Investigacion\IconoCodigo\ImagenGenerar\PinMapa\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9582308C3ADF3AD3949337D45B4752EBAFD76533A4C8986D33CAC946D52E9B31"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PinMapa
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 23
                {
                    this.myMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)this.myMap).Loaded += this.myMap_Loaded;
                }
                break;
            case 3: // MainPage.xaml line 20
                {
                    this.findAtCenterButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.findAtCenterButton).Click += this.findAtCenterButton_Click;
                }
                break;
            case 4: // MainPage.xaml line 21
                {
                    this.resultStatusTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

