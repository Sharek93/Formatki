using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Count
{
    class Xls_save
    {
        HSSFWorkbook wbx;
        XSSFWorkbook wb;
        string[] users;
        int column_no = 0, row_no = 0;
        bool curr_date = false;

        public bool Save(int value, string current_user , string directory)
        {
            //zerowanie zmiennych
            curr_date = false;
            column_no = 0; row_no = 0;
            ISheet sheet = null;

            //otwarcie pliku i wczytanie zeszytu

            if (!File.Exists(directory))
            {
                return false;
            }
            else
            {
                using (FileStream stream = new FileStream(directory, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    string[] temp = directory.Split('.');

                    if (temp[temp.Length - 1] == "xls")
                    {
                        wbx = new HSSFWorkbook(stream);
                        sheet = wbx.GetSheetAt(0);
                    }
                    else if (temp[temp.Length - 1] == "xlsx")
                    {
                        wb = new XSSFWorkbook(stream);
                        sheet = wb.GetSheetAt(0);
                    }
                    stream.Close();
                }


                //Utworzenie pierwszego wiersa jeżeli plik jest pusty
                if (sheet.LastRowNum == 0)
                {
                    sheet.CreateRow(0);
                    sheet.GetRow(0).CreateCell(0).SetCellType(CellType.String);
                    sheet.GetRow(0).GetCell(0).SetCellValue("Data");
                }

                //utworzenie pustej tablicy użytkowników którzy wcześniej edytowali ten plik
                users = new string[sheet.GetRow(0).Cells.Count];

                //Wczytanie listy użytkowników z pliktu do tablicy 
                for (int i = 0; i < sheet.GetRow(0).Cells.Count; i++)
                {
                    users[i] = sheet.GetRow(0).GetCell(i).StringCellValue;
                }

                //Sprawdzenie czy użytkownik, który aktualnie zapisuje już kiedyś był wpisany i
                //ustalenie kolumny w której sie znajduje
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i] == current_user)
                    {
                        column_no = i;
                        break;
                    }
                    else
                    {
                        column_no = users.Length;
                    }
                }

                //Ustalanie kolumny w której będą zapisywane wyniki
                if (column_no == 0)
                {
                    sheet.GetRow(0).CreateCell(users.Length).SetCellType(CellType.String);
                    sheet.GetRow(0).GetCell(users.Length).SetCellValue(current_user);
                    column_no++;
                }
                else
                {
                    sheet.GetRow(0).CreateCell(column_no).SetCellType(CellType.String);
                    sheet.GetRow(0).GetCell(column_no).SetCellValue(current_user);
                }

                //Zapisanie do zmiennej dzisiejszej daty
                string data = string.Format("{0:0000}.{1:00}.{2:00}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                //Ustalenie wiersza w którym będzie zapisany wynik
                if (sheet.LastRowNum > 0)
                {
                    for (int i = 0; i <= sheet.LastRowNum; i++)
                    {
                        if (sheet.GetRow(i).GetCell(0).StringCellValue != string.Empty)
                        {
                            if (sheet.GetRow(i).GetCell(0).StringCellValue == data)
                            {
                                row_no = i;
                                curr_date = true;
                                break;
                            }
                            else
                            {
                                row_no = i;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                //Tworzenie nowego wiersza jeżeli znacznik końca pliku jest równy ostatniemu wierszowi
                if (sheet.LastRowNum <= row_no && curr_date == false)
                {
                    row_no++;
                    sheet.CreateRow(row_no);
                }

                //Zapisywanie w arkuszu daty i wyniku na ustalonej pozycji
                sheet.GetRow(row_no).CreateCell(0).SetCellType(CellType.String);
                sheet.GetRow(row_no).GetCell(0).SetCellValue(data);
                sheet.GetRow(row_no).CreateCell(column_no).SetCellType(CellType.String);
                sheet.GetRow(row_no).GetCell(column_no).SetCellValue(value);

                //zapis arkusza do pliku
                using (FileStream stream = new FileStream(directory, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                {
                    wbx.Write(stream);
                    wbx.Close();
                    stream.Close();
                }
                return true;
            }
        }
    }
}
