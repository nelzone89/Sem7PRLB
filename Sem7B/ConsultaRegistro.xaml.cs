using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class ConsultaRegistro : ContentPage
    {
        private SQLiteAsyncConnection con;
        private ObservableCollection<Estudiante> TablaEstudiante;
        public ConsultaRegistro()
        {
            InitializeComponent();
            con = DependencyService.Get<Database>().GetConnection();
            NavigationPage.SetHasBackButton(this, false);
        }

        protected async override void OnAppearing()
        {
            var ResultRegistros = await con.Table<Estudiante>().ToListAsync();
            TablaEstudiante = new ObservableCollection<Estudiante>(ResultRegistros);
            ListaUsuarios.ItemsSource = TablaEstudiante;
            base.OnAppearing();
        }

        private void ListaUsuarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Obj = (Estudiante)e.SelectedItem;
            var item = Obj.Id.ToString();
            int TD = Convert.ToInt32(item);

            try
            {
                Navigation.PushAsync(new Elemento(TD));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}