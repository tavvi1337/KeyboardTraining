﻿#pragma checksum "..\..\..\..\Views\MainMenu\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC3AFD1AF5588785D18CEF003555478A91F94E0B6B057F8CCE6B4299A60765B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
        
        
        #line 56 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_learning;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_training;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_manual;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/KeyboardTrainer;component/views/mainmenu/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
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
            this.btn_learning = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
            this.btn_learning.Click += new System.Windows.RoutedEventHandler(this.Btn_learning_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_training = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
            this.btn_training.Click += new System.Windows.RoutedEventHandler(this.Btn_myResults_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_manual = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
            this.btn_manual.Click += new System.Windows.RoutedEventHandler(this.Btn_manual_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cb_language = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\..\..\Views\MainMenu\MainWindow.xaml"
            this.cb_language.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_SelectedLangugeChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

