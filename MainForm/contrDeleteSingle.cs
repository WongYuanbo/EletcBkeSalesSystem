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

namespace EBike.MainForm
{
    public partial class contrDeleteSingle : UserControl
    {
        //private OdbcConnection odbcConn = new OdbcConnection();
        string selStr = "";//查询SQL语句
        string deleStr = "";//删除的SQL语句
        bool ylBool = false;//是否预览删除
        public contrDeleteSingle()
        {
            InitializeComponent();
            //odbcConn = GlobalUtility.GetMainSysDbConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            ylBool = false;
            if (comboBox1.SelectedItem.ToString() != "")
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string selStr = "";
                if (selectedItem == "车辆ID")
                {
                    selStr = "Select Distinct 车辆ID From 车辆库存表 order by 车辆ID ";
                }
                else if (selectedItem == "车型")
                {
                    selStr = "Select Distinct 车型 From 车辆库存表  order by 车型";
                }
                else if (selectedItem == "品牌名")
                {
                    selStr = "Select Distinct 品牌名 From 车辆库存表  order by 品牌名";
                }
                else if (selectedItem == "入库时间")
                {
                    selStr = "Select Distinct 入库时间 From 车辆库存表 order by 入库时间";
                }
                else if (selectedItem == "入库人")
                {
                    selStr = "Select Distinct 入库人 From 车辆库存表  order by 入库人";
                }
                else if (selectedItem == "备注")
                {
                    selStr = "Select Distinct 备注 From 车辆库存表 order by 备注";
                }

                if (selStr != "")
                {
                    DataTable dt = GlobalUtility.GetDataTable(selStr,GlobalVar.SysDbConn);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            checkedListBox1.Items.Add(dt.Rows[i][0].ToString().Trim());
                        }
                    }
                    else
                    {
                        MessageBox.Show("未选择正确的查询条件，请重新选择！");
                        return;
                    }

                }



            }
        }

        private void radioSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void radioClear_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selStr = "";
            deleStr = "";
            string fValue = GetAllValues();
            if(fValue == "()")
            {
              MessageBox.Show("没有选中任何删除值，请确定！");
              return;
            }
            if (comboBox1.SelectedItem.ToString() != "")
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                if (selectedItem == "车辆ID")
                {
                    selStr = string.Format("Select 车辆ID,车型,品牌名,入库时间,入库人,是否售出,销售员,销售时间,备注 From 车辆库存表 Where  车辆ID in {0}", fValue);
                    deleStr = string.Format("Delete * From 车辆库存表 Where  车辆ID in {0}", fValue);
                }
                else if (selectedItem == "车型")
                {
                    selStr = string.Format("Select 车辆ID,车型,品牌名,入库时间,入库人,是否售出,销售员,销售时间,备注 From 车辆库存表 Where  车型 in {0}", fValue);
                    deleStr = string.Format("Delete * From 车辆库存表 Where 车型 in {0}", fValue);
                }
                else if (selectedItem == "品牌名")
                {
                    selStr = string.Format("Select 车辆ID,车型,品牌名,入库时间,入库人,是否售出,销售员,销售时间,备注 From 车辆库存表 Where  品牌名 in {0}", fValue);
                    deleStr = string.Format("Delete * From 车辆库存表 Where   品牌名 in {0}", fValue);
                }
                else if (selectedItem == "入库时间")
                {
                    selStr = string.Format("Select 车辆ID,车型,品牌名,入库时间,入库人,是否售出,销售员,销售时间,备注 From 车辆库存表 Where 入库时间 in {0}", fValue);
                    deleStr = string.Format("Delete * From 车辆库存表 Where 入库时间 in {0}", fValue);
                }
                else if (selectedItem == "入库人")
                {
                    selStr = string.Format("Select 车辆ID,车型,品牌名,入库时间,入库人,是否售出,销售员,销售时间,备注 From 车辆库存表 Where  入库人 in {0}", fValue);
                    deleStr = string.Format("Delete * From 车辆库存表 Where  入库人 in {0}", fValue);
                }
                else if (selectedItem == "备注")
                {
                    selStr = string.Format("Select 车辆ID,车型,品牌名,入库时间,入库人,是否售出,销售员,销售时间,备注 From 车辆库存表 Where 备注 in {0}", fValue);
                    deleStr = string.Format("Delete * From 车辆库存表 Where 备注 in {0}", fValue);
                }

                if (selStr != "")
                {
                    DataTable dt = GlobalUtility.GetDataTable(selStr,GlobalVar.SysDbConn);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("数据库中不存在相应条件的记录，请核实！");
                        return;
                    }

                }
            }
            ylBool = true;
        }
        /// <summary>
        /// 获取所有选中的值
        /// </summary>
        /// <returns></returns>
        private string GetAllValues()
        {
            string str = "(";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                str = str +"'" +checkedListBox1.CheckedItems[i].ToString()+"'"+",";
            }
            if (str.Length > 2)
            {
                str = str.Remove(str.Length - 1, 1) + ")";
            }
            else
            {
                str = str + ")";
            }
            return str;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ylBool)
            {
                if (selStr != "" && deleStr != "")
                {
                    try
                    {
                        OdbcCommand cmd = new OdbcCommand();
                        cmd.Connection = GlobalVar.SysDbConn;
                        cmd.CommandText = deleStr;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("删除成功！");
                        dataGridView1.DataSource = null; 
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("删除失败，因为：" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("确认删除前，请先进行预览！");
                return;
            }
        }
    }
}
