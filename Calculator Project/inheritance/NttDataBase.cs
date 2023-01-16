using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.inheritance
{
    public class NttDataBase
    {
        private Guid guid;

        public Guid Guid
        {
            get { return guid; }
        }
        public NttDataBase()
        {
            guid = Guid.NewGuid();
        }
    }
}
