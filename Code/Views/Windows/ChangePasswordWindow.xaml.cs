﻿using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow 
    {
        private readonly ChangePasswordViewModel _viewModel;

        public ChangePasswordWindow()
        {
            InitializeComponent();

            _viewModel = new ChangePasswordViewModel();

            DataContext = _viewModel;
        }
    }
}
