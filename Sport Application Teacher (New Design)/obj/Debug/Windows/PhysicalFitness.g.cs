﻿#pragma checksum "..\..\..\Windows\PhysicalFitness.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44A1F92855E2EA3A67371EF1E41927B8C0F147CF07982C41B0E06D08B8714A0F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Sport_Application_Teacher__New_Design_.Admin;
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


namespace Sport_Application_Teacher__New_Design_.Admin {
    
    
    /// <summary>
    /// PhysicalFitness
    /// </summary>
    public partial class PhysicalFitness : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Windows\PhysicalFitness.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox semester;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\PhysicalFitness.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox discipline;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\PhysicalFitness.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock studBlock;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\PhysicalFitness.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid studHoursGrid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\PhysicalFitness.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox result;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\PhysicalFitness.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mark;
        
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
            System.Uri resourceLocater = new System.Uri("/Sport Application Teacher (New Design);component/windows/physicalfitness.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\PhysicalFitness.xaml"
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
            this.semester = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.discipline = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.studBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.studHoursGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.result = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Windows\PhysicalFitness.xaml"
            this.result.GotFocus += new System.Windows.RoutedEventHandler(this.result_GotFocus);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\Windows\PhysicalFitness.xaml"
            this.result.LostFocus += new System.Windows.RoutedEventHandler(this.result_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mark = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Windows\PhysicalFitness.xaml"
            this.mark.GotFocus += new System.Windows.RoutedEventHandler(this.mark_GotFocus);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\Windows\PhysicalFitness.xaml"
            this.mark.LostFocus += new System.Windows.RoutedEventHandler(this.mark_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 37 "..\..\..\Windows\PhysicalFitness.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Record);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 38 "..\..\..\Windows\PhysicalFitness.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Back);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

