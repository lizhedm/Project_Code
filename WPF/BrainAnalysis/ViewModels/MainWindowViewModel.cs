using System.Windows;
using System.Windows.Input;

namespace BrainAnalysis
{
    public class MainWindowViewModel : AppViewModelBase
    {
        public MainWindowViewModel()
        {

        }

        #region ChangePageCommand
        public ICommand ChangePageCommand => new DelegateCommand(ChangePage);

        private void ChangePage(object commandParameter)
        {
            MessageBox.Show("ChangePage");
        }
        #endregion

        #region ShowLogoInfoCommand
        public ICommand ShowLogoInfoCommand => new DelegateCommand(ShowLogoInfo);

        private void ShowLogoInfo(object commandParameter)
        {
            MessageBox.Show("ShowLogoInfo");
        }
        #endregion
    }
}