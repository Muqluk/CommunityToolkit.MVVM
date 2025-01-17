﻿using System.Windows;
using CommunityToolkit.Mvvm.DependencyInjection;

using MC.UI.Core;

namespace MC.UI.Views {
  public partial class MainWindow : Window {
    public MainWindow() {
      DataContext = Ioc.Default.GetService<MainWindowViewModel>();
      InitializeComponent();
    }
  }
}
