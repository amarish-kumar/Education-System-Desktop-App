﻿#pragma checksum "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "23AF4DADAA55B9308495A2D4EC82225C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ES.UI;
using ExtendedGrid.ExtendedColumn;
using ExtendedGrid.ExtendedGridControl;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ES.UI.Setups {
    
    
    /// <summary>
    /// ucStudentFee
    /// </summary>
    public partial class ucStudentFee : ES.UI.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ES.UI.Setups.ucStudentFee CustomUserControl;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ShellHeader;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewClassMarks;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid grid;
        
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
            System.Uri resourceLocater = new System.Uri("/ES.UI;component/setups/finance/fee/ucstudentfee%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
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
            this.CustomUserControl = ((ES.UI.Setups.ucStudentFee)(target));
            return;
            case 2:
            this.ShellHeader = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 34 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 61 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Student_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnViewClassMarks = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\..\..\Setups\Finance\Fee\ucStudentFee - Copy.xaml"
            this.btnViewClassMarks.Click += new System.Windows.RoutedEventHandler(this.btnViewClassMarks_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.grid = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
