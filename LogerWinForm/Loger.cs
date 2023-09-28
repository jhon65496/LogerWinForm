using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace LogerWinForm
{
    public class Loger
    {
        string path = "LogAppLogerWinForm.txt";

        public void Log(string message)
        {
            string messageFull = DateTime.Now.ToString("yyyy.MM.dd || hh:mm:ss:ffff" + " || " + message); //++ || 08:46:22:7034            
            WriteLine(messageFull);
        }
        
        public void WriteLine(string messageFull)
        {
            using (StreamWriter logger = new StreamWriter(path, true, Encoding.GetEncoding("UTF-8")))
            {
                logger.WriteLine(messageFull); 
                        
                Debug.WriteLine("=== Логер ===");
                Debug.WriteLine(messageFull);
                Debug.WriteLine("=== === === ===");
            }
        }
    }

}
