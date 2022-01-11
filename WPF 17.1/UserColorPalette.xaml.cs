using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_17._1
{
    /// <summary>
    /// Логика взаимодействия для UserColorPalette.xaml
    /// </summary>
    public partial class UserColorPalette : UserControl
    {
        public static readonly DependencyProperty ColorProherty =
            DependencyProperty.Register(
                nameof(Color),
                typeof(Color),
                typeof(UserColorPalette),
                new FrameworkPropertyMetadata(
                    Colors.Black,
                    0,
                    new PropertyChangedCallback(OnColorChanget)));

        private static void OnColorChanget(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Color ncolor = (Color)e.NewValue;
            UserColorPalette colorPalette = (UserColorPalette)d;
            colorPalette.Red = ncolor.R;
            colorPalette.Green = ncolor.G;
            colorPalette.Blue = ncolor.B;
        }

        public static readonly DependencyProperty RedProherty =
            DependencyProperty.Register(
                nameof(Red),
                typeof(byte),
                typeof(UserColorPalette),
                new FrameworkPropertyMetadata(
                    new PropertyChangedCallback(OnRGBChanget)));

        private static void OnRGBChanget(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserColorPalette colorPalette = (UserColorPalette)d;
            Color color = colorPalette.Color;
            if (e.Property == RedProherty)
                color.R = (byte)e.NewValue;
            else if (e.Property == GreenProherty)
                color.G = (byte)e.NewValue;
            else if (e.Property == BlueProherty)
                color.B = (byte)e.NewValue;
            colorPalette.Color = color;
        }

        public static readonly DependencyProperty GreenProherty =
            DependencyProperty.Register(
               nameof(Green),
               typeof(byte),
               typeof(UserColorPalette),
               new FrameworkPropertyMetadata(new PropertyChangedCallback(OnRGBChanget)));
        public static readonly DependencyProperty BlueProherty =
            DependencyProperty.Register(
                nameof(Blue),
                typeof(byte),
                typeof(UserColorPalette),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnRGBChanget)));
        public Color Color
        {
            get => (Color)GetValue(ColorProherty);
            set => SetValue(ColorProherty, value);
        }
        public byte Red
        {
            get => (byte)GetValue(RedProherty);
            set => SetValue(RedProherty, value);
        }
        public byte Green
        {
            get => (byte)GetValue(GreenProherty);
            set => SetValue(GreenProherty, value);
        }
        public byte Blue
        {
            get => (byte)GetValue(BlueProherty);
            set => SetValue(BlueProherty, value);
        }

        public UserColorPalette()
        {
            InitializeComponent();
        }
        

    }

}
