﻿#pragma checksum "C:\Users\Harold\Documents\Visual Studio 2012\Projects\GovBids\GovBids\Pages\FilterSetting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E0BE10F11ADD9FC7F7499038C3283617"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace GovBids.Pages {
    
    
    public partial class FilterSetting : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.DataTemplate PickerItemTemplate;
        
        internal System.Windows.DataTemplate PickerFullModeItemTemplate;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.ListPicker locationPicker;
        
        internal Microsoft.Phone.Controls.ListPicker categoryPicker;
        
        internal Microsoft.Phone.Controls.ListPicker agencyPicker;
        
        internal Telerik.Windows.Controls.RadBusyIndicator busyIndicator;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GovBids;component/Pages/FilterSetting.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PickerItemTemplate = ((System.Windows.DataTemplate)(this.FindName("PickerItemTemplate")));
            this.PickerFullModeItemTemplate = ((System.Windows.DataTemplate)(this.FindName("PickerFullModeItemTemplate")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.locationPicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("locationPicker")));
            this.categoryPicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("categoryPicker")));
            this.agencyPicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("agencyPicker")));
            this.busyIndicator = ((Telerik.Windows.Controls.RadBusyIndicator)(this.FindName("busyIndicator")));
        }
    }
}

