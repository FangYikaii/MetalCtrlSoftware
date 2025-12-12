using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XCore
{
    public class ButtonEx : Button
    {
        static ButtonEx()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonEx), new FrameworkPropertyMetadata(typeof(ButtonEx)));
        }
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
         DependencyProperty.Register("Icon", typeof(ImageSource), typeof(ButtonEx), new PropertyMetadata(null));

        public double ImageSize
        {
            get { return (double)GetValue(ImageSizeProperty); }
            set { SetValue(ImageSizeProperty, value); }
        }

        public static readonly DependencyProperty ImageSizeProperty =
         DependencyProperty.Register("ImageSize", typeof(double), typeof(ButtonEx), new PropertyMetadata(null));

        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        public static readonly DependencyProperty PathDataProperty =
         DependencyProperty.Register("PathData", typeof(Geometry), typeof(ButtonEx), new PropertyMetadata(null));
        public Geometry PathData1
        {
            get { return (Geometry)GetValue(PathData1Property); }
            set { SetValue(PathData1Property, value); }
        }

        public static readonly DependencyProperty PathData1Property =
         DependencyProperty.Register("PathData1", typeof(Geometry), typeof(ButtonEx), new PropertyMetadata(null));

        public Geometry PathData2
        {
            get { return (Geometry)GetValue(PathData2Property); }
            set { SetValue(PathData2Property, value); }
        }

        public static readonly DependencyProperty PathData2Property =
         DependencyProperty.Register("PathData2", typeof(Geometry), typeof(ButtonEx), new PropertyMetadata(null));

        public Brush PicGround1
        {
            get { return (Brush)GetValue(PicGround1Property); }
            set { SetValue(PicGround1Property, value); }
        }

        public static readonly DependencyProperty PicGround1Property =
         DependencyProperty.Register("PicGround1", typeof(Brush), typeof(ButtonEx), new PropertyMetadata(null));
        public Brush PicGround2
        {
            get { return (Brush)GetValue(PicGround2Property); }
            set { SetValue(PicGround2Property, value); }
        }

        public static readonly DependencyProperty PicGround2Property =
         DependencyProperty.Register("PicGround2", typeof(Brush), typeof(ButtonEx), new PropertyMetadata(null));
        public Brush OnMouseOverForegroundColor
        {
            get { return (Brush)GetValue(OnMouseOverForegroundColorProperty); }
            set { SetValue(OnMouseOverForegroundColorProperty, value); }
        }

        public static readonly DependencyProperty OnMouseOverForegroundColorProperty =
         DependencyProperty.Register("OnMouseOverColor", typeof(Brush), typeof(ButtonEx), new PropertyMetadata(null));

    }
}
