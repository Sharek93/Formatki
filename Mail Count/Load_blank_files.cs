using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Count
{
    class Load_blanks_file
    {

        public struct Blanks
        {
            public int line;
            public string title;
            public string text;
        }

        public Blanks[] load_blanks(string directory)
        {
            List<string> blanks_titles = new List<string>();
            List<string> blanks_text = new List<string>();
            List<int> blanks_line_no = new List<int>();

            if (!File.Exists(directory))
            {
                MessageBox.Show("Nie znaleziono pliku z formatkami, wskaż lokalizację zapisu w opcjach");
                return null;
            }
            else
            {
                using (StreamReader sr = new StreamReader(directory, Encoding.Default))
                {
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        blanks_line_no.Add(i);
                        i++;
                        string[] temp = sr.ReadLine().Split('$');
                        if (temp != null && temp.Length > 1)
                        {
                            blanks_titles.Add(temp[0]);
                            blanks_text.Add(temp[1]);
                        }
                    }
                    sr.Close();
                }

                Blanks[] blanks = new Blanks[blanks_titles.Count];

                for (int i = 0; i < blanks_titles.Count; i++)
                {
                    blanks[i].line = blanks_line_no[i];
                    blanks[i].title = blanks_titles[i];
                    blanks[i].text = blanks_text[i];
                }

                return blanks;
            }          
        }

        public void blank_edit(string directory, string blank_title, string blank_text, int line)
        {
            string[] lines = File.ReadAllLines(directory, Encoding.Default);
            lines[line] = blank_title + "$" + blank_text;
            File.WriteAllLines(directory, lines, Encoding.Default);
        }

        public void blank_add(string directory, string blank_title, string blank_text)
        {
            using (StreamWriter sw = new StreamWriter(directory, true, Encoding.Default))
            {
                sw.WriteLine(blank_title + "$" + blank_text);
                sw.Close();
            }
        }
    }
}
