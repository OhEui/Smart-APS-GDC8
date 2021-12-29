using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace APSWinForm
{
    public class ExcelUtil
    {
        public static void ExcelExport(DataGridView dgv)
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

        public static bool ExportExcelToList<T>(List<T> dataList, string saveFileName, string exceptColumns)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //xlWorkSheet.Name = dt.TableName;

                //List VO의 속성명 엑셀의 첫번째 행에 추가 (1번행)
                int columnIndex = 0;
                foreach (PropertyInfo prop in typeof(T).GetProperties())
                {
                    if (!exceptColumns.Contains(prop.Name))
                    {
                        columnIndex++;
                        xlWorkSheet.Cells[1, columnIndex] = prop.Name;
                    }
                }

                //List VO의 건수만큼 컬럼별로 셀에 추가
                for (int r = 0; r < dataList.Count; r++)
                {
                    columnIndex = 0;
                    foreach (PropertyInfo prop in typeof(T).GetProperties())
                    {
                        if (!exceptColumns.Contains(prop.Name))
                        {
                            columnIndex++;
                            if (prop.GetValue(dataList[r], null) != null)
                            {
                                xlWorkSheet.Cells[r + 2, columnIndex] = prop.GetValue(dataList[r], null).ToString();
                            }
                        }
                    }
                }

                xlWorkSheet.Columns.AutoFit();
                //엑셀컬럼의 너비가 데이터길이에 따라서 자동조정

                xlWorkBook.SaveAs(saveFileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        public static void ExcelImport()
        {
            /*
             import 과정
            1. excel에서 데이터를 읽어옴
            2. insert할 테이블과 읽어온 데이터의 schema를 비교
            3. schema가 동일하면 insert 실행 (delete 여부는 생각 중)
             
             */
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel Files(*.xls)|*.xls|Excel Files(*.xlsx)|*.xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"; //*.xls
                string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"; //*.xlsx

                string filename = dlg.FileName;
                string fileExtension = System.IO.Path.GetExtension(filename);

                string strConn = string.Empty;
                if (fileExtension == ".xls")
                    strConn = string.Format(Excel03ConString, filename, "Yes");
                else
                    strConn = string.Format(Excel07ConString, filename, "Yes");

                OleDbConnection conn = new OleDbConnection(strConn);

                //워크쉬트 이름을 조회
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString(); //첫번째 sheet

                string sql = "select * from [" + sheetName + "]";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
        }
        private static void releaseObject(object obj)
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
