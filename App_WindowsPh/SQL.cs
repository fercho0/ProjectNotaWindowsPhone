using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_WindowsPh
{
    public class SQL
    {

        SQLiteConnection dbConn;

        //Create Tabble 
        public async Task<bool> onCreate(string DB_PATH)
        {
            try
            {
                if (!ExisteBD(DB_PATH).Result)
                {
                    using (dbConn = new SQLiteConnection(DB_PATH))
                    {
                        dbConn.CreateTable<notas>();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private async Task<bool> ExisteBD(string fileName)
        {
            try
            {
                var store = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Retrieve the specific contact from the database. 
        public notas Leenotas(int idnotas)
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                var existingconact = dbConn.Query<notas>("select * from notas where Id =" + idnotas).FirstOrDefault();
                return existingconact;
            }
        }
        // Retrieve the all contact list from the database. 
        public ObservableCollection<notas> Visualizanotass()
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                List<notas> myCollection = dbConn.Table<notas>().ToList<notas>();
                ObservableCollection<notas> listnotaphonenotass = new ObservableCollection<notas>(myCollection);
                return listnotaphonenotass;
            }
        }

        //Update existing conatct 
        public void Actualizanotas(notas notas)
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                var existingconact = dbConn.Query<notas>("select * from notas where Id =" + notas.Id).FirstOrDefault();
                if (existingconact != null)
                {
                    existingconact.Nota = notas.Nota;
                    existingconact.Descripcion = notas.Descripcion;
                 //   existingconact.CreationDate = contact.CreationDate;
                    dbConn.RunInTransaction(() =>
                    {
                        dbConn.Update(existingconact);
                    });
                }
            }
        }
        // Insert the new contact in the Contacts table. 
        public void InsertContaacto(notas agrega)
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                dbConn.RunInTransaction(() =>
                {
                    dbConn.Insert(agrega);
                });
            }
        }

        //Delete specific contact 
        public void BorraAlumno(int Id)
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                var existingconact = dbConn.Query<notas>("select * from notas where Id =" + Id).FirstOrDefault();
                if (existingconact != null)
                {
                    dbConn.RunInTransaction(() =>
                    {
                        dbConn.Delete(existingconact);
                    });
                }
            }
        }
        //Delete all contactlist or delete Contacts table 
        public void BorraTodosAlumnos()
        {
            using (var dbConn = new SQLiteConnection(App.DB_PATH))
            {
                //dbConn.RunInTransaction(() => 
                //   { 
                dbConn.DropTable<notas>();
                dbConn.CreateTable<notas>();
                dbConn.Dispose();
                dbConn.Close();
                //}); 
            }
        }
    }
}
