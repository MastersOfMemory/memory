﻿#pragma checksum "..\..\..\Pages\gameproperties.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E24955DC526B4306C3A25A6E0D8903883805095197F23C077E72CE6975C02500"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using mastersofmemory.Pages;
using mastersofmemory.Pages.UserControls;


namespace mastersofmemory.Pages {
    
    
    /// <summary>
    /// gameproperties
    /// </summary>
    public partial class gameproperties : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label singlePlayer_Label;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label multiPlayer_Label;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox singlePlayer_Input;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox multiPlayer_Check;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox multiPlayer_Input;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label singlePlayer_Test;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label multiPlayer_Test;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button start_Game;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\gameproperties.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backto_Menu;
        
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
            System.Uri resourceLocater = new System.Uri("/mastersofmemory;component/pages/gameproperties.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\gameproperties.xaml"
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
            this.singlePlayer_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.multiPlayer_Label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.singlePlayer_Input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.multiPlayer_Check = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.multiPlayer_Input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.singlePlayer_Test = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.multiPlayer_Test = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.start_Game = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Pages\gameproperties.xaml"
            this.start_Game.Click += new System.Windows.RoutedEventHandler(this.StartGame_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.backto_Menu = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Pages\gameproperties.xaml"
            this.backto_Menu.Click += new System.Windows.RoutedEventHandler(this.BackToMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

