﻿using System;
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

namespace PRAKTIKA3
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
        private void Вычислить_Click(object sender, RoutedEventArgs e)
        {
            string x = Convert.ToString(Stroka.Text); /// Ввод слова
            x.ToLower();
            string y = x.ToLower();
            string xx = "";
            for (int i = y.Length - 1; i >= 0; i--)
            {
                xx += y[i];
            }
            if (y == xx)
            {
                Otvet.Text = Convert.ToString(" Слово является палиндром"); /// Вывод
            }
            else
                Otvet.Text = Convert.ToString(" Слово не является палиндром"); /// Вывод
        }
    }
}
