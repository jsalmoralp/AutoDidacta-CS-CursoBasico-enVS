﻿#pragma checksum "..\..\..\..\..\Figuras\2_Dimensiones\Formas\Rectangulo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8B8B7F7AED7FEAB756D2260B1C204C2A1CFE3D45287199E832B5D08D0FA4E2CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Formas;
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


namespace Calculando_Figuras_Geometricas.Figuras._2_Dimensiones.Formas {
    
    
    /// <summary>
    /// Rectangulo
    /// </summary>
    public partial class Rectangulo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Figuras\2_Dimensiones\Formas\Rectangulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_lado_1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Figuras\2_Dimensiones\Formas\Rectangulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_calcular;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Figuras\2_Dimensiones\Formas\Rectangulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_resultado;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\Figuras\2_Dimensiones\Formas\Rectangulo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_lado_2;
        
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
            System.Uri resourceLocater = new System.Uri("/Calculando Figuras Geometricas;component/figuras/2_dimensiones/formas/rectangulo" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Figuras\2_Dimensiones\Formas\Rectangulo.xaml"
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
            this.txt_lado_1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btn_calcular = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\Figuras\2_Dimensiones\Formas\Rectangulo.xaml"
            this.btn_calcular.Click += new System.Windows.RoutedEventHandler(this.Btn_calcular_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbl_resultado = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txt_lado_2 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
