﻿#pragma checksum "..\..\..\ViewTable\WindowUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "771376FFDFAF4BC530C3E04D7CE6D4F659E909074CBD5C2CECF4E2E49CC14721"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Programm.ViewTable;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Programm.ViewTable {
    
    
    /// <summary>
    /// WindowUser
    /// </summary>
    public partial class WindowUser : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\..\ViewTable\WindowUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_User1;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ViewTable\WindowUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Programm;component/viewtable/windowuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewTable\WindowUser.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\ViewTable\WindowUser.xaml"
            ((Programm.ViewTable.WindowUser)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 25 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Glav);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Empl);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_LD);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_DE);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 29 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Pass);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 30 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_State);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Btn_User1 = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ViewTable\WindowUser.xaml"
            this.Btn_User1.Click += new System.Windows.RoutedEventHandler(this.Btn_User);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 32 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Exit);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 37 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Add);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 38 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Edit);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 39 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Del);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 40 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Otchet);
            
            #line default
            #line hidden
            return;
            case 14:
            this.UserGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 15:
            
            #line 52 "..\..\..\ViewTable\WindowUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Edit);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
