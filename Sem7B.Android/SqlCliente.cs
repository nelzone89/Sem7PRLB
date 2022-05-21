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
using Sem7B.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SqlCliente))]
namespace Sem7B.Droid
{
    public class SqlCliente : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documetPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documetPath, "uisrael.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}