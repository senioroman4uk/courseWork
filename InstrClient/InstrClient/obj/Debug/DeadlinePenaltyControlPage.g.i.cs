﻿#pragma checksum "..\..\DeadlinePenaltyControlPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81EEF4C4E35CD551B22C520D845C3A09"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InstrClient;
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


namespace InstrClient {
    
    
    /// <summary>
    /// DeadlinePenaltyControlPage
    /// </summary>
    public partial class DeadlinePenaltyControlPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\DeadlinePenaltyControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\DeadlinePenaltyControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal InstrClient.Tree TreeName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\DeadlinePenaltyControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GroupBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\DeadlinePenaltyControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SubjectBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\DeadlinePenaltyControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PenaltyValue;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DeadlinePenaltyControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PenaltyDays;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DeadlinePenaltyControlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
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
            System.Uri resourceLocater = new System.Uri("/InstrClient;component/deadlinepenaltycontrolpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DeadlinePenaltyControlPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 8 "..\..\DeadlinePenaltyControlPage.xaml"
            ((InstrClient.DeadlinePenaltyControlPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.TreeName = ((InstrClient.Tree)(target));
            return;
            case 4:
            this.GroupBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\DeadlinePenaltyControlPage.xaml"
            this.GroupBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GroupBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SubjectBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\DeadlinePenaltyControlPage.xaml"
            this.SubjectBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SubjectBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PenaltyValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PenaltyDays = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\DeadlinePenaltyControlPage.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
