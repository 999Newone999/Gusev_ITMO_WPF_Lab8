using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Gusev_ITMO_WPF_Lab8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
                textBox.FontSize = Convert.ToDouble(fontSize);
        }

        private void Button_B_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight == System.Windows.FontWeights.Bold)
                {
                    textBox.FontWeight = System.Windows.FontWeights.Normal;
                }
                else
                {
                    textBox.FontWeight = System.Windows.FontWeights.Bold;
                }
            }
        }

        private void Button_I_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontStyle == System.Windows.FontStyles.Normal)
                {
                    textBox.FontStyle = System.Windows.FontStyles.Italic;
                }
                else
                {
                    textBox.FontStyle = System.Windows.FontStyles.Normal;
                }
            }
        }

        private void Button_U_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.TextDecorations == null)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
                else
                {
                    textBox.TextDecorations = null;
                }
            }
        }

        private void RadioButton_black_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.Foreground != Brushes.Black)
                {
                    textBox.Foreground = Brushes.Black;
                }

            }
        }

        private void RadioButton_red_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.Foreground != Brushes.Red)
                {
                    textBox.Foreground = Brushes.Red;
                }

            }
        }

        /*   private void MenuItem_Click_Open(object sender, RoutedEventArgs e)
           {
               OpenFileDialog openFileDialogEx = new OpenFileDialog();
               openFileDialogEx.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы (*.*)|*.*";
               if (openFileDialogEx.ShowDialog() == true) 
               {
                   textBox.Text = File.ReadAllText(openFileDialogEx.FileName);
               }
           }*/

        /*  private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
          {
              SaveFileDialog saveFileDialogEx = new SaveFileDialog();
              saveFileDialogEx.Filter = "Текстовые файлы(*.txt)|*.txt";
              if (saveFileDialogEx.ShowDialog() == true)
              {
                  File.WriteAllText(saveFileDialogEx.FileName, textBox.Text);
              }
          } */

        /*  private void MenuItem_Click(object sender, RoutedEventArgs e)
          {
              Application.Current.Shutdown();
          }*/

        private void ExitProc(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void OpenProc(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialogEx = new OpenFileDialog();
            openFileDialogEx.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialogEx.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialogEx.FileName);
            }
        }

        private void SaveProc(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialogEx = new SaveFileDialog();
            saveFileDialogEx.Filter = "Текстовые файлы(*.txt)|*.txt";
            if (saveFileDialogEx.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialogEx.FileName, textBox.Text);
            }
        }
    }
}