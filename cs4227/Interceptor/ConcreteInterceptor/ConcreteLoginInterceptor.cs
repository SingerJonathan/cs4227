using cs4227.Menu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4227.Interceptor.ConcreteInterceptor
{
    class ConcreteLoginInterceptor : LoginInterceptor
    {

        public void LoginRegister(LoginMenuV2 reference)
        {
            ContextObject UsernameContext = new ContextObject();
            string Username = UsernameContext.LoginContext(reference);
            string FileName = "logins.txt";
            string LoginTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.ffff");
            try
            {
                if(!(File.Exists(FileName)))
                {
                    File.Create(FileName);
                    TextWriter tw = new StreamWriter(FileName);
                    tw.WriteLine(Username, ","+LoginTime);
                }
                else
                {
                    TextWriter tw = new StreamWriter(FileName);
                    tw.WriteLine(Username, ","+LoginTime);
                }
            }
            catch (IOException e) { }
        }


    }
}
