using System;
using System.Collections.Generic;
using System.IO;
using TraCuuDieuLuat.Models;
using TraCuuDieuLuat.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TraCuuDieuLuat
{
    public partial class App : Application
    {

        private static SqliteConect db;
        public static SqliteConect mydatabase
        {
            get
            {
                if (db == null)
                {
                    db= new SqliteConect(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"luatlamnghiep.db3"));
                    
                }              
                return db;
            }
        }


        public App()
        {
            
            InitializeComponent();          
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
