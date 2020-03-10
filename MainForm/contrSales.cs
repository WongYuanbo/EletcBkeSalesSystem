using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EBike.MainForm
{
    public partial class contrSales : UserControl
    {
        //private OdbcConnection odbcConn = new OdbcConnection();
        public contrSales()
        {
            InitializeComponent();
            //odbcConn = GlobalUtility.GetMainSysDbConnection();
            IniComBox();
        }
       
        private void IniComBox()
        {
            combBrand.Items.Clear();
            combType.Items.Clear();
            combColor.Items.Clear();
            combSaler.Items.Clear();
            combAssemb.Items.Clear();
            string sqlBrand = string.Format("Select Distinct 品牌名 from 车辆库存表 Where 是否售出 = '否' order by 品牌名 asc");
            System.Data.DataTable dtBrands = GlobalUtility.GetDataTable(sqlBrand, GlobalVar.SysDbConn);
            if (dtBrands.Rows.Count > 0)
            {
                for (int i = 0; i < dtBrands.Rows.Count; i++)
                {
                    combBrand.Items.Add(dtBrands.Rows[i][0].ToString());
                }
            }
            string sqlType = string.Format("Select Distinct 车型 from 车辆库存表 Where 是否售出 = '否' order by 车型 asc");
            System.Data.DataTable dtTypes = GlobalUtility.GetDataTable(sqlType, GlobalVar.SysDbConn);
            if (dtTypes.Rows.Count > 0)
            {
                for (int i = 0; i < dtTypes.Rows.Count; i++)
                {
                    combType.Items.Add(dtTypes.Rows[i][0].ToString());
                }
            }
            string sqlColor = string.Format("Select Distinct 颜色 from 车辆库存表 Where 是否售出 = '否' order by 颜色 asc");
            System.Data.DataTable dtColorS = GlobalUtility.GetDataTable(sqlColor, GlobalVar.SysDbConn);
            if (dtColorS.Rows.Count > 0)
            {
                for (int i = 0; i < dtColorS.Rows.Count; i++)
                {
                    combColor.Items.Add(dtColorS.Rows[i][0].ToString());
                }
            }
            string sqlSaler = string.Format("Select 销售员 from TC_销售员 order by 销售员 asc");
            System.Data.DataTable dtSalerS = GlobalUtility.GetDataTable(sqlSaler, GlobalVar.SysDbConn);
            if (dtSalerS.Rows.Count > 0)
            {
                for (int i = 0; i < dtSalerS.Rows.Count; i++)
                {
                    combSaler.Items.Add(dtSalerS.Rows[i][0].ToString());
                }
            }
            string sqlAssem = string.Format("Select 装车人员 from TC_装车人员 order by 装车人员 asc");
            System.Data.DataTable dtassemS = GlobalUtility.GetDataTable(sqlAssem, GlobalVar.SysDbConn);
            if (dtassemS.Rows.Count > 0)
            {
                for (int i = 0; i < dtassemS.Rows.Count; i++)
                {
                    combAssemb.Items.Add(dtassemS.Rows[i][0].ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bBrand = "";//品牌
            string bType = "";//车型
            string bColor = "";//车辆颜色
            string saleDate = "";//销售时间
            int bNum = 0;//销售数量
            string brkSalePers="";//销售员
            string bAssember = "";//装车人员
            List<string> guidList = new List<string>();
            //品牌
            if (combBrand.Text.Trim() == "")
            {
                MessageBox.Show("品牌名不能为空，请确认！");
                return;
            }
            else
            {
                bBrand = combBrand.Text.Trim();
            }
            //车型
            if (combType.Text.Trim() == "")
            {
                MessageBox.Show("车型不能为空，请确认！");
                return;
            }
            else
            {
                bType = combType.Text.Trim();
            }
            //数量
            if (txtNum.Text.Trim() == "")
            {
                MessageBox.Show("数量不能为空，请确认！");
                return;
            }
            else
            {
                if (int.TryParse(txtNum.Text.Trim(), out bNum))
                {

                }
                else
                {
                    MessageBox.Show("数量必须为整数，请确认！");
                    return;
                }
            }
            if (combColor.Text.Trim() == "")
            {
                MessageBox.Show("车辆颜色不能为空，请确认！");
                return;
            }
            else
            {
                bColor = combColor.Text.Trim();
            }
            if (txtDate.Text.Trim() == "")
            {
                MessageBox.Show("销售时间不能为空，请确认！");
                return;
            }
            DateTime saleDateTim = new DateTime();
            if (DateTime.TryParse(txtDate.Text.Trim(), out saleDateTim))
            {
                saleDate = saleDateTim.ToShortDateString();
                
            }
            else
            {
                MessageBox.Show("入库时间不是标准的时间格式，请重新选择！");
                return;
            }
            if (combSaler.Text.Trim() == "")
            {
                MessageBox.Show("销售员不能为空，请确认！");
                return;
            }
            else
            {
                brkSalePers = combSaler.Text.Trim();
            }
            if (combAssemb.Text.Trim() == "")
            {
                MessageBox.Show("装车人员不能为空，请确认！");
                return;
            }
            else
            {
                bAssember = combAssemb.Text.Trim();
            }
            //判读数据库中是否存在指定车辆ID的未售出车辆
            string sqlSel = string.Format("Select 车辆ID,品牌名,是否售出,车型,颜色,销售员,销售时间 from 车辆库存表 Where 品牌名 = '{0}' And 车型 ='{1}' And 颜色 ='{2}' And 是否售出 = '{3}'", bBrand, bType, bColor,"否");
            System.Data.DataTable dtBId = GlobalUtility.GetDataTable(sqlSel,GlobalVar.SysDbConn);
            if (dtBId.Rows.Count > 0)
            {
                if (dtBId.Rows.Count < bNum)
                {
                    MessageBox.Show("数据库中不存在品牌名为" + bBrand + ",车型为" + bType + ",颜色为" + bColor + "的库存车辆只有" + dtBId.Rows.Count + "辆，小于输入的销售数量，请核实！");
                    return;
                }
                else
                {
                    
                    for (int i = 0; i < bNum; i++)
                    {
                        string bID = "{" + dtBId.Rows[i]["车辆ID"].ToString() + "}";
                        try
                        {
                            OdbcCommand cmd = new OdbcCommand();
                            cmd.Connection = GlobalVar.SysDbConn;

                            string insertSql = string.Format("Update  {0} set 是否售出 ='{1}',销售员 = '{2}',销售时间 = '{3}',装车人员 ='{4}' where 车辆ID ='{5}'", "车辆库存表", "是", brkSalePers, saleDate,bAssember, bID);
                            cmd.CommandText = insertSql;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();

                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show("入库失败，原因如下：" + ex.Message);
                        }

                    }
                    MessageBox.Show("入库成功！");
                }
            }
            else 
            {
                MessageBox.Show("数据库中不存在品牌名为" + bBrand +",车型为"+bType+",颜色为"+bColor+ "的库存车辆，请核实！");
                return;
            }

          

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

    }
}
