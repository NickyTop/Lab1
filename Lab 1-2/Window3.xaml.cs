using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace Лаба_1__2_сем_
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private int StartWidth, StartHeight;
        private int StartFontSize;
        public Window3()
        {
            InitializeComponent();

            StartWidth = (int)this.Width;
            StartHeight = (int)this.Height;
            StartFontSize = 24;
            myLabel.Content = StartWidth.ToString() + "; " + StartHeight.ToString();


            foreach(UIElement el in OurGrid.Children)
            {
                if(el is Button)
                    ((Button)el).Click += Button_Click;
            }

            void Button_Click(object sender, RoutedEventArgs e)
            {
                string text = (string)((Button)e.OriginalSource).Content;

                if (text == "C")
                    TextField.Text = "";
                    
                else if (text == "=")
                {
                    string val = new DataTable().Compute(TextField.Text, null).ToString();
                    TextField.Text = val;
                }

                else
                    TextField.Text += text;


            }

        }

        private void MyWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double val = Math.Max(1.0 * StartWidth / this.Width, 1.0 * StartHeight / this.Height);
            myLabel.FontSize = (int)(1.0 * StartFontSize / val);
            myLabel.Content = this.Width.ToString() + "; " + this.Height.ToString();
        }

        private void GoToMainWin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw;
            mw = new MainWindow();
            Hide();
            mw.Show();
        }
    }
}
