﻿using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for BookImportInfoWindow.xaml
    /// </summary>
    public partial class BookImportInfoWindow
    {
        private readonly BookImportInfoViewModel viewModel;

        public BookImportInfoWindow()
        {
            InitializeComponent();

            viewModel = new BookImportInfoViewModel();

            DataContext = viewModel;    
        }
    }
}
