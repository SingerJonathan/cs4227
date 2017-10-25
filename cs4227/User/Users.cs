using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4227.User
{
    public class Users            //Composite Design Pattern
    {
        Admin SystemAdmin = new Admin("wbutler", "William", "Password", true);

        Admin ResturantAdmin1 = new Admin("stevec","Steve", "Password", false);
 
        

        
    }
}
