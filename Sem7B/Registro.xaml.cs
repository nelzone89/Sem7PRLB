using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem7B.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sem7B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;
        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<Database>().GetConnection();
        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            var DatosRegistro = new Estudiante { Nombre = Nombre.Text, Usuario = Usuario.Text, Contrasena = Contrasena.Text};
            con.InsertAsync(DatosRegistro);
           
        }
    }
}