﻿#pragma checksum "..\..\Tierra panorámica.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A9984A9C46420B53F5A4F28E707EBE9F02AE569"
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
    /// Tierra_panorámica
    /// </summary>
    public partial class Tierra_panorámica : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Tierra panorámica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPanoTierra;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Tierra panorámica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button flecha2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Tierra panorámica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button flecha1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Tierra panorámica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock datcuritxt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Tierra panorámica.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label datcurilbl;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyecto Universtory WPF;component/tierra%20panor%c3%a1mica.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tierra panorámica.xaml"
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
            this.btnPanoTierra = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Tierra panorámica.xaml"
            this.btnPanoTierra.Click += new System.Windows.RoutedEventHandler(this.TierraVolbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.flecha2 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Tierra panorámica.xaml"
            this.flecha2.Click += new System.Windows.RoutedEventHandler(this.flecha2_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.flecha1 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Tierra panorámica.xaml"
            this.flecha1.Click += new System.Windows.RoutedEventHandler(this.flecha1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datcuritxt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.datcurilbl = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

