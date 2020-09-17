using System;
using System.Windows;
using System.Windows.Input;

namespace LinkSettingDemo
{
    public class CheckBoxViewModel : AppViewModelBase
    {
        private bool isChecked;

        public bool IsChecked
        {
            get { return isChecked; }
            set 
            { 
                isChecked = value;
                if (isChecked)
                {
                    //MainWindowViewModel.GetCheckBoxListSelectedCount();
                    //MessageBox.Show(MainWindowViewModel.GetCheckBoxListSelectedCount().ToString() + "checked!");
                }
                else
                {
                    //MessageBox.Show("unchecked!");
                }
                RaisePropertyChanged("IsChecked"); 
            }
        }

        public string Name { get; set; }
    }
}