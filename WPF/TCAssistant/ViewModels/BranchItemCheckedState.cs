using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace TCAssistant.ViewModels
{
    class BranchItemCheckedState : ObservableObject
    {
        public BranchItem BranchItem { get; set; }

        private bool isChecked;

        public bool IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    RaisePropertyChanged("IsChecked");
                }
            }
        }
        public BranchItemCheckedState(BranchItem branchItem)
        {
            BranchItem = branchItem;
        }
    }
}
