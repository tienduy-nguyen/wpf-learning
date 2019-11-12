using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace WPFUnit.ExcelEpplus.HowKteam
{
    public partial class ExcelEpplus
    {
        public void ExportData(List<User> userList)
        {
            /*
             * Example of data in Excel
             * |Name                        |Birthday      |
             * |HowKteam                    |10-09-19      |
             * |FreeEducation               |10-10-19      |
             * |Share to be better          |10-11-19      |
             */
            //Open file excel
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel (*.xlsx) | *.xlsx| All files (*.*) | *.*";

            // Show open file dialog box 
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result != true)
                return;

            string fileName = dlg.FileName;
            if (string.IsNullOrWhiteSpace(fileName))
                return;

            var package = new ExcelPackage(new FileInfo(fileName));

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    //Set user for file
                    p.Workbook.Properties.Author = "Tien Duy NGUYEN";

                    //Set tile for file
                    p.Workbook.Properties.Title = "ExcelExportFormCsharp";

                    //Create a sheet
                    p.Workbook.Worksheets.Add("DataExport");

                    //Get sheet to work with
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    //Set name for worksheet
                    ws.Name = "FirstSheet";

                    //Fontsize defaut for all sheet
                    ws.Cells.Style.Font.Size = 11;
                    ws.Cells.Style.Font.Name = "Calibri";

                    //Create list of headers
                    string[] arrColumnHeader = { "Name", "Birth Day" };

                    //Get count of used column
                    var countColHeader = arrColumnHeader.Length;

                    //Merge all column on first row 
                    ws.Cells[1, 1].Value = "Table sample created from C#";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;

                    //Format bold text
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                    //Alignement center
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    var cell = ws.Cells[1, 1, 1, countColHeader];
                    //Format boders
                    var border = cell.Style.Border;
                    border.Bottom.Style =
                        border.Top.Style =
                            border.Left.Style =
                                border.Right.Style = ExcelBorderStyle.Thick;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //create headers
                    foreach (var item in arrColumnHeader)
                    {
                        cell = ws.Cells[rowIndex, colIndex];

                        //Format color and background
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid; 
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightSkyBlue);

                        //Format boders
                        border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                                border.Left.Style =
                                    border.Right.Style = ExcelBorderStyle.Thick;

                        //Set value to cells
                        cell.Value = item;
                        ++colIndex;
                    }
                    //Get list user from ItemSource of DataGrid --> User list

                    //Each item in user list, we will write on each row
                    foreach (var user in userList)
                    {
                        colIndex = 1;
                        ++rowIndex;
                        ws.Cells[rowIndex, colIndex].Value = user.Name;

                        cell = ws.Cells[rowIndex, colIndex];
                        border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                                border.Left.Style =
                                    border.Right.Style = ExcelBorderStyle.Thin;


                        //Attention Using .ToShortDataString to keep the format of  data
                        ws.Cells[rowIndex, ++colIndex].Value = user.BirthDay.ToShortDateString();
                        cell = ws.Cells[rowIndex, colIndex];
                        border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                                border.Left.Style =
                                    border.Right.Style = ExcelBorderStyle.Thin;
                    }
                    //Save file
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(fileName,bin);
                }

                MessageBox.Show("Export Successful!");
            }
            catch
            {
                MessageBox.Show("An error occured while trying to Export");
            }

        }

    }
}
