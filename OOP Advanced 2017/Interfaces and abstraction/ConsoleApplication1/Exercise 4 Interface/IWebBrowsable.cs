using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_Interface
{
    public interface IWebBrowsable
    {
        List<string> WebSites { get; }
        void Browse();
    }
}
