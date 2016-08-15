using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VKDocker
{
    class Authorizate
    {
        protected const string path = "https://oauth.vk.com/authorize?client_id=5587925&display=popup&redirect_uri=https://oauth.vk.com/blank.html&scope=docs&response_type=token&v=5.53&state=123456";
        public string aut
        {
            get { return path; }
        }

        public void VKAuth(string URI)
        {   
            string URL = URI;
            string token = "access_token=";
            char[] simbol = { '=', '&' }; 
        try{
            if (URL.Contains(token))
                {
                        string[] cleartoken = URL.Split(simbol);
                        MessageBox.Show(cleartoken[1]);
      
                }    
            }
        catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
