using System.Windows.Controls;

namespace HCTheme
{
    public static class ControlExt
    {
        public static void CanvasLoadUserControl(this Canvas cv, UserControl uc)
        {
            if (cv != null)
            {
                cv.Children.Clear();
                cv.Children.Add(uc);
            }
        }

        public static void StackPanelLoadUserControl(this StackPanel cv, UserControl uc)
        {
            if (cv != null)
            {
                cv.Children.Clear();
                cv.Children.Add(uc);
            }
        }
    }










}
