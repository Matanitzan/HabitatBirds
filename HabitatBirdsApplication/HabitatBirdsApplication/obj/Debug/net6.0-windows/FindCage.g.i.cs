﻿#pragma checksum "..\..\..\FindCage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DF2A4B6F80191E3CEB0790EF356F04B0D2110380"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HabitatBirdsApplication;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace HabitatBirdsApplication {
    
    
    /// <summary>
    /// FindCage
    /// </summary>
    public partial class FindCage : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OptionTypeToFind;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label insertValueLable;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FindCageText;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchCage;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewCage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn serialNumberText;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn MaterialText;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn WidthText;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn HeightText;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn LengthText;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\FindCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn InfoCage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HabitatBirdsApplication;V1.0.0.0;component/findcage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FindCage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OptionTypeToFind = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\FindCage.xaml"
            this.OptionTypeToFind.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.insertValueLable = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.FindCageText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnSearchCage = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\FindCage.xaml"
            this.btnSearchCage.Click += new System.Windows.RoutedEventHandler(this.btnSearchCage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListViewCage = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.serialNumberText = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 7:
            this.MaterialText = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 8:
            this.WidthText = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 9:
            this.HeightText = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 10:
            this.LengthText = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 11:
            this.InfoCage = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 12:
            
            #line 66 "..\..\..\FindCage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInfoCage_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

