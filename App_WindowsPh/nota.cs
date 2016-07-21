using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_WindowsPh
{
    public class notas
    {
        //The Id property is marked as the Primary Key
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }
        public string Nota { get; set; }
        public string Descripcion { get; set; }
       // public string CreationDate { get; set; }
        public notas()
        {
            //constructor vacio
        }
        public notas(string nota, string descripcion)
        {
            Nota = nota;
            Descripcion = descripcion;
           // CreationDate = DateTime.Now.ToString();
        }
    }
}
