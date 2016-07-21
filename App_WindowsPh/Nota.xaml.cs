using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Principal : Page
    {
        private ObservableCollection<notas> listnotaphone=new ObservableCollection<notas>();

        public Principal()
        {
            this.InitializeComponent();
        }
        private void Muestralistnotaphone(Object sender,RoutedEventArgs e) {
            ControlBD listnotas = new ControlBD();
            listnotaphone= listnotas.Retornanotas();
            if (listnotaphone.Count>0) {
                ButDell.IsEnabled = true;
            }
            listBox.ItemsSource =listnotaphone.OrderByDescending(i => i.Id).ToList();
        }
        private void AddNota_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NewNotaPhone));
        }
        private void DeleteAllNota_Click(object sender, RoutedEventArgs e)
        {
            SQL Db_Helper = new SQL();
            Db_Helper.BorraTodosAlumnos();
            listnotaphone.Clear();//Clear collections 
            listBox.ItemsSource = listnotaphone;
        }
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idSelecc = 0;
            notas listitem = listBox.SelectedItem as notas;//Get slected listbox item contact ID 
           Frame.Navigate(typeof(UpdateDeleteNota),idSelecc=listitem.Id);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
