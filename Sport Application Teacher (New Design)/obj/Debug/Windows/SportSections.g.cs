﻿#pragma checksum "..\..\..\Windows\SportSections.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2AED24790C45AE83EA2CD9A80686AB6DF7F6FB3C127450E6999C810FD8CB9045"
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
    /// SportSections
    /// </summary>
    public partial class SportSections : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Windows\SportSections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock studBlock;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Windows\SportSections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid studHoursGrid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\SportSections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Windows\SportSections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker date;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\SportSections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox person;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\SportSections.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hours;
        
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
            System.Uri resourceLocater = new System.Uri("/Sport Application Teacher (New Design);component/windows/sportsections.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\SportSections.xaml"
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
            this.studBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.studHoursGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Windows\SportSections.xaml"
            this.name.GotFocus += new System.Windows.RoutedEventHandler(this.name_GotFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Windows\SportSections.xaml"
            this.name.LostFocus += new System.Windows.RoutedEventHandler(this.name_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.person = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\Windows\SportSections.xaml"
            this.person.GotFocus += new System.Windows.RoutedEventHandler(this.person_GotFocus);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Windows\SportSections.xaml"
            this.person.LostFocus += new System.Windows.RoutedEventHandler(this.person_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 16 "..\..\..\Windows\SportSections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Record);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 17 "..\..\..\Windows\SportSections.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Back);
            
            #line default
            #line hidden
            return;
            case 8:
            this.hours = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

