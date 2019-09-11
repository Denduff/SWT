using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    class Logger : Ilogger
    {

        Logger()
        {

        }

        public void Log(string s)
        {
            Console.WriteLine(s);
        }

    }
}
