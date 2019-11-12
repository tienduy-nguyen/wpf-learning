using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using WPFUnit.ExcelEpplus.ToiDiCodeDao;

namespace WPFUnit.ExcelEpplus.HowKteam
{
    public partial class ExcelEpplus
    {
        #region Create file exel
        private List<Item> CreateTestItems()
        {
            var resultsList = new List<Item>();
            for (int i = 0; i < 15; i++)
            {
                var a = new Item()
                {
                    Id = i,
                    Address = "Test Excel Address at " + i,
                    Money = 20000 + i * 10,
                    FullName = "Pham Hong Sang" + i
                };
                resultsList.Add(a);
            }
            return resultsList;
        }


        public void CreateExcelFile(Stream stream = null)
        {
            var list = CreateTestItems();
            using (var excelPackage = new ExcelPackage(stream ?? new MemoryStream()))
            {
                // Create author for file Excel
                excelPackage.Workbook.Properties.Author = "Tien Duy NGUYEN  ";
                // Tạo title cho file Excel
                excelPackage.Workbook.Properties.Title = "Create title from CSharp with Epplus";
                // thêm tí comments vào làm màu 
                excelPackage.Workbook.Properties.Comments = "Comment from CSharp";
                // Add Sheet vào file Excel
                excelPackage.Workbook.Worksheets.Add("First Sheet");
                // Lấy Sheet bạn vừa mới tạo ra để thao tác 
                var workSheet = excelPackage.Workbook.Worksheets[1];
                // Đỗ data vào Excel file
                workSheet.Cells[1, 1].LoadFromCollection(list, true, TableStyles.Dark9);
                //BindingFormatForExcel(workSheet, list);
                excelPackage.Save();
                
                Byte[] bin = excelPackage.GetAsByteArray();
                File.WriteAllBytes("", bin);
            }
        }


        #endregion //ECreate file excel
    }
}
