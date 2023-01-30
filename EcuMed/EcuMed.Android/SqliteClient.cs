using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using EcuMed.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SqlCliente))]
namespace EcuMed.Droid
{
    
    public class SqlCliente : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(ruta, "EcuMed.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}


