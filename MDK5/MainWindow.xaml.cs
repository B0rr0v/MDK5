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

namespace MDK5
{
    //Создать класс Triangle(треугольник) с полями-сторонами.Создать необходимые методы и свойства.
    //Определить метод вычисления периметра.Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения размеров треугольника в 2 раза.

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Расчёт(object sender, RoutedEventArgs e)
        {
            bool f1 = Int32.TryParse(сторонаА.Text, out int a);// проверка на числовой тип данных
            bool f2 = Int32.TryParse(сторонаВ.Text, out int b);
            bool f3 = Int32.TryParse(сторонаС.Text, out int c);
            if (f1 && f2 && f3 && a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    Triangle triangle = new Triangle();
                    triangle.SetParams(a, b, c); // Установка параметров треугольника
                    double perimeter = triangle.CalcPerimeter(); // Вычисление периметра
                    периметр.Text = Convert.ToString(perimeter);
                }
                else MessageBox.Show("Ошибка,введите правильные стороны треугольника");
            }
            else MessageBox.Show("Ошибка,стороны треугольника должны быть положительными");
        }

        private void Увеличение(object sender, RoutedEventArgs e)
        {
            bool f1 = Int32.TryParse(сторонаА.Text, out int a);
            bool f2 = Int32.TryParse(сторонаВ.Text, out int b);
            bool f3 = Int32.TryParse(сторонаС.Text, out int c);
            if (f1 && f2 && f3 && a > 0 && b > 0 && c > 0)
            {
                Triangle triangle = new Triangle();
                triangle.SetParams(a, b, c, true); // Увеличение размеров треугольника
                
                  удвА.Text = triangle.A.ToString();
                  удвВ.Text = triangle.B.ToString();
                  удвС.Text = triangle.C.ToString();
                
            }
            else MessageBox.Show("Ошибка, должны быть заполнены текстбоксы со сторонами");

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Даниил ИСП-31 Практическая работа №5:Создать класс Triangle(треугольник) с полями-сторонами.Создать необходимые методы и свойства.Определить метод вычисления периметра.Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения размеров треугольника в 2 раза.");
        }

        private void Очистка1(object sender, RoutedEventArgs e)
        {
            удвА.Clear();
            удвВ.Clear();
            удвС.Clear();
            сторонаА.Clear();
            сторонаВ.Clear();
            сторонаС.Clear();
            периметр.Clear();
        }
    }
}
