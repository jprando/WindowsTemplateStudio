﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Param_ItemNamespace.Models;
using Param_ItemNamespace.Services;

namespace Param_ItemNamespace.Views
{
    public sealed partial class MasterDetailDetailPage : Page, System.ComponentModel.INotifyPropertyChanged
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public MasterDetailDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Item = e.Parameter as SampleOrder;
        }

        private void WindowStates_CurrentStateChanged(object sender, VisualStateChangedEventArgs e)
        {
            if (e.OldState == NarrowState && e.NewState == WideState)
            {
                NavigationService.GoBack();
            }
        }
    }
}
