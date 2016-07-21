using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App_WindowsPh
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UpdateDeleteNota : Page
    {
        int seleccionado = 0;
        SQL db = new SQL();
        notas notas = new notas();

        public UpdateDeleteNota()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            seleccionado = int.Parse(e.Parameter.ToString());
            notas = db.Leenotas(seleccionado);//Read selected DB contact 
            txtnota.Text = notas.Nota;//get contact Name 
            txtdescripcion.Text = notas.Descripcion;//get contact PhoneNumber 
        }
        private void DeleteNota_Click(object sender, RoutedEventArgs e)
        {

            db.BorraAlumno(seleccionado);//Delete selected DB contact Id. 
            Frame.Navigate(typeof(Principal));
        }
        private void Principal_Click(object sender, RoutedEventArgs e)
        { 
            Frame.Navigate(typeof(Principal));
        }
        private void UpdateNota_Click(object sender, RoutedEventArgs e)
        {

            notas.Nota = txtnota.Text;
            notas.Descripcion = txtdescripcion.Text;
            db.Actualizanotas(notas);//Update selected DB contact Id 
            Frame.Navigate(typeof(Principal));
        }

    }
}
