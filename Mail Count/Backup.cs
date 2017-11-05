using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Count
{
    class Backup
    {
        public void backup(string current_user, string value)
        {
            string base_directory = Environment.CurrentDirectory;
            string directory = string.Empty;
            if (!Directory.Exists(base_directory + @"\Backup"))
            {
                Directory.CreateDirectory(base_directory + @"\Backup");                
            }
            if (!Directory.Exists(base_directory + @"\Backup\" + current_user))
            {
                Directory.CreateDirectory(base_directory + @"\Backup\" + current_user);
            }

            directory = base_directory + @"\Backup\" + current_user + @"\";
            string date = string.Format("{0:0000}-{1:00}-{2:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            if (!File.Exists(directory + date + ".txt"))
            {
                File.Create(directory + date + ".txt").Close(); 
            }            

            using (StreamWriter sw = new StreamWriter(directory + date + ".txt", false))
            {
                sw.WriteLine(value);
                sw.Close();
            }
        }
    }
}
