using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Count
{
    class Config
    {
        string base_directory = Environment.CurrentDirectory + @"\config.cfg";


        public void Config_save(string[] config_data)
        {
            if (!File.Exists(base_directory))
            {
                File.Create(base_directory).Close();
            }

            using (StreamWriter sw = new StreamWriter(base_directory, false))
            {
                foreach (var line in config_data)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
        }

        public string[] Config_restore()
        {
            string[] config_data = new string[10];

            if (!File.Exists(base_directory))
            {
                return null;
            }

            using (StreamReader sr = new StreamReader(base_directory))
            {
                int i = 0;
                do
                {
                    config_data[i] = sr.ReadLine();
                    i++;
                } while (!sr.EndOfStream);
                return config_data.ToArray();
            }
        }
    }
}
