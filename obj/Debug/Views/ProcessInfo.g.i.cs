﻿#pragma checksum "..\..\..\Views\ProcessInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7D4515081E6E764E7761FA8D7DA6C143859DDC4D9E8741A2C9E1777DA58B2C64"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using Prism.Unity;
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


namespace PrismApp.Views {
    
    
    /// <summary>
    /// ProcessInfo
    /// </summary>
    public partial class ProcessInfo : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Views\ProcessInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid pnlMainGrid2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\ProcessInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\ProcessInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kill;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\ProcessInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sort;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\ProcessInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
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
            System.Uri resourceLocater = new System.Uri("/PrismApp;component/views/processinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ProcessInfo.xaml"
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
            this.pnlMainGrid2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Start = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\ProcessInfo.xaml"
            this.Start.Click += new System.Windows.RoutedEventHandler(this.OnClickStart);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Kill = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\ProcessInfo.xaml"
            this.Kill.Click += new System.Windows.RoutedEventHandler(this.OnClickKill);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Sort = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\ProcessInfo.xaml"
            this.Sort.Click += new System.Windows.RoutedEventHandler(this.OnSortClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\ProcessInfo.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.OnClickRefresh);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

