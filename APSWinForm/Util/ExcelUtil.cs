using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace APSWinForm
{
    public class ExcelUtil
    {
        public void ExcelExport(DataGridView dgv)
        {
            //저장할 디렉토리, 파일명을 물어보고, 그 파일경로로 엑셀파일 저장
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls";
            dlg.Title = "엑셀파일로 내보내기";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                DataTable dt = (DataTable)dgv.DataSource;

                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    xlWorkSheet.Cells[1, c + 1] = dt.Columns[c].ColumnName;
                }

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        xlWorkSheet.Cells[r + 2, c + 1] = dt.Rows[r][c].ToString();
                    }
                }

                xlWorkBook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("엑셀 다운로드 완료");
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
