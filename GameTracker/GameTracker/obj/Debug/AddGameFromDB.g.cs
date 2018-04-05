﻿#pragma checksum "..\..\AddGameFromDB.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58FF857D0DAD6D59E9974D26C2FB7A992ECE5A21"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameTracker;
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


namespace GameTracker {
    
    
    /// <summary>
    /// AddGameFromDB
    /// </summary>
    public partial class AddGameFromDB : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDatabaseSearch;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchDB;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearDBSearch;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtNumResultsFound;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstDBSearchResults;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgResult;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollResultInfo;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtResultInformation;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AddGameFromDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/GameTracker;component/addgamefromdb.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddGameFromDB.xaml"
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
            this.txtDatabaseSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\AddGameFromDB.xaml"
            this.txtDatabaseSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtDatabaseSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSearchDB = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\AddGameFromDB.xaml"
            this.btnSearchDB.Click += new System.Windows.RoutedEventHandler(this.btnSearchDB_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClearDBSearch = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\AddGameFromDB.xaml"
            this.btnClearDBSearch.Click += new System.Windows.RoutedEventHandler(this.btnClearDBSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtNumResultsFound = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lstDBSearchResults = ((System.Windows.Controls.ListBox)(target));
            
            #line 34 "..\..\AddGameFromDB.xaml"
            this.lstDBSearchResults.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstDBSearchResults_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imgResult = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.scrollResultInfo = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 8:
            this.txtResultInformation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\AddGameFromDB.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnCancelAdd = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\AddGameFromDB.xaml"
            this.btnCancelAdd.Click += new System.Windows.RoutedEventHandler(this.btnCancelAdd_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

