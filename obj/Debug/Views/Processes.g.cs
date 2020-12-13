﻿#pragma checksum "..\..\..\Views\Processes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "327CD3F961E625E70836695D26267276F4DD8F158D5E991BBA408DE8C7735702"
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
using PrismApp;
using PrismApp.ViewModels;
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
    /// Processes
    /// </summary>
    public partial class Processes : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ProcessListBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PnlMainGrid2;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kill;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortId;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortName;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpPriority;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Views\Processes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownPriority;
        
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
            System.Uri resourceLocater = new System.Uri("/PrismApp;component/views/processes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Processes.xaml"
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
            this.ProcessListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.PnlMainGrid2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Start = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Views\Processes.xaml"
            this.Start.Click += new System.Windows.RoutedEventHandler(this.OnClickStart);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Kill = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Views\Processes.xaml"
            this.Kill.Click += new System.Windows.RoutedEventHandler(this.OnClickKill);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SortId = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Views\Processes.xaml"
            this.SortId.Click += new System.Windows.RoutedEventHandler(this.OnSortIdClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SortName = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Views\Processes.xaml"
            this.SortName.Click += new System.Windows.RoutedEventHandler(this.OnSortNameClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.UpPriority = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Views\Processes.xaml"
            this.UpPriority.Click += new System.Windows.RoutedEventHandler(this.OnHigherPriorityClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DownPriority = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Views\Processes.xaml"
            this.DownPriority.Click += new System.Windows.RoutedEventHandler(this.OnLowerPriorityClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

