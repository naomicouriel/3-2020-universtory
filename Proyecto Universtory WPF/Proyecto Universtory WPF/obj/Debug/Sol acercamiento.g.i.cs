﻿#pragma checksum "..\..\Sol acercamiento.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D8493C476DAD829258EB761806C86805FEE6DFC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto_Universtory_WPF;
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


namespace Proyecto_Universtory_WPF {
    
    
    /// <summary>
    /// Sol_acercamiento
    /// </summary>
    public partial class Sol_acercamiento : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Sol acercamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderSol;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Sol acercamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VolSolbtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Sol acercamiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DatSolbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyecto Universtory WPF;component/sol%20acercamiento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sol acercamiento.xaml"
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
            this.sliderSol = ((System.Windows.Controls.Slider)(target));
            
            #line 14 "..\..\Sol acercamiento.xaml"
            this.sliderSol.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VolSolbtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Sol acercamiento.xaml"
            this.VolSolbtn.Click += new System.Windows.RoutedEventHandler(this.VolSolbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DatSolbtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Sol acercamiento.xaml"
            this.DatSolbtn.Click += new System.Windows.RoutedEventHandler(this.DatSolbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

