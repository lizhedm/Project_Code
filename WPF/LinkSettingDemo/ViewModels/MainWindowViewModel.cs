using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;

namespace LinkSettingDemo
{
    
    public class MainWindowViewModel : AppViewModelBase
    {
        public List<CheckBoxViewModel> CheckBoxList { get; set; }
        public List<CheckBoxViewModel> CopyCheckBoxList { get; set; }

        private bool isAllChecked;
        public bool IsAllChecked
        {
            get { return isAllChecked; }
            set 
            { 
                isAllChecked = value;
                foreach (var item in CheckBoxList)
                {
                    if (isAllChecked)
                    {
                        item.IsChecked = true;
                    }
                    else
                    {
                        item.IsChecked = false;
                    }
                    
                }
                RaisePropertyChanged("IsAllChecked");
            }
        }

        public MainWindowViewModel()
        {
            //paser xml
            string xmlPath = "D:/Git/Project_Code/WPF/LinkSettingDemo/LinkSettingList/LinkSettingList.xml";
            CheckBoxList = GetCheckBoxListFromXML(xmlPath);
            CopyCheckBoxList = GetCheckBoxListFromXML(xmlPath);
        }
        #region GetCheckBoxListFromXML
        public List<CheckBoxViewModel> GetCheckBoxListFromXML(string xmlPath)
        {   
            try
            {
                var allCheckBoxList = new List<CheckBoxViewModel>();
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlPath);
                //xmlDoc.DocumentElement->parse to Root
                var checkBoxItems = xmlDoc.DocumentElement.ChildNodes;
                for (int j = 0; j < checkBoxItems.Count; ++j)
                {
                    var name = checkBoxItems[j].Attributes["Name"].Value;
                    var isChecked = checkBoxItems[j].Attributes["IsChecked"].Value;
                    var checkBoxItem = new CheckBoxViewModel
                    {
                        //MainWindowViewModel = this,
                        Name = name,
                        IsChecked = Convert.ToBoolean(isChecked),
                    };
                    allCheckBoxList.Add(checkBoxItem);
                }
                return allCheckBoxList;
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("error:" + ex.ToString());
                return null;
            }
        }
        #endregion

        #region GetCheckBoxListSelectedCount
        public int GetCheckBoxListSelectedCount()
        {
            int count = 0;
            foreach(var item in CheckBoxList)
            {
                if(item.IsChecked == true)
                {
                    count += 1;
                }
            }
            return count;
        }
        #endregion

        #region SelectAll
        public ICommand SelectAllCommand => new DelegateCommand(SelectAll);
        
        private void SelectAll(object commandParameter)
        {
            foreach (var item in CheckBoxList)
            {
                item.IsChecked = true;
            }
            IsAllChecked = true;
        }
        #endregion

        #region SelectNone
        public ICommand SelectNoneCommand => new DelegateCommand(SelectNone);
        private void SelectNone(object commandParameter)
        {
            foreach (var item in CheckBoxList)
            {
                item.IsChecked = false;
            }
            IsAllChecked = false;
        }


        #endregion

        #region SelectReverse
        public ICommand SelectReverseCommand => new DelegateCommand(SelectReverse);
        private void SelectReverse(object commandParameter)
        {
            foreach (var item in CheckBoxList)
            {
                if (item.IsChecked == true)
                {
                    item.IsChecked = false;
                }
                else if (item.IsChecked == false)
                {
                    item.IsChecked = true;
                }
            }
        }
        #endregion

        #region SaveConfig
        public ICommand SaveConfigCommand => new DelegateCommand(SaveConfig);
        private void SaveConfig(object commandParameter)
        {
            var xmlDoc = new XmlDocument();
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
            xmlDoc.AppendChild(node);

            XmlElement root = xmlDoc.CreateElement("Root");
            xmlDoc.AppendChild(root);

            foreach(var item in CheckBoxList)
            {
                XmlElement itemElement = xmlDoc.CreateElement("Item");
                itemElement.SetAttribute("Name", item.Name);
                itemElement.SetAttribute("IsChecked", item.IsChecked.ToString());
                root.AppendChild(itemElement);
            }
            xmlDoc.Save(@"D:\Git\Project_Code\WPF\LinkSettingDemo\LinkSettingList\LinkSettingList.xml");
            MessageBox.Show("当前状态成功写入，可打开LinkSettingList.xml查看");
        }
        #endregion

        #region Refresh
        public ICommand RefreshCommand => new DelegateCommand(Refresh);
        private void Refresh(object commandParameter)
        {
            
        }
        #endregion

        #region Cancel
        public ICommand CancelCommand => new DelegateCommand(Cancel);
        private void Cancel(object commandParameter)
        {
            //save CopyCheckBoxList to file
            var xmlDoc = new XmlDocument();
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "no");
            xmlDoc.AppendChild(node);

            XmlElement root = xmlDoc.CreateElement("Root");
            xmlDoc.AppendChild(root);

            foreach (var item in CopyCheckBoxList)
            {
                XmlElement itemElement = xmlDoc.CreateElement("Item");
                itemElement.SetAttribute("Name", item.Name);
                itemElement.SetAttribute("IsChecked", item.IsChecked.ToString());
                root.AppendChild(itemElement);
            }
            xmlDoc.Save(@"D:\Git\Project_Code\WPF\LinkSettingDemo\LinkSettingList\LinkSettingList.xml");
            MessageBox.Show("取消写入，恢复初始配置数据，可打开LinkSettingList.xml查看");
        }
        #endregion

        #region GetParentObject - not used func
        public T GetParentObject<T>(DependencyObject obj, string name) where T : FrameworkElement
        {
            DependencyObject parent = VisualTreeHelper.GetParent(obj);

            while (parent != null)
            {
                if (parent is T && (((T)parent).Name == name | string.IsNullOrEmpty(name)))
                {
                    return (T)parent;
                }

                parent = VisualTreeHelper.GetParent(parent);
            }

            return null;
        }
        #endregion

        #region FindVisualChild - not used func
        List<T> FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            try
            {
                List<T> list = new List<T>();
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                    if (child is T)
                    {
                        list.Add((T)child);
                        List<T> childOfChildren = FindVisualChild<T>(child);
                        if (childOfChildren != null)
                        {
                            list.AddRange(childOfChildren);
                        }
                    }
                    else
                    {
                        List<T> childOfChildren = FindVisualChild<T>(child);
                        if (childOfChildren != null)
                        {
                            list.AddRange(childOfChildren);
                        }
                    }
                }

                return list;
            }
            catch (Exception)
            {
                //MessageBox.Show(ee.Message);
                return null;
            }
        }
        #endregion
    }
}