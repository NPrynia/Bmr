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

namespace Bmr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Load.SelectedIndex = 0;
        }
            private void Button_Click(object sender, RoutedEventArgs e)
            {
                int val,gender=0;

            double bmr, weight, growth,ves,age;
          

            #region stop
            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Укажите ваш вес");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGrowth.Text))
            {
                MessageBox.Show("Укажите ваш рост");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Укажите ваш возраст");
                return;
            }
            if (Load.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите нагрузку");
            }
            if (radioButton1.IsChecked ==false & radioButton2.IsChecked == false)
            {
                MessageBox.Show("Выберите пол ");
                return;
            }
                if (!Int32.TryParse(txtWeight.Text, out val))
                {
                    MessageBox.Show("Неверный формат данных ");
                    return;
                }
                if (!Int32.TryParse(txtGrowth.Text, out val))
                {
                    MessageBox.Show("Неверный формат данных ");
                    return;
                }
            if (!Int32.TryParse(txtAge.Text, out val))
            {
                MessageBox.Show("Неверный формат данных ");
                return;
            }
            #endregion
            age = Convert.ToDouble(txtAge.Text);
            growth = Convert.ToDouble(txtGrowth.Text);
            weight = Convert.ToDouble(txtWeight.Text);

            if (radioButton1.IsChecked == true)
            {
                gender = 0;
            }
            if (radioButton2.IsChecked == true)
            { 
                gender = 1;
            }
            bmr = Person.BMR(weight, growth, age, gender);
            int caseSwitch = Load.SelectedIndex;
            switch (caseSwitch)
            {
                case 0:
                    bmr = bmr * 1.2;
                    break;
                case 1:
                    bmr = bmr * 1.375;
                    break;
                case 2:
                    bmr = bmr * 1.4625;
                    break;
                case 3:
                    bmr = bmr * 1.550;
                    break;
                case 4:
                    bmr = bmr * 1.6375;
                    break;
                case 5:
                    bmr = bmr * 1.725;
                    break;
                case 6  :
                    bmr = bmr * 1.9;                 
                    break;
            }
            ves = bmr * 0.8;
            Res1.Content = bmr + " ккалорий в день";
            Res2.Content = ves + " ккалорий в день";
        }
        }
    }

