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
using System.Windows.Shapes;

namespace ExpertiseWPFApplication
{
    /// <summary>
    /// Логика взаимодействия для GRNTI.xaml
    /// </summary>
    public partial class GRNTI : Window
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public GRNTI()
        {
            InitializeComponent();
            client.GetListGRNTICompleted += Client_GetListGRNTICompleted;
            client.GetListGRNTIAsync();
        }
        private void Client_GetListGRNTICompleted(object sender, ServiceReference1.GetListGRNTICompletedEventArgs e)
        {
            if (e.Error == null)
            {
                dataGrid1.ItemsSource = e.Result.ToList();

            }


            else
                MessageBox.Show(e.Error.Message);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            client.GetListGRNTIAsync();
        }
    }
}
