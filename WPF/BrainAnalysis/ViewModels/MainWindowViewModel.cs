using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace BrainAnalysis
{
    public class MainWindowViewModel
    {
        public Image FirstImage { get; set; }

        public MainWindowViewModel()
        {
            FirstImage = new Image();
            FirstImage.Source = new BitmapImage(new Uri("D:/Project_Code/WPF/BrainAnalysis/Image/example_2.png"));
        }
    }
}