using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace MetalizationSystem
{
    public class GridLineAttach
    {
        public static bool GetUse(DependencyObject obj)
        {
            return (bool)obj.GetValue(UseProperty);
        }

        public static void SetUse(DependencyObject obj, bool value)
        {
            obj.SetValue(UseProperty, value);
        }

        public static readonly DependencyProperty UseProperty =
            DependencyProperty.RegisterAttached("Use", typeof(bool), typeof(GridLineAttach), new PropertyMetadata(default(bool), OnUseChanged));

        static public void OnUseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Grid grid = d as Grid;
            if (grid == null)
                return;
            bool n = (bool)e.NewValue;
            grid.Loaded -= Grid_Loaded;
            if (n)
                grid.Loaded += Grid_Loaded;
        }

        private static void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Grid grid = sender as Grid;
            var controls = grid.Children;
            var count = controls.Count;
            for (int i = 0; i < count; i++)
            {
                var item = controls[i] as FrameworkElement;
                var border = new Border()
                {
                    BorderBrush = SystemColors.ActiveBorderBrush,
                    BorderThickness = new Thickness(1)
                };

                var row = Grid.GetRow(item);
                var column = Grid.GetColumn(item);
                var rowspan = Grid.GetRowSpan(item);
                var columnspan = Grid.GetColumnSpan(item);
                Grid.SetRow(border, row);
                Grid.SetColumn(border, column);
                Grid.SetRowSpan(border, rowspan);
                Grid.SetColumnSpan(border, columnspan);
                grid.Children.Add(border);
            }
        }
    }
}
