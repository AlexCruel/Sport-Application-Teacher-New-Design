﻿#pragma checksum "..\..\..\Pages\AnalysisPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E08142070F26CBDD3640BB768386C2AA0B62662C136E5679A2B1089E23E6BC91"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Sport_Application_Teacher__New_Design_.Pages;
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


namespace Sport_Application_Teacher__New_Design_.Pages {
    
    
    /// <summary>
    /// AnalysisPage
    /// </summary>
    public partial class AnalysisPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Pages\AnalysisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox facultyBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\AnalysisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox specBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\AnalysisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox groupBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\AnalysisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShow;
        
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
            System.Uri resourceLocater = new System.Uri("/Sport Application Teacher (New Design);component/pages/analysispage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AnalysisPage.xaml"
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
            this.facultyBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\Pages\AnalysisPage.xaml"
            this.facultyBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.facultyBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.specBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.groupBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\Pages\AnalysisPage.xaml"
            this.groupBox.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.groupBox_GotMouseCapture);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonShow = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\AnalysisPage.xaml"
            this.buttonShow.Click += new System.Windows.RoutedEventHandler(this.ButtonShowHours);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

