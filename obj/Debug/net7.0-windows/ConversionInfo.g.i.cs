﻿#pragma checksum "..\..\..\ConversionInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E8B1B2CD0C1D0E09FE4D9270C06624AB72FCA19F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Currency_Convertor;
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


namespace Currency_Convertor {
    
    
    /// <summary>
    /// ConversionInfo
    /// </summary>
    public partial class ConversionInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\ConversionInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConversionButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ConversionInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExchangeButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ConversionInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FirstCurrency;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ConversionInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SecondCurrency;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\ConversionInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputAmount;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ConversionInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultAmount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Currency_Convertor;V1.0.0.0;component/conversioninfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ConversionInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ConversionButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\ConversionInfo.xaml"
            this.ConversionButton.Click += new System.Windows.RoutedEventHandler(this.ConversionButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExchangeButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\ConversionInfo.xaml"
            this.ExchangeButton.Click += new System.Windows.RoutedEventHandler(this.ExchangeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FirstCurrency = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\ConversionInfo.xaml"
            this.FirstCurrency.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FirstCurrency_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SecondCurrency = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\ConversionInfo.xaml"
            this.SecondCurrency.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SecondCurrency_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.InputAmount = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\ConversionInfo.xaml"
            this.InputAmount.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.InputAmount_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ResultAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

