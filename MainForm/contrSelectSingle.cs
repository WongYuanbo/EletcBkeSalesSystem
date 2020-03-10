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
    public partial class contrSelectSingle : UserControl
    {
        //private OdbcConnection odbcConn = new OdbcConnection();
        public contrSelectSingle()
        {
            InitializeComponent();
            //odbcConn = GlobalUtility.GetMainSysDbConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString() != "")
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string selStr = "";
                if (selectedItem == "颜色")
                {
                    selStr = "Select Distinct 颜色 From 车辆库存表 Where 是否售出 = '否'";
                }
                else if (selectedItem == "车型")
                {
                    selStr = "Select Distinct 车型 From 车辆库存表 Where 是否售出 = '否'";
                }
                else if (selectedItem == "品牌名")
                {
                    selStr = "Select Distinct 品牌名 From 车辆库存表 Where 是否售出 = '否'";
                }
                else if (selectedItem == "入库时间")
                {
                    selStr = "Select Distinct 入库时间 From 车辆库存表 Where 是否售出 = '否'";
                }
                else if (selectedItem == "入库人")
                {
                    selStr = "Select Distinct 入库人 From 车辆库存表 Where 是否售出 = '否'";
                }
                else if (selectedItem == "备注")
                {
                    selStr = "Select Distinct 备注 From 车辆库存表 Where 是否售出 = '否'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            string field = "";
            string fValue = GetAllValues();
            if(fValue == "()")
            {
              MessageBox.Show("没有选中任何查询值，请确定！");
              return;
            }
            if (comboBox1.SelectedItem.ToString() != "")
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string selStr = "";
                if (selectedItem == "品牌名")
                {
                    selStr = string.Format("Select 品牌名,车型,颜色,成本,提成,入库人,入库时间,备注 From 车辆库存表 Where 是否售出 = '否' And  品牌名 in {0}", fValue);
                }
                else if (selectedItem == "车型")
                {
                    selStr = string.Format("Select 品牌名,车型,颜色,成本,提成,入库人,入库时间,备注 From 车辆库存表 Where 是否售出 = '否' And  车型 in {0}", fValue);
                }
                else if (selectedItem == "颜色")
                {
                    selStr = string.Format("Select 品牌名,车型,颜色,成本,提成,入库人,入库时间,备注 From 车辆库存表 Where 是否售出 = '否' And  颜色 in {0}", fValue);
                }
                else if (selectedItem == "入库时间")
                {
                    selStr = string.Format("Select 品牌名,车型,颜色,成本,提成,入库人,入库时间,备注 From 车辆库存表 Where 是否售出 = '否' And  入库时间 in {0}", fValue);
                }
                else if (selectedItem == "入库人")
                {
                    selStr = string.Format("Select 品牌名,车型,颜色,成本,提成,入库人,入库时间,备注 From 车辆库存表 Where 是否售出 = '否' And  入库人 in {0}", fValue);
                }
                else if (selectedItem == "备注")
                {
                    selStr = string.Format("Select 品牌名,车型,颜色,成本,提成,入库人,入库时间,备注 From 车辆库存表 Where 是否售出 = '否' And  备注 in {0}", fValue);
                }
                if (selStr != "")
                {
                    DataTable dt = GlobalUtility.GetDataTable(selStr, GlobalVar.SysDbConn);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("未选择正确的查询条件，请重新选择！");
                        return;
                    }

                }
            }
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
