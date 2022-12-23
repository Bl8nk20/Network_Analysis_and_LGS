using System;
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
using LGS_Solving_Libary.Data_Stuff;
using LGS_Solving_Libary.Interfaces;
using Networking_analysis.Gui_Data;
using IManipulator = LGS_Solving_Libary.Interfaces.IManipulator;
using Electrical_Components;

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
  //      Logic_Calling_WPF logic_Calling_WPF = new Logic_Calling_WPF();
    }


    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {
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
