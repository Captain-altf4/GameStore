﻿#pragma checksum "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00AE45A61920C857326A11CC39C6EF24C7624206"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GameStore.Custom_Controlls;
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


namespace GameStore.Custom_Controlls {
    
    
    /// <summary>
    /// WindowBorderMaxBox
    /// </summary>
    public partial class WindowBorderMaxBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Minimize;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Maximize;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_Close;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GameStore;V1.0.0.0;component/custom%20controlls/windowbordermaxbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
            ((GameStore.Custom_Controlls.WindowBorderMaxBox)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserControl_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.b_Minimize = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
            this.b_Minimize.Click += new System.Windows.RoutedEventHandler(this.b_Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.b_Maximize = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
            this.b_Maximize.Click += new System.Windows.RoutedEventHandler(this.b_Maximize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.b_Close = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Custom Controlls\WindowBorderMaxBox.xaml"
            this.b_Close.Click += new System.Windows.RoutedEventHandler(this.b_Close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

