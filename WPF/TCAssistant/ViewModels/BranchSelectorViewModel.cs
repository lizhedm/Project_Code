using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using GalaSoft.MvvmLight;

namespace TCAssistant.ViewModels
{
    class BranchSelectorViewModel : ObservableObject
    {
        private string selectedText = string.Empty;

        public string SelectedText
        {
            get
            {
                return selectedText;
            }
            set
            {
                foreach ( var item in BranchItemCheckedStates) {
                    string tempBranchItemName = "[" + item.BranchItem.BranchItemName + "]";
                    if (value.Contains(tempBranchItemName))
                    {
                        item.IsChecked = true;
                    }
                    else
                    {
                        item.IsChecked = false;
                    }
                }
                if (selectedText != value)
                {
                    selectedText = value;
                    
                    RaisePropertyChanged("SelectedText");
                }
            }
        }

        private ObservableCollection<BranchItemCheckedState> branchItems;

        public ObservableCollection<BranchItemCheckedState> BranchItemCheckedStates
        {
            get
            {
                if (branchItems == null)
                {
                    branchItems = new ObservableCollection<BranchItemCheckedState>();

                    branchItems.CollectionChanged += (sender, e) =>
                    {
                        if (e.OldItems != null)
                        {
                            foreach (BranchItemCheckedState checkedState in e.OldItems)
                            {
                                checkedState.PropertyChanged -= ItemPropertyChanged;
                            }
                        }

                        if (e.NewItems != null)
                        {
                            foreach (BranchItemCheckedState checkedState in e.NewItems)
                            {
                                checkedState.PropertyChanged += ItemPropertyChanged;
                            }
                        }
                    };
                }

                return branchItems;
            }
        }

        #region ItemPropertyChanged
        private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsChecked")
            {
                BranchItemCheckedState branchItemCheckedState = sender as BranchItemCheckedState;

                if (branchItemCheckedState != null)
                {
                    IEnumerable<BranchItemCheckedState> branchItemCheckedStates = BranchItemCheckedStates.Where(b => b.IsChecked == true);

                    StringBuilder builder = new StringBuilder();

                    foreach (BranchItemCheckedState item in BranchItemCheckedStates)
                    {
                        if (item.IsChecked)
                        {
                            builder.Append("[" + item.BranchItem.BranchItemName + "]" + "; ");
                        }
                    }

                    SelectedText = builder == null ? string.Empty : builder.ToString();
                }
            }
        }
        #endregion

        public BranchSelectorViewModel()
        {
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "67_SP3" } ));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "67_SP4" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "67_SP4_Innovation" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "67_SP4_H2" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "68_SP3" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "68_SP4" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "68_SP4_Innovation" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "68_SP4_H2" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "69_SP3" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "69_SP4" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "69_SP4_Innovation" }));
            BranchItemCheckedStates.Add(new BranchItemCheckedState(new BranchItem() { BranchItemName = "69_SP4_H2" }));
        }

        #region SaveTextCommand
        public ICommand SaveTextCommand => new DelegateCommand(SaveText);
        private void SaveText(object commandParameter)
        {
            string tempSelectedText = "";
            foreach(var item in BranchItemCheckedStates)
            {
                string tempBranchItemName = "[" + item.BranchItem.BranchItemName + "]";
                if (SelectedText.Contains(tempBranchItemName))
                {
                    tempSelectedText += tempBranchItemName + "; ";
                }
            }
            SelectedText = tempSelectedText;
        }
        #endregion

    }


    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
