using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Projectstyrings;

namespace ConnectToDB2017_C06
{
    class Program { 
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Run();
        }

        private void Run()
        {
            Menu menu = new Menu();
            menu.RunMenu();
        }
    }
}
