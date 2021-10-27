using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleKitSala
{
    class Conexao
    {
        static public string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guton\source\repos\ControleKitSala\ControleKitSala\db_kitSala.mdf;Integrated Security=True";
        }

    }
}