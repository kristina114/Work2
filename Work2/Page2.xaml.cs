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

namespace Work2
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberTextBox.Text, out int number))
            {
                MessageBox.Show("Введите только число!");
                return;
            }

            if (number > 0 && number < 366)
            {
                int day = number % 7;
                if (day == 0)
                {
                    day = 7;
                }

                AnswerTextBox.Text = $"Номер дня недели: {day}";
            }
            else
            {
                AnswerTextBox.Text = "В году всего 365 дней, если он не високосный";
            }
        }
    }
}
