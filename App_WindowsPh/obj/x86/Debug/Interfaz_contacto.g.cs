﻿

#pragma checksum "C:\Users\fany_\Documents\Visual Studio 2015\Projects\App_WindowsPh\App_WindowsPh\Interfaz_contacto.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63F5A0BAC7DD905F96B6DE8739B3CAC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App_WindowsPh
{
    partial class Interfaz_VAlumno : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 9 "..\..\..\Interfaz_contacto.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.MuestraLista;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 12 "..\..\..\Interfaz_contacto.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AddContact_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 13 "..\..\..\Interfaz_contacto.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.DeleteAll_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 14 "..\..\..\Interfaz_contacto.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.listBox_SelectionChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


