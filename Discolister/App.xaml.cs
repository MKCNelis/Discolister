using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Discolister
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //name
        static string sDatabaseName = "./Discolist.db";
        //location
        static string sFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //input to database
        public static string sDataBasePath = System.IO.Path.Combine(sFolderPath, sDatabaseName);
       
    }
}
