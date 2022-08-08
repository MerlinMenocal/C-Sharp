using System;
using System.Collections.Generic;

namespace Seguridad
{
    public class Login{

        private List<Usuario> usuario{get; set;}

        public Login()
        {
            usuario = new List<Usuario>();

            Usuario L1 = new Usuario();
            L1.pinAcceso = "8970";

            Usuario L2 = new Usuario();
            L2.pinAcceso = "9874";

            usuario.Add(L1);
            usuario.Add(L2);
        }
        
        public bool Validar(string pinacceso)
        {
            foreach (var usuario in usuario){
             if(usuario.pinAcceso == usuario.pinacceso)
             {
                return true;
             }
            } 
            return false;  
        }
    }
}