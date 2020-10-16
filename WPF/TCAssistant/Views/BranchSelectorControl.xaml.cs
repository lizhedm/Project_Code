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
using TCAssistant.ViewModels;

namespace TCAssistant
{
    /// <summary>
    /// Interaction logic for BranchSelectorControl.xaml
    /// </summary>
    public partial class BranchSelectorControl : UserControl
    {
        public BranchSelectorControl()
        {
            InitializeComponent();
            this.DataContext = new BranchSelectorViewModel();
        }
    }
}
