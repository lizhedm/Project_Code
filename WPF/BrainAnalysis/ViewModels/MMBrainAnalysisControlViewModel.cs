using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace BrainAnalysis
{
    public class MMBrainAnalysisControlViewModel : AppViewModelBase
    {
        public Image FirstImage { get; set; }
        public MMBrainAnalysisControlViewModel(){
            FirstImage = new Image();
            string firstImagePath = "D:/Git/Project_Code/WPF/BrainAnalysis/Image/example_1.png";
            FirstImage.Source = new BitmapImage(new Uri(firstImagePath));
        }

        #region UseSelectToolCommand
        public ICommand UseSelectToolCommand => new DelegateCommand(UseSelectTool);
        private void UseSelectTool(object commandParameter)
        {
            MessageBox.Show("UseSelectTool");
        }
        #endregion

        #region UseZoomInOutToolCommand
        public ICommand UseZoomInOutToolCommand => new DelegateCommand(UseZoomInOutTool);
        private void UseZoomInOutTool(object commandParameter)
        {
            MessageBox.Show("UseZoomInOutTool");
        }
        #endregion

        #region UsePanToolCommand
        public ICommand UsePanToolCommand => new DelegateCommand(UsePanTool);
        private void UsePanTool(object commandParameter)
        {
            MessageBox.Show("UsePanTool");
        }
        #endregion

        #region UseWhirlToolCommand
        public ICommand UseWhirlToolCommand => new DelegateCommand(UseWhirlTool);
        private void UseWhirlTool(object commandParameter)
        {
            MessageBox.Show("UseWhirlTool");
        }
        #endregion

        #region SetFitWindowCommand
        public ICommand SetFitWindowCommand => new DelegateCommand(SetFitWindow);
        private void SetFitWindow(object commandParameter)
        {
            MessageBox.Show("SetFitWindow");
        }
        #endregion

        #region ResetDefaultWindowCommand
        public ICommand ResetDefaultWindowCommand => new DelegateCommand(ResetDefaultWindow);
        private void ResetDefaultWindow(object commandParameter)
        {
            MessageBox.Show("ResetDefaultWindow");
        }
        #endregion

        #region DrawPixelCommand
        public ICommand DrawPixelCommand => new DelegateCommand(DrawPixel);
        private void DrawPixel(object commandParameter)
        {
            MessageBox.Show("DrawPixel");
        }
        #endregion

        #region DrawCircleCommand
        public ICommand DrawCircleCommand => new DelegateCommand(DrawCircle);
        private void DrawCircle(object commandParameter)
        {
            MessageBox.Show("DrawCircle");
        }
        #endregion

        #region MeasureAngleCommand
        public ICommand MeasureAngleCommand => new DelegateCommand(MeasureAngle);
        private void MeasureAngle(object commandParameter)
        {
            MessageBox.Show("MeasureAngle");
        }
        #endregion

        #region MeasureLineDistanceCommand
        public ICommand MeasureLineDistanceCommand => new DelegateCommand(MeasureLineDistance);
        private void MeasureLineDistance(object commandParameter)
        {
            MessageBox.Show("MeasureLineDistance");
        }
        #endregion

        #region AddArrowCommand
        public ICommand AddArrowCommand => new DelegateCommand(AddArrow);
        private void AddArrow(object commandParameter)
        {
            MessageBox.Show("AddArrow");
        }
        #endregion

        #region DeleteAllRoiCommand
        public ICommand DeleteAllRoiCommand => new DelegateCommand(DeleteAllRoi);
        private void DeleteAllRoi(object commandParameter)
        {
            MessageBox.Show("DeleteAllRoi");
        }
        #endregion
    }
}