using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRS.TimeTracking.Data
{
    public class HelloService : IHelloService
    {
        public string GetHelloMessage()
        {
            // data base access goes here
            return "Hello Message";
        }
    }
}
