﻿#pragma checksum "Views\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5BDD0F4320DEC39EEF196773D15680E15DD6A7515FBF48E5BA59E05F9D06D64B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KeyboardTrainer;
using MyApp.Tools;
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


namespace KeyboardTrainer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 62 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image_githubLink;
        
        #line default
        #line hidden
        
        
        #line 63 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image_Update;
        
        #line default
        #line hidden
        
        
        #line 64 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image_Settings;
        
        #line default
        #line hidden
        
        
        #line 65 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image_Info;
        
        #line default
        #line hidden
        
        
        #line 69 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_learning;
        
        #line default
        #line hidden
        
        
        #line 70 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_training;
        
        #line default
        #line hidden
        
        
        #line 71 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_manual;
        
        #line default
        #line hidden
        
        
        #line 73 "Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_language;
        
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
            System.Uri resourceLocater = new System.Uri("/KeyboardTrainer;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "Views\MainWindow.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.image_githubLink = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.image_Update = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.image_Settings = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.image_Info = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.btn_learning = ((System.Windows.Controls.Button)(target));
            
            #line 69 "Views\MainWindow.xaml"
            this.btn_learning.Click += new System.Windows.RoutedEventHandler(this.Btn_learning_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_training = ((System.Windows.Controls.Button)(target));
            
            #line 70 "Views\MainWindow.xaml"
            this.btn_training.Click += new System.Windows.RoutedEventHandler(this.Btn_myResults_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_manual = ((System.Windows.Controls.Button)(target));
            
            #line 71 "Views\MainWindow.xaml"
            this.btn_manual.Click += new System.Windows.RoutedEventHandler(this.Btn_manual_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cb_language = ((System.Windows.Controls.ComboBox)(target));
            
            #line 73 "Views\MainWindow.xaml"
            this.cb_language.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_SelectedLangugeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

