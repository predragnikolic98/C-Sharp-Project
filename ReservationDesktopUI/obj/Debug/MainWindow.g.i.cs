﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "025B08FC33AFF663A78E57AA1F70FCDCF44810264FB399F38C7C005C4DB96129"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using ReservationDesktopUI;
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


namespace ReservationDesktopUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 89 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Options;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkbox29;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkbox30;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSurname;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMobileNumber;
        
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
            System.Uri resourceLocater = new System.Uri("/ReservationDesktopUI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Options = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.chkbox29 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.chkbox30 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.txtName = ((System.Windows.Controls.TextBox)(target));
            
            #line 167 "..\..\MainWindow.xaml"
            this.txtName.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtName_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 167 "..\..\MainWindow.xaml"
            this.txtName.PreviewLostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtName_PreviewLostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtSurname = ((System.Windows.Controls.TextBox)(target));
            
            #line 169 "..\..\MainWindow.xaml"
            this.txtSurname.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtSurname_MouseEnter);
            
            #line default
            #line hidden
            
            #line 169 "..\..\MainWindow.xaml"
            this.txtSurname.MouseLeave += new System.Windows.Input.MouseEventHandler(this.txtSurname_MouseLeave);
            
            #line default
            #line hidden
            
            #line 170 "..\..\MainWindow.xaml"
            this.txtSurname.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtSurname_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 170 "..\..\MainWindow.xaml"
            this.txtSurname.PreviewLostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtSurname_PreviewLostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 172 "..\..\MainWindow.xaml"
            this.txtEmail.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtEmail_MouseEnter);
            
            #line default
            #line hidden
            
            #line 172 "..\..\MainWindow.xaml"
            this.txtEmail.MouseLeave += new System.Windows.Input.MouseEventHandler(this.txtEmail_MouseLeave);
            
            #line default
            #line hidden
            
            #line 173 "..\..\MainWindow.xaml"
            this.txtEmail.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtEmail_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 173 "..\..\MainWindow.xaml"
            this.txtEmail.PreviewLostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtEmail_PreviewLostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtMobileNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 175 "..\..\MainWindow.xaml"
            this.txtMobileNumber.MouseEnter += new System.Windows.Input.MouseEventHandler(this.txtMobileNumber_MouseEnter);
            
            #line default
            #line hidden
            
            #line 175 "..\..\MainWindow.xaml"
            this.txtMobileNumber.MouseLeave += new System.Windows.Input.MouseEventHandler(this.txtMobileNumber_MouseLeave);
            
            #line default
            #line hidden
            
            #line 176 "..\..\MainWindow.xaml"
            this.txtMobileNumber.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.txtMobileNumber_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 176 "..\..\MainWindow.xaml"
            this.txtMobileNumber.PreviewLostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtMobileNumber_PreviewLostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 179 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OptOK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

