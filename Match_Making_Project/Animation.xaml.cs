using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Match_Making_Project
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
   
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public partial class Window1 : Window
        {
            private readonly Duration _openCloseDuration = new Duration(TimeSpan.FromSeconds(0.5));

            public Window1()
            {
                InitializeComponent();

                dropdownContent.Height = 0;
            }

            private void OpenDropdown(object sender, RoutedEventArgs e)
            {
                dropdownInnerContent.Measure(new Size(dropdownContent.MaxWidth, dropdownContent.MaxHeight));
                DoubleAnimation heightAnimation = new DoubleAnimation(0, dropdownInnerContent.DesiredSize.Height, _openCloseDuration);
                dropdownContent.BeginAnimation(HeightProperty, heightAnimation);
            }

            private void CloseDropdown(object sender, RoutedEventArgs e)
            {
                DoubleAnimation heightAnimation = new DoubleAnimation(0, _openCloseDuration);
                dropdownContent.BeginAnimation(HeightProperty, heightAnimation);
            }
        }
    }

