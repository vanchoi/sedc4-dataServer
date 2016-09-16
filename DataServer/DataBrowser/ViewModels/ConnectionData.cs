using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBrowser.ViewModels
{
    public class ConnectionData
    {
        public string ServerName { get; set; }
        public AuthenticationType AuthType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        internal object GetConnectionString()
        {
            throw new NotImplementedException();
        }
    }
}
