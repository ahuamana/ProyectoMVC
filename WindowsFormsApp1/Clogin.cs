using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Clogin
    {

        public bool login( string user , string pass) {


            Mlogin login01 = new Mlogin();
            bool resultado=login01.Login( user , pass);

            return resultado;
        
        }

    }
}
