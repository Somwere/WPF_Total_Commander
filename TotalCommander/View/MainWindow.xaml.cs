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
using TotalCommander.ViewModel;

namespace TotalCommander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }
        TCViewModel tCViewModel = new TCViewModel();
        void MainWindow_Loaded(object sender, RoutedEventArgs e) => tCViewModel.Loaded(listView1);
        void listViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e) => tCViewModel.LookItems(listView2, e);
    }
}
