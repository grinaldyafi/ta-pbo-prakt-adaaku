using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaAku
{
    class Pengguna
    {
        //Definisikan Property
        // Pertama definisikan Instance Variable
       
        private string _loginName;
        private string _password;
        
        
        //kemudian definisikan property
       
        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }
         public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

       
     // definisikan method kelas
     public Boolean Login(string loginName, string password)
        {
            if (loginName == "admin" & password == "admin")
            {
              
                return true;
            }
            else
            {
                return false;
            }
        }
        //Definisikan Constructor
       
        public Pengguna(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }

    }


}
