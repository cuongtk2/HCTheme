
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace HCTheme.Controls
{

    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:HCTheme.Controls/>
    ///
    /// </summary>
    public class HcWindow : Window
    {
        public static readonly RoutedCommand CloseCommand = new RoutedCommand();
        public HcWindow()
        {
            SetResourceReference(StyleProperty, typeof(HcWindow));
            CommandBindings.Add(new CommandBinding(CloseCommand, Close));
            this.PreviewKeyDown += HandleEsc;
        }

        static HcWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HcWindow), new FrameworkPropertyMetadata(typeof(HcWindow)));
        }


        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }
        private void Close(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        public static readonly DependencyProperty TitleBarHeightProperty = DependencyProperty.Register(
            nameof(TitleBarHeight),
            typeof(double),
            typeof(HcWindow),
            new FrameworkPropertyMetadata());
        public double TitleBarHeight
        {
            get => (double)GetValue(TitleBarHeightProperty);
            set => SetValue(TitleBarHeightProperty, value);
        }

        public static readonly DependencyProperty TitleBarBackgroundProperty = DependencyProperty.Register(
            nameof(TitleBarBackground),
            typeof(Brush),
            typeof(HcWindow),
            new FrameworkPropertyMetadata());

        public Brush TitleBarBackground
        {
            get => (Brush)GetValue(TitleBarBackgroundProperty);
            set => SetValue(TitleBarBackgroundProperty, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaiseProperty([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
