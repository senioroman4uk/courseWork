﻿#pragma checksum "..\..\MenuControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D9DCC6E1084F1445408D81C901A205A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// MenuControl
    /// </summary>
    public partial class MenuControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal InstrClient.MenuControl Menu;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MainMenu;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SettingsMenu;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ConfigSettings;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AccountSettings;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem StartMenu;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem QuitMenu;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MenuControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AboutMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/InstrClient;component/menucontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuControl.xaml"
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
            this.Menu = ((InstrClient.MenuControl)(target));
            return;
            case 2:
            this.MainMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            this.SettingsMenu = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.ConfigSettings = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\MenuControl.xaml"
            this.ConfigSettings.Click += new System.Windows.RoutedEventHandler(this.ConfigSettings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AccountSettings = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\MenuControl.xaml"
            this.AccountSettings.Click += new System.Windows.RoutedEventHandler(this.AccountSettings_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StartMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\MenuControl.xaml"
            this.StartMenu.Click += new System.Windows.RoutedEventHandler(this.StartMenu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.QuitMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\MenuControl.xaml"
            this.QuitMenu.Click += new System.Windows.RoutedEventHandler(this.QuitMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AboutMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\MenuControl.xaml"
            this.AboutMenu.Click += new System.Windows.RoutedEventHandler(this.AboutMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

