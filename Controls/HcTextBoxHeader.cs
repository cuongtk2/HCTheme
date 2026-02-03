
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HCTheme.Controls
{

    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:HcTextBoxWithLabel/>
    ///
    /// </summary>
    public class HcTextBoxHeader : TextBox
    {
        static HcTextBoxHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HcTextBoxHeader), new FrameworkPropertyMetadata(typeof(HcTextBoxHeader)));
        }

        #region DependencyProperty Content

        /// <summary>
        /// Registers a dependency property as backing store for the Content property
        /// </summary>
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(HcTextBoxHeader),
            new FrameworkPropertyMetadata(null,
                  FrameworkPropertyMetadataOptions.AffectsRender |
                  FrameworkPropertyMetadataOptions.AffectsParentMeasure));

        /// <summary>
        /// Gets or sets the Content.
        /// </summary>
        /// <value>The Content.</value>
        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        /// <summary>
        /// Registers a dependency property as backing store for the Header Color property
        /// </summary>
        public static readonly DependencyProperty HeaderBrushProperty =
           DependencyProperty.Register("HeaderBrush", typeof(Brush), typeof(HcTextBoxHeader),
           new FrameworkPropertyMetadata(null,
                 FrameworkPropertyMetadataOptions.AffectsRender |
                 FrameworkPropertyMetadataOptions.AffectsParentMeasure));

        public Brush HeaderBrush
        {
            get { return (Brush)GetValue(HeaderBrushProperty); }
            set { SetValue(HeaderBrushProperty, value); }
        }



        #endregion

    }
}
