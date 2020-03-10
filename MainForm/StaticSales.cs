using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EBike;
using System.Data.Odbc;
using System.Runtime.InteropServices;
using System.IO;

namespace EBike.MainForm
{
    public partial class StaticSales : UserControl
    {
        //private OdbcConnection odbcConn = new OdbcConnection();
        string selStr = "";//查询SQL语句
        List<string> lstValues = new List<string>();//指定统计项的值
        bool ylBool = false;//是否预览删除
        System.Data.DataTable dtRes = new System.Data.DataTable();
        public StaticSales()
        {
            InitializeComponent();
            //odbcConn = GlobalUtility.GetMainSysDbConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> chkBrands = new List<string>();
            List<string> chkTypes = new List<string>();
            List<string> chkColors = new List<string>();
            if (chkBrand.Checked)
            {
                chkBrands = GetAllSelectValues(chkListBrand);
            }
            if (chkListBrand.SelectedItem.ToString() != "")
            {
                dtRes = new DataTable();
                string selectedItem = chkListBrand.SelectedItem.ToString();
                dtRes.Columns.Add("统计项目", typeof(string));
                dtRes.Columns.Add("统计结果", typeof(string));
                if (selectedItem == "车型")
                {
                    selStr = string.Format("Select 车型 From 车辆库存表 Where 是否售出 ='是' And 车型 in {0}", fValue);
                     System.Data.DataTable dt = GlobalUtility.GetDataTable(selStr,GlobalVar.SysDbConn);
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < lstValues.Count; j++)
                        {
                            DataRow dr = dtRes.NewRow();
                            string fileter = string.Format("车型 = '{0}'",lstValues[j]);
                            DataRow[] drArrTim = dt.Select(fileter);
                            if (drArrTim.Length > 0)
                            {
                                dr["统计项目"] = lstValues[j];
                                dr["统计结果"] = drArrTim.Length;
                                dtRes.Rows.Add(dr);
                            }
                        }
                    }
                }
                else if (selectedItem == "品牌名")
                {
                    selStr = string.Format("Select 品牌名 From 车辆库存表 Where  是否售出 ='是' And 品牌名 in {0}", fValue);
                    System.Data.DataTable dt = GlobalUtility.GetDataTable(selStr,GlobalVar.SysDbConn);
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < lstValues.Count; j++)
                        {
                            DataRow dr = dtRes.NewRow();
                            string fileter = string.Format("品牌名 = '{0}'", lstValues[j]);
                            DataRow[] drArrTim = dt.Select(fileter);
                            if (drArrTim.Length > 0)
                            {
                                dr["统计项目"] = lstValues[j];
                                dr["统计结果"] = drArrTim.Length;
                                dtRes.Rows.Add(dr);
                            }
                        }
                    }
                }
                else if (selectedItem == "销售员")
                {
                    selStr = string.Format("Select 销售员 From 车辆库存表 Where 是否售出 ='是' And 销售员 in {0}", fValue);
                    System.Data.DataTable dt = GlobalUtility.GetDataTable(selStr,GlobalVar.SysDbConn);
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < lstValues.Count; j++)
                        {
                            DataRow dr = dtRes.NewRow();
                            string fileter = string.Format("销售员 = '{0}'", lstValues[j]);
                            DataRow[] drArrTim = dt.Select(fileter);
                            if (drArrTim.Length > 0)
                            {
                                dr["统计项目"] = lstValues[j];
                                dr["统计结果"] = drArrTim.Length;
                                dtRes.Rows.Add(dr);
                            }
                        }
                    }

                }
                else if (selectedItem == "销售时间")
                {
                    selStr = string.Format("Select 销售时间 From 车辆库存表 Where 是否售出 ='是' And 销售时间 in {0}", fValue);
                    System.Data.DataTable dt = GlobalUtility.GetDataTable(selStr,GlobalVar.SysDbConn);
                    if (dt.Rows.Count > 0)
                    {
                        for (int j = 0; j < lstValues.Count; j++)
                        {
                            DataRow dr = dtRes.NewRow();
                            string fileter = string.Format("销售时间 = '{0}'", lstValues[j]);
                            DataRow[] drArrTim = dt.Select(fileter);
                            if (drArrTim.Length > 0)
                            {
                                dr["统计项目"] = lstValues[j];
                                dr["统计结果"] = drArrTim.Length;
                                dtRes.Rows.Add(dr);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = dtRes;
            }
            ylBool = true;
        }
        /// <summary>
        /// 获取所有选中的值
        /// </summary>
        /// <returns></returns>
        private List<string> GetAllSelectValues(CheckedListBox chkList)
        {
            List<string> listRet = new List<string>();
            for (int i = 0; i < chkList.CheckedItems.Count; i++)
            {
                listRet.Add(chkList.CheckedItems[i].ToString());
            }
            return listRet;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ylBool)
            {
                try
                {
                    string savePath = textBox1.Text.Trim();;//
                   Export2Xls(dtRes, savePath, true);
                   //Export2CSV(dtRes, savePath, true);
                }
                catch
                { }
                MessageBox.Show("输出成功！");
            }
            else
            {
                MessageBox.Show("输出结果前，请先进性统计操作！");
                return;
            }
        }
        private string GetColumnName(int colIndex)
        {
            string colName1 = "";
            string colName2 = "A";

            int m = colIndex / 26;
            int n = colIndex % 26;

            if (n == 0)
                m = m - 1;

            if (m == 0)
                colName1 = "";
            else
                colName1 = ((char)(m + 64)).ToString();

            if (n == 0)
                colName2 = "Z";
            else
                colName2 = ((char)(n + 64)).ToString();

            return colName1 + colName2;
        }
        //datatable导出到xls
         public static void Export2Xls(DataTable data, string filename, bool exportHeader = true)
        {
            if (System.IO.File.Exists(filename))
                System.IO.File.Delete(filename);
 
            Microsoft.Office.Interop.Excel._Application xlsApp = null;
            Microsoft.Office.Interop.Excel._Workbook xlsBook = null;
            Microsoft.Office.Interop.Excel._Worksheet xstSheet = null;
            try
            {
                xlsApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
 
                xlsBook = xlsApp.Workbooks.Add();
                xstSheet = (Microsoft.Office.Interop.Excel._Worksheet)xlsBook.Worksheets[1];
 
                var buffer = new StringBuilder();
                if (exportHeader)
                {
                    //Excel中列与列之间按照Tab隔开
                    foreach (DataColumn col in data.Columns)
                        buffer.Append(col.ColumnName + "\t");
 
                    buffer.AppendLine();
                }
                foreach (DataRow row in data.Rows)
                {
                    foreach (DataColumn col in data.Columns)
                        buffer.Append(row[col].ToString() + "\t");
 
                    buffer.AppendLine();
                }
                System.Windows.Forms.Clipboard.SetDataObject("");
                // 放入剪切板
                System.Windows.Forms.Clipboard.SetDataObject(buffer.ToString());
                var range = (Microsoft.Office.Interop.Excel.Range)xstSheet.Cells[1, 1];
                range.Select();
                xstSheet.Paste();
                //清空剪切板
                System.Windows.Forms.Clipboard.SetDataObject("");
 
                xlsBook.SaveAs(filename);
            }
            finally
            {
                if (xlsBook != null)
                    xlsBook.Close();
 
                if (xlsApp != null)
                    xlsApp.Quit();
                // finally里清空Com对象
                Marshal.ReleaseComObject(xlsApp);
                Marshal.ReleaseComObject(xlsBook);
                Marshal.ReleaseComObject(xstSheet);

                xstSheet = null;
                xlsBook = null;
                xlsApp = null;
            }
        }
        //datatable导出csv
        public  void Export2CSV(DataTable data, string filename, bool exportHeader = true)
        {
            if (File.Exists(filename))
                File.Delete(filename);
 
            var buffer = new StringBuilder();
            if (exportHeader)
            {
                for (var i = 0; i < data.Columns.Count; i++)
                {
                    buffer.AppendFormat("{0}", data.Columns[i].ColumnName);
                    if (i < data.Columns.Count - 1)
                        buffer.Append(",");
                }
                buffer.AppendLine();
            }
             for (var i = 0; i < data.Rows.Count; i++)
            {
                for (var j = 0; j < data.Columns.Count; j++)
                {
                    buffer.AppendFormat("{0}", data.Rows[i][j].ToString());
                    if (j < data.Columns.Count - 1)
                        buffer.Append(",");
                }
                buffer.AppendLine();
            }
 
            File.WriteAllText(filename, buffer.ToString(), Encoding.Default);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Microsoft Excel File (*.xls)|*.xls";
            //saveDlg.InitialDirectory = SystemPath.DataPath;
            saveDlg.CheckFileExists = false;
            if (saveDlg.ShowDialog(this) == DialogResult.OK)
            {
                textBox1.Text  = saveDlg.FileName;
            }
            else
            {
                return;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ylBool = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListBrand.Items.Count; i++)
            {
                chkListBrand.SetItemChecked(i, true);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListBrand.Items.Count; i++)
            {
                chkListBrand.SetItemChecked(i, false);
            }
        }
        //根据复选框选择情况，设置品牌名list内容
        private void chkBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBrand.Checked)
            {
                List<string> allValues = GetAllValues("品牌名");
                for (int i = 0; i < allValues.Count; i++)
                {
                    chkListBrand.Items.Add(allValues[i]);
                }
            }
            else
            {
                chkListBrand.Items.Clear();
            }
        }
        //根据复选框选择情况，设置车型list内容
        private void chkType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkType.Checked)
            {
                List<string> allValues = GetAllValues("车型");
                for (int i = 0; i < allValues.Count; i++)
                {
                    chkListType.Items.Add(allValues[i]);
                }
            }
            else
            {
                chkListType.Items.Clear();
            }
        }
        //根据复选框选择情况，设置颜色list内容
        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColor.Checked)
            {
                List<string> allValues = GetAllValues("颜色");
                for (int i = 0; i < allValues.Count; i++)
                {
                    chkListColor.Items.Add(allValues[i]);
                }
            }
            else
            {
                chkListColor.Items.Clear();
            }
        }
        /// <summary>
        /// 获取指定字段的所有值
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private List<string> GetAllValues(string field)
        {
            List<string> listRet = new List<string>();
            string tableName = "车辆库存表";
            selStr = string.Format("Select Distinct {0} From {1} Where 是否售出 ='是' order by {0}", field, tableName);
            try
            {
                System.Data.DataTable dt = GlobalUtility.GetDataTable(selStr, GlobalVar.SysDbConn);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listRet.Add(dt.Rows[i][0].ToString().Trim());
                    }
                }
                else
                {
                    MessageBox.Show("未选择正确的查询条件，请重新选择！");
                    return listRet;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listRet;
        }

  
  
    }
}
