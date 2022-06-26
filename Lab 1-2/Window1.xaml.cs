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
using System.Windows.Shapes;

namespace Лаба_1__2_сем_
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        struct student
        {
            private string id;
            private string pibg;
            public student(string ID, string secname, string name, string pob, string grupa)
            {
                id = ID;
                pibg = secname + " " + name + " " + pob + " " + grupa;
            }
            public string GetId() => id;
            public string GetPIBG() => pibg;
        }
        private void AddStud_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("File.txt");
                List<student> st = new List<student>();
                while (!sr.EndOfStream)
                {
                    string[] stud = new string[5];
                    stud = sr.ReadLine().Split(' ');
                    student stu = new student(stud[0], stud[1], stud[2], stud[3], stud[4]);
                    st.Add(stu);
                }
                sr.Close();
                foreach (student s in st)
                {
                    if (s.GetId() == ID.Text)
                    {
                        MessageBox.Show("Веведений номер залікової книжки вже є в списку");
                        return;
                    }
                }
                StreamWriter sw = new StreamWriter("File.txt", true);
                if (ID.Text != "" && Prizvishe.Text != "" && Imia.Text != "" && Pobatkov.Text != "" && Grupa.Text != "")
                {
                    sw.WriteLine(ID.Text + " " + Prizvishe.Text + " " + Imia.Text + " " + Pobatkov.Text + " " + Grupa.Text);
                    MessageBox.Show("Студент доданий");
                }
                else
                {
                    MessageBox.Show("Не всі поля заповнені");
                    return;
                }
                sw.Close();
            }
            catch
            {
                StreamWriter sw = new StreamWriter("File.txt", true);
                if (ID.Text != "" && Prizvishe.Text != "" && Imia.Text != "" && Pobatkov.Text != "" && Grupa.Text != "")
                {
                    sw.WriteLine(ID.Text + " " + Prizvishe.Text + " " + Imia.Text + " " + Pobatkov.Text + " " + Grupa.Text);
                    MessageBox.Show("Студент успішно доданий");
                }
                else
                {
                    MessageBox.Show("Повинні бути заповнені усі поля");
                    return;
                }
                sw.Close();
            }
        }

        private void DelStud_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("File.txt");
            List<student> st = new List<student>();
            while (!sr.EndOfStream)
            {
                string[] stud = new string[5];
                stud = sr.ReadLine().Split(' ');
                student stu = new student(stud[0], stud[1], stud[2], stud[3], stud[4]);
                st.Add(stu);
            }
            sr.Close();
            bool check = false;
            foreach (student s in st)
            {
                if (s.GetId() == ID.Text)
                {
                    st.Remove(s);
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                MessageBox.Show("Студент не знайдений");
                return;
            }
            StreamWriter sw = new StreamWriter("File.txt");
            foreach (student s in st)
            {
                sw.WriteLine(s.GetId() + " " + s.GetPIBG());
            }
            MessageBox.Show("Студент успішно видалений");
            sw.Close();
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
