﻿#pragma checksum "..\..\AddTeacher.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B3166625C2F9AF78F91C0A4C17AA411AA391A8C463135DE2763B329A4098700A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PracProjectGui;
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


namespace PracProjectGui {
    
    
    /// <summary>
    /// AddTeacher
    /// </summary>
    public partial class AddTeacher : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOutBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TMail;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TAddress;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TDegree;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertBtn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncClr;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddTeacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TId;
        
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
            System.Uri resourceLocater = new System.Uri("/PracProjectGui;component/addteacher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddTeacher.xaml"
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
            this.LogOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\AddTeacher.xaml"
            this.LogOutBtn.Click += new System.Windows.RoutedEventHandler(this.LogOutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TName = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\AddTeacher.xaml"
            this.TName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TMail = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\AddTeacher.xaml"
            this.TMail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TMail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TAddress = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\AddTeacher.xaml"
            this.TAddress.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TAddress_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TDegree = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\AddTeacher.xaml"
            this.TDegree.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TDegree_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LoadBtn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AddTeacher.xaml"
            this.LoadBtn.Click += new System.Windows.RoutedEventHandler(this.LoadBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\AddTeacher.xaml"
            this.UpdateBtn.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\AddTeacher.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.InsertBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\AddTeacher.xaml"
            this.InsertBtn.Click += new System.Windows.RoutedEventHandler(this.InsertBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.HomeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\AddTeacher.xaml"
            this.HomeBtn.Click += new System.Windows.RoutedEventHandler(this.HomeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btncClr = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\AddTeacher.xaml"
            this.btncClr.Click += new System.Windows.RoutedEventHandler(this.btncClr_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TId = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\AddTeacher.xaml"
            this.TId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TId_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

