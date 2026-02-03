using System.Windows;
using System.Windows.Controls;

namespace HCTheme.Controls
{

    /// </summary>
    public class HcSwitch : CheckBox
    {
        static HcSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HcSwitch), new FrameworkPropertyMetadata(typeof(HcSwitch)));
        }

        /// <summary>
        /// OnText Properties
        /// </summary>
        public static readonly DependencyProperty OnTextProperty = DependencyProperty.Register(
            nameof(OnText),
            typeof(string),
            typeof(HcSwitch),
            new FrameworkPropertyMetadata());
        public string OnText
        {
            get => (string)GetValue(OnTextProperty);
            set => SetValue(OnTextProperty, value);
        }

        /// <summary>
        /// OffText Properties
        /// </summary>
        public static readonly DependencyProperty OffTextProperty = DependencyProperty.Register(
            nameof(OffText),
            typeof(string),
            typeof(HcSwitch),
            new FrameworkPropertyMetadata());
        public string OffText
        {
            get => (string)GetValue(OffTextProperty);
            set => SetValue(OffTextProperty, value);
        }
    }
}
