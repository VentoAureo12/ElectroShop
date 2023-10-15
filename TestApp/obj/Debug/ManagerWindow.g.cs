﻿#pragma checksum "..\..\ManagerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20A7FCCF13EBD2AC8058B0D3DB7256D0D81D5523DCBFE7B28525BC4C00F67E7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TestApp;
using TestApp.Commands;


namespace TestApp {
    
    
    /// <summary>
    /// ManagerWindow
    /// </summary>
    public partial class ManagerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar ToolBar1;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Undo;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Find;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SwitchToOrderDataGridButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SwitchToOrderGoodDataGridButton;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderFind;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderIDSearchField;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DeliverySpotSearchComboBox;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OrderStatusСomboBox;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderGoodFind;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderGoodIDSearchField;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrdersData;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\ManagerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrdersGoodData;
        
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
            System.Uri resourceLocater = new System.Uri("/TestApp;component/managerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManagerWindow.xaml"
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
            this.ToolBar1 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 2:
            this.Undo = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Edit = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.Find = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Save = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.SwitchToOrderDataGridButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\ManagerWindow.xaml"
            this.SwitchToOrderDataGridButton.Click += new System.Windows.RoutedEventHandler(this.SwitchToOrderDataGridButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SwitchToOrderGoodDataGridButton = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\ManagerWindow.xaml"
            this.SwitchToOrderGoodDataGridButton.Click += new System.Windows.RoutedEventHandler(this.SwitchToOrderGoodDataGridButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BorderFind = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            this.OrderIDSearchField = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\ManagerWindow.xaml"
            this.OrderIDSearchField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OrderIDSearchField_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DeliverySpotSearchComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 88 "..\..\ManagerWindow.xaml"
            this.DeliverySpotSearchComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DeliverySpotSearchComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.OrderStatusСomboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 91 "..\..\ManagerWindow.xaml"
            this.OrderStatusСomboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrderStatusСomboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.BorderGoodFind = ((System.Windows.Controls.Border)(target));
            return;
            case 14:
            this.OrderGoodIDSearchField = ((System.Windows.Controls.TextBox)(target));
            
            #line 103 "..\..\ManagerWindow.xaml"
            this.OrderGoodIDSearchField.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OrderGoodIDSearchField_TextChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.OrdersData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 16:
            this.OrdersGoodData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 17:
            
            #line 128 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Edit_Executed);
            
            #line default
            #line hidden
            
            #line 128 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Edit_CanExecute);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 129 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Save_CanExecute);
            
            #line default
            #line hidden
            
            #line 129 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_Executed);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 130 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Undo_CanExecute);
            
            #line default
            #line hidden
            
            #line 130 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Undo_Executed);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 131 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Find_CanExecute);
            
            #line default
            #line hidden
            
            #line 131 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Find_Executed);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 132 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Refresh_CanExecute);
            
            #line default
            #line hidden
            
            #line 132 "..\..\ManagerWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Refresh_Executed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

