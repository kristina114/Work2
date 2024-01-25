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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberTextBox.Text, out int number) || number < 100 || number > 999)
            {
                MessageBox.Show("Введите трёхзначное число!");
                return;
            }

            int firstNumber = number / 100;
            int secondNumber = number % 100 / 10;
            int thirdNumber = number % 10;

            int sum = firstNumber + secondNumber + thirdNumber;
            int product = firstNumber * secondNumber * thirdNumber;

            AnswerTextBox.Text = $"Сумма: {sum}, Произведение: {product}";
        }
    }
}
