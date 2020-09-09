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

namespace BrainAnalysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        /// <summary>
        /// Page and Logo button function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logo_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// common tool button function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Button_Click(object sender, RoutedEventArgs e) 
        {
            if (MessageBox.Show("Select_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Zoom_In_Out_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Zoom_In_Out_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }
        
        private void Pan_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Pan_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Whirl_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Whirl_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }
        

        private void Fit_Window_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Fit_Window_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Default_Window_Width_Height_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Default_Window_Width_Height_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }
        private void Pixel_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Pixel_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Draw_Circle_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Draw_Circle_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Measure_Angle_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Measure_Angle_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Measure_Line_Distance_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Measure_Line_Distance_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Add_Arrow_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Add_Arrow_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void Delete_All_Roi_Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Delete_All_Roi_Button_Click", "Status", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                ;
            }
            else
            {
                ;

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
