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


    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {
        Data_Gathering_WPF dataProviding = new Data_Gathering_WPF();
        IDataProvider provider = new Data_Gathering(dataProviding.calling_User_inputs_No1());
        IManipulator manipulator = new Data_Manipulation(dataProviding.calling_User_inputs_No1(), dataProviding.calling_User_inputs_No2());
        Main_Interface LES_solving = new Main_Interface( provider, manipulator);
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
