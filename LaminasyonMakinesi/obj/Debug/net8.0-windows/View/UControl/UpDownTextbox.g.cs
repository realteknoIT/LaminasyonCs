﻿#pragma checksum "..\..\..\..\..\View\UControl\UpDownTextbox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "418151F832F1A9DAC559371DC70AD64BEE5B2DB0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using LaminasyonMakinesi.View.UControl;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace LaminasyonMakinesi.View.UControl {
    
    
    /// <summary>
    /// UpDownTextbox
    /// </summary>
    public partial class UpDownTextbox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path arrow;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path arrow2;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock baslik;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock deger;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock birim;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LaminasyonMakinesi;component/view/ucontrol/updowntextbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 36 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowLeft_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.arrow = ((System.Windows.Shapes.Path)(target));
            return;
            case 3:
            
            #line 67 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowRight_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.arrow2 = ((System.Windows.Shapes.Path)(target));
            return;
            case 5:
            this.baslik = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            
            #line 112 "..\..\..\..\..\View\UControl\UpDownTextbox.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.NumPad_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.deger = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.birim = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

