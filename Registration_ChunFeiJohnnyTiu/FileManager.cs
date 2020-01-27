using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_ChunFeiJohnnyTiu
{
    internal class FileManager
    {
        static FileStream fs;
        static StreamWriter sw;

        public static void SaveStringToFile(string s)
        {
            using (fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write))
            {
                using (sw = new StreamWriter(fs))
                {
                    sw.Write(s);
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }
            }
        }
    }
}
