using System;
using System.Collections.Generic;

namespace Seguridad
{
    public class Login
    {
       private List<Usuario> usuarios{get; set;}

        public Login()
        {
            usuarios = new List<Usuario>();

            Usuario L1 = new Usuario();
            L1.pinAcceso = "8970";

            Usuario L2 = new Usuario();
            L2.pinAcceso = "9874";

            usuarios.Add(L1);
            usuarios.Add(L2);
        }
        
        public bool Validar(string pinacceso)
        {
            foreach (var usuario in usuarios){
             if(usuario.pinAcceso == pinacceso)
             {
                return true;
             }
            } 
            return false;  
        }
    }
}
