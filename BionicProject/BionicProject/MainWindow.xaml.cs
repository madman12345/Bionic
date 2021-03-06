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

///////////////////////////////////

using System.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MySql.Data.MySqlClient;


///////////////////////////////////

namespace BionicProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public User user;
        StoreDB store = new StoreDB();
        SignIn SignInDialog;
        public MainWindow()
        {
            InitializeComponent();

            //user = store.GetUserOnLogin("sedova26@mail.ru", "123");
            //if (user == null) { MessageBox.Show("Where am I?"); Environment.Exit(0); }

            SignInDialog = new SignIn();
            SignInDialog.ShowDialog();
            user = SignIn.user;

            CoursesTree.ItemsSource = user.MyCourses;
            //AdminPanel adm = new AdminPanel(new Course(2121, "SomeCourse", 23));
            //Grid.SetColumn(adm, 1);
            //Grid.SetRow(adm, 1);
            //Programulina.Children.Add(adm);

            //TeacherQuestionAddingControl taqc = new TeacherQuestionAddingControl(new Course(2121, "SomeCourse", 23));
            //Grid.SetColumn(taqc, 1);
            //Grid.SetRow(taqc, 1);
            //Programulina.Children.Add(taqc);

            MessageControl control = new MessageControl();
            Grid.SetColumn(control, 1);
            Grid.SetRow(control, 1);
            Programulina.Children.Add(control);
        } 
    }
}
