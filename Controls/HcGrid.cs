using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HCTheme.Controls
{
    public class HcGrid : Grid
    {
        #region Properties
        public bool ShowCustomGridLines
        {
            get { return (bool)GetValue(ShowCustomGridLinesProperty); }
            set { SetValue(ShowCustomGridLinesProperty, value); }
        }

        public static readonly DependencyProperty ShowCustomGridLinesProperty =
            DependencyProperty.Register(
                "ShowCustomGridLines",
                typeof(bool),
                typeof(HcGrid),
                new UIPropertyMetadata()
                );


        public Brush GridLineBrush
        {
            get { return (Brush)GetValue(GridLineBrushProperty); }
            set { SetValue(GridLineBrushProperty, value); }
        }

        public static readonly DependencyProperty GridLineBrushProperty =
            DependencyProperty.Register(
                "GridLineBrush",
                typeof(Brush),
                typeof(HcGrid),
                new UIPropertyMetadata()
                );

        public double GridLineThickness
        {
            get { return (double)GetValue(GridLineThicknessProperty); }
            set { SetValue(GridLineThicknessProperty, value); }
        }

        public static readonly DependencyProperty GridLineThicknessProperty =
            DependencyProperty.Register(
                "GridLineThickness",
                typeof(double),
                typeof(HcGrid),
                new UIPropertyMetadata()
                );
        #endregion

        protected override void OnRender(DrawingContext dc)
        {
            if (ShowCustomGridLines)
            {
                foreach (var rowDefinition in RowDefinitions)
                {
                    dc.DrawLine(new Pen(GridLineBrush, GridLineThickness), new Point(0, rowDefinition.Offset), new Point(ActualWidth, rowDefinition.Offset));
                }

                foreach (var columnDefinition in ColumnDefinitions)
                {
                    dc.DrawLine(new Pen(GridLineBrush, GridLineThickness), new Point(columnDefinition.Offset, 0), new Point(columnDefinition.Offset, ActualHeight));
                }
                dc.DrawRectangle(Brushes.Transparent, new Pen(GridLineBrush, GridLineThickness), new Rect(0, 0, ActualWidth, ActualHeight));
            }
            base.OnRender(dc);
        }
        static HcGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HcGrid), new FrameworkPropertyMetadata(typeof(HcGrid)));
        }
    }
}
