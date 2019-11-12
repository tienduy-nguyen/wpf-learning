using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using OfficeOpenXml;

namespace WPFUnit.ExcelEpplus.HowKteam
{
    public partial class ExcelEpplus
    {
        #region Import Date from file excel
        public List<User> GetListData()
        {
            /*
             * Example of data in Excel
             * |Name                        |Birthday      |
             * |HowKteam                    |10-09-19      |
             * |FreeEducation               |10-10-19      |
             * |Share to be better          |10-11-19      |
             */
            var userList = new List<User>();
            //Open file excel
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel (*.xl*) | *.xl*| All files (*.*) | *.*";

            // Show open file dialog box 
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result != true)
                return new List<User>();

            string fileName = dlg.FileName;
            if (string.IsNullOrWhiteSpace(fileName))
                return new List<User>();

            var package = new ExcelPackage(new FileInfo(fileName));
            try
            {//Get first sheet to work with
                ExcelWorksheet sh = package.Workbook.Worksheets[1];

                for (int row = sh.Dimension.Start.Row + 1; row <= sh.Dimension.End.Row; ++row)
                {
                    try
                    {
                        int col = 1;

                        //Read by column to get the column Name
                        string name = sh.Cells[row, col++].Value.ToString();

                        //Get the column Birthday
                        var birthDayTemp = sh.Cells[row, col].Value;
                        DateTime birthDay = new DateTime();
                        if (birthDayTemp != null)
                            birthDay = birthDayTemp as DateTime? ?? new DateTime();
                        User user = new User()
                        {
                            Name = name,
                            BirthDay = birthDay
                        };
                        userList.Add(user);

                    }
                    catch
                    {
                        // ignored
                    }

                }

            }
            catch
            {
                // ignored
            }

            return userList;

        }


        #endregion //End Get Data from file excel
    }

}
