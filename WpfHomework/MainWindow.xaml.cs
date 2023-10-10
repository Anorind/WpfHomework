using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dictionary<string, FontWeight> Weights { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Weights = new Dictionary<string, FontWeight>
        {
            {"Black", FontWeights.Black},
            {"Bold", FontWeights.Bold},
            {"ExtraBlack", FontWeights.ExtraBlack},
            {"ExtraBold", FontWeights.ExtraBold},
            {"ExtraLight", FontWeights.ExtraLight},
            {"Light", FontWeights.Light},
            {"Heavy", FontWeights.Heavy},
            {"Medium", FontWeights.Medium},
            {"Normal", FontWeights.Normal},
            {"Regular", FontWeights.Regular},
            {"SemiBold", FontWeights.SemiBold},
            {"Thin", FontWeights.Thin},
            {"UltraBlack", FontWeights.UltraBlack},
            {"UltraBold", FontWeights.UltraBold},
            {"UltraLight", FontWeights.UltraLight},
        };

            fontWeights.ItemsSource = Weights.Keys.ToList();
            fontWeights.SelectedIndex = 0;
        }
        private void OnFontWeightChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fontWeights.SelectedItem != null)
            {
                string selectedWeight = fontWeights.SelectedItem.ToString();
                textBox.FontWeight = Weights[selectedWeight];
            }
        }
        private void fontSizeSlider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            double value = slider.Value;
            slider.Value = Math.Round(value);
        }
    }
}
