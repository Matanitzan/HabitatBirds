﻿#pragma checksum "..\..\..\NewCage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2BDCE3C9D1EB05EF7290A892D45F47F7D5B80E97"
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
    /// NewCage
    /// </summary>
    public partial class NewCage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\NewCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SerialNumberText;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\NewCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WidthCageText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\NewCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LenghtCageText;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\NewCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeightCageText;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\NewCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MetiralOptions;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\NewCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCage;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\NewCage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backHomePage;
        
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
            System.Uri resourceLocater = new System.Uri("/HabitatBirdsApplication;component/newcage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NewCage.xaml"
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
            this.SerialNumberText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.WidthCageText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LenghtCageText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.HeightCageText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MetiralOptions = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\NewCage.xaml"
            this.MetiralOptions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MetiralOptions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddCage = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\NewCage.xaml"
            this.btnAddCage.Click += new System.Windows.RoutedEventHandler(this.btnAddCage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.backHomePage = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\NewCage.xaml"
            this.backHomePage.Click += new System.Windows.RoutedEventHandler(this.backButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

