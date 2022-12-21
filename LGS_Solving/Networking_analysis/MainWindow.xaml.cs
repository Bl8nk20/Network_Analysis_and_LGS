﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LGS_Solving_Libary;

namespace Networking_analysis;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Initialize
    public MainWindow()
    {
        InitializeComponent();
    }

    // Debugging
    public readonly double Uq1 = 12;

    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {
        IDataProvider<double> provider = new Data_Gathering(Uq1: Uq1);
    }

    private void Show_Values(object sender, MouseButtonEventArgs e)
    {
        
    }

    private void Hide_Values(object sender, MouseButtonEventArgs e)
    {

    }

    private void Update_Values(object sender, DataTransferEventArgs e)
    {

    }
}
