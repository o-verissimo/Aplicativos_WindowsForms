using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca
{
    public class ValidaSenhaLogin
    {
        public static bool ValidarSenhaLogin(string senha)
        {
            if(senha == "curso") 
            {
                return true;
            }
            return false;
        }

    }
}
