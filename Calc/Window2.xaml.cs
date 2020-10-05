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
using ClassLibrary1;
namespace Calc
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Class3 stepen = new Class3(tbA.Text, tbB.Text);
                lbl.Content = stepen.getClass3();
            }
            catch
            {
                lbl.Content = "Введен неверный символ";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try

            {
                StreamWriter sw = new StreamWriter("Ymnogenie.txt");
                sw.WriteLine(tbA.Text);
                sw.WriteLine(tbB.Text);
                sw.WriteLine(lbl.Content);
                sw.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show

                ("Error: " + ex.Message);

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
