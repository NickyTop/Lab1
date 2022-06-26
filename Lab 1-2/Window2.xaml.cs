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
using System.Windows.Shapes;

namespace Лаба_1__2_сем_
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        int count = 0;

        private void GoToMainWin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw;
            mw = new MainWindow();
            Hide();
            mw.Show();
        }

        string[] cell = new string[24];

        string s1 = "1";
        string s2 = "1";
        string s3 = "1";
        string s4 = "1";
        string s5 = "1";
        string s6 = "1";
        string s7 = "1";
        string s8 = "1";
        string s9 = "1";
        string s10 = "1";
        string s11 = "1";
        string s12 = "1";
        string s13 = "1";
        string s14 = "1";
        string s15 = "1";
        string s16 = "1";
        string s17 = "1";
        string s18 = "1";
        string s19 = "1";
        string s20 = "1";
        string s21 = "1";
        string s22 = "1";
        string s23 = "1";
        string s24 = "1";
        string s25 = "1";
        public void check_win()
        {
            //Горизонтально
            if(s1 == "0" && s2 == "0" && s3 == "0" && s4 == "0" && s5 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s1 == "X" && s2 == "X" && s3 == "X" && s4 == "X" && s5 == "X")
            {
                MessageBox.Show("X - победили");
            }

            if (s6 == "0" && s7 == "0" && s8 == "0" && s9 == "0" && s10 == "0")
            {
                MessageBox.Show("0 - победили");
            }
            if (s6 == "X" && s7 == "X" && s8 == "X" && s9 == "X" && s10 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s11 == "0" && s12 == "0" && s13 == "0" && s14 == "0" && s15 == "0")
            {
                MessageBox.Show("0 - победили");
            }
            if (s11 == "X" && s12 == "X" && s13 == "X" && s14 == "X" && s15 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s16 == "0" && s17 == "0" && s18 == "0" && s19 == "0" && s20 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s16 == "X" && s17 == "X" && s18 == "X" && s19 == "X" && s20 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s21 == "0" && s22 == "0" && s23 == "0" && s24 == "0" && s25 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s21 == "X" && s22 == "X" && s23 == "X" && s24 == "X" && s25 == "X")
            {
                MessageBox.Show("X - победели");
            }

            //Вертикально
            if (s1 == "0" && s6 == "0"&& s11 == "0" && s16 =="0" && s21 =="0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s1 == "X" && s6 == "X" && s11 == "X" && s16 == "X" && s21 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s2 == "0" && s7 == "0" && s12 == "0" && s17 == "0" && s22 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s2 == "X" && s7 == "X" && s12 == "X" && s17 == "X" && s22 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s3 == "0" && s8 == "0" && s13 == "0" && s18 == "0" && s23 == "0")
            {
                MessageBox.Show("0 - победили");
            }
            if (s3 == "X" && s8 == "X" && s13 == "X" && s18 == "X" && s23 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s4 == "0" && s9 == "0" && s14 == "0" && s19 == "0" && s24 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s4 == "X" && s9 == "X" && s14 == "X" && s19 == "X" && s24 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s5 == "0" && s10 == "0" && s15 == "0" && s20 == "0" && s25 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s5 == "X" && s10 == "X" && s15 == "X" && s20 == "X" && s25 == "X")
            {
                MessageBox.Show("X - победели");
            }

            //Из угла в углол
            if (s1 == "0" && s7 == "0" && s13 == "0" && s19 == "0" && s25 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s1 == "X" && s7 == "X" && s13 == "X" && s19 == "X" && s25 == "X")
            {
                MessageBox.Show("X - победели");
            }

            if (s5 == "0" && s9 == "0" && s13 == "0" && s17 == "0" && s21 == "0")
            {
                MessageBox.Show("0 - победили");
            }

            if (s5 == "X" && s9 == "X" && s13 == "X" && s17 == "X" && s21 == "X")
            {
                MessageBox.Show("X - победели");
            }

        }

        private void Btn1_1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn1_1.Content = "0";
                Btn1_1.IsEnabled = false;
                s1 = "0";
            }
            else
            {
                Btn1_1.Content = "X";
                Btn1_1.IsEnabled = false;
                s1 = "X";
            }
           check_win();
        }

        private void Btn1_2_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn1_2.Content = "0";
                Btn1_2.IsEnabled = false;
                s2 = "0";
            }
            else
            {
                Btn1_2.Content = "X";
                Btn1_2.IsEnabled = false;
                s2 = "X";
            }
            check_win();
        }

        private void Btn1_3_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn1_3.Content = "0";
                Btn1_3.IsEnabled = false;
                s3= "0";
            }
            else
            {
                Btn1_3.Content = "X";
                Btn1_3.IsEnabled = false;
                s3 = "X";
            }
            check_win();
        }

        private void Btn1_4_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn1_4.Content = "0";
                Btn1_4.IsEnabled = false;
                s4 = "0";
            }
            else
            {
                Btn1_4.Content = "X";
                Btn1_4.IsEnabled = false;
                s4 = "X";
            }
            check_win();
        }

        private void Btn1_5_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn1_5.Content = "0";
                Btn1_5.IsEnabled = false;
                s5 = "0";
            }
            else
            {
                Btn1_5.Content = "X";
                Btn1_5.IsEnabled = false;
                s5 = "X";
            }
            check_win();
        }

        private void Btn2_1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn2_1.Content = "0";
                Btn2_1.IsEnabled = false;
                s6 = "0";
            }
            else
            {
                Btn2_1.Content = "X";
                Btn2_1.IsEnabled = false;
                s6 = "X";
            }
            check_win();
        }

        private void Btn2_2_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn2_2.Content = "0";
                Btn2_2.IsEnabled = false;
                s7 = "0";
            }
            else
            {
                Btn2_2.Content = "X";
                Btn2_2.IsEnabled = false;
                s7 = "X";
            }
            check_win();
        }

        private void Btn2_3_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn2_3.Content = "0";
                Btn2_3.IsEnabled = false;
                s8 = "0";
            }
            else
            {
                Btn2_3.Content = "X";
                Btn2_3.IsEnabled = false;
                s8 = "X";
            }
            check_win();
        }

        private void Btn2_4_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn2_4.Content = "0";
                Btn2_4.IsEnabled = false;
                s9 = "0";
            }
            else
            {
                Btn2_4.Content = "X";
                Btn2_4.IsEnabled = false;
                s9 = "X";
            }
            check_win();
        }

        private void Btn2_5_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn2_5.Content = "0";
                Btn2_5.IsEnabled = false;
                s10= "0";
            }
            else
            {
                Btn2_5.Content = "X";
                Btn2_5.IsEnabled = false;
                s10 = "X";
            }
            check_win();
        }

        private void Btn3_1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn3_1.Content = "0";
                Btn3_1.IsEnabled = false;
                s11 = "0";
            }
            else
            {
                Btn3_1.Content = "X";
                Btn3_1.IsEnabled = false;
                s11 = "X";
            }
            check_win();
        }

        private void Btn3_2Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn3_2.Content = "0";
                Btn3_2.IsEnabled = false;
                s12 = "0";
            }
            else
            {
                Btn3_2.Content = "X";
                Btn3_2.IsEnabled = false;
                s12 = "X";
            }
            check_win();
        }

        private void Btn3_3_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn3_3.Content = "0";
                Btn3_3.IsEnabled = false;
                s13 = "0";
            }
            else
            {
                Btn3_3.Content = "X";
                Btn3_3.IsEnabled = false;
                s13 = "X";
            }
            check_win();
        }

        private void Btn3_4_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn3_4.Content = "0";
                Btn3_4.IsEnabled = false;
                s14 = "0";
            }
            else
            {
                Btn3_4.Content = "X";
                Btn3_4.IsEnabled = false;
                s14 = "X";
            }
            check_win();
        }

        private void Btn3_5_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn3_5.Content = "0";
                Btn3_5.IsEnabled = false;
                s15 = "0";
            }
            else
            {
                Btn3_5.Content = "X";
                Btn3_5.IsEnabled = false;
                s15 = "X";
            }
            check_win();
        }

        private void Btn4_1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn4_1.Content = "0";
                Btn4_1.IsEnabled = false;
                s16 = "0";
            }
            else
            {
                Btn4_1.Content = "X";
                Btn4_1.IsEnabled = false;
                s16 = "X";
            }
            check_win();
        }

        private void Btn4_2_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn4_2.Content = "0";
                Btn4_2.IsEnabled = false;
                s17 = "0";
            }
            else
            {
                Btn4_2.Content = "X";
                Btn4_2.IsEnabled = false;
                s17 = "X";
            }
            check_win();
        }

        private void Btn4_3_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn4_3.Content = "0";
                Btn4_3.IsEnabled = false;
                s18 = "0";
            }
            else
            {
                Btn4_3.Content = "X";
                Btn4_3.IsEnabled = false;
                s18 = "X";
            }
            check_win();
        }

        private void Btn4_4_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn4_4.Content = "0";
                Btn4_4.IsEnabled = false;
                s19 = "0";
            }
            else
            {
                Btn4_4.Content = "X";
                Btn4_4.IsEnabled = false;
                s19 = "X";
            }
            check_win();
        }

        private void Btn4_5_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn4_5.Content = "0";
                Btn4_5.IsEnabled = false;
                s20 = "0";
            }
            else
            {
                Btn4_5.Content = "X";
                Btn4_5.IsEnabled = false;
                s20 = "X";
            }
            check_win();
        }

        private void Btn5_1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn5_1.Content = "0";
                Btn5_1.IsEnabled = false;
                s21 = "0";
            }
            else
            {
                Btn5_1.Content = "X";
                Btn5_1.IsEnabled = false;
                s21 = "X";
            }
            check_win();
        }

        private void Btn5_2_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn5_2.Content = "0";
                Btn5_2.IsEnabled = false;
                s22 = "0";
            }
            else
            {
                Btn5_2.Content = "X";
                Btn5_2.IsEnabled = false;
                s22 = "X";
            }
            check_win();
        }

        private void Btn5_3_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn5_3.Content = "0";
                Btn5_3.IsEnabled = false;
                s23 = "0";
            }
            else
            {
                Btn5_3.Content = "X";
                Btn5_3.IsEnabled = false;
                s23 = "X";
            }
            check_win();
        }

        private void Btn5_4_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn5_4.Content = "0";
                Btn5_4.IsEnabled = false;
                s24 = "0";
            }
            else
            {
                Btn5_4.Content = "X";
                Btn5_4.IsEnabled = false;
                s24 = "X";
            }
            check_win();
        }

        private void Btn5_5_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                Btn5_5.Content = "0";
                Btn5_5.IsEnabled = false;
                s25 = "0";
            }
            else
            {
                Btn5_5.Content = "X";
                Btn5_5.IsEnabled = false;
                s25 = "X";
            }
            check_win();
        }
    }
}
