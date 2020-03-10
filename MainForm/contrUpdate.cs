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
    public partial class contrUpdate : UserControl
    {
        //private OdbcConnection odbcConn = new OdbcConnection();
        string bID = "";//车辆ID
        public contrUpdate()
        {
            InitializeComponent();
            //odbcConn = GlobalUtility.GetMainSysDbConnection();
            IniComBox();
        }
       
        private void IniComBox()
        {
            combBId.Items.Clear();
            string sqlType = string.Format("Select 车辆ID from 车辆库存表  order by 车辆ID  asc");
            System.Data.DataTable dtBId = GlobalUtility.GetDataTable(sqlType,GlobalVar.SysDbConn);
            if (dtBId.Rows.Count > 0)
            {
                for (int i = 0; i < dtBId.Rows.Count; i++)
                {
                    combBId.Items.Add(dtBId.Rows[i][0].ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           
            string bType="";//车型
            string bBrand ="";//品牌名
            string brkPers="";//入库人
            string saleOrNot = "";//是否售出
            string saler = "";//销售员


            string rkDate = "";//入库时间
            string saleDate = "";//销售时间
            if (combBId.Text.Trim() == "")
            {
                MessageBox.Show("车辆ID不能为空，请确认！");
                return;
            }
            else
            {
                bID = combBId.Text.Trim();
            }
            if (txtType.Text.Trim() == "")
            {
                MessageBox.Show("车型不能为空，请确认！");
                return;
            }
            else
            {
                bType = txtType.Text.Trim();
            }
            if (txtBrand.Text.Trim() == "")
            {
                MessageBox.Show("品牌名不能为空，请确认！");
                return;
            }
            else
            {
                bBrand = txtBrand.Text.Trim();
            }
            if (rkTime.Text.Trim() == "")
            {
                MessageBox.Show("入库时间不能为空，请确认！");
                return;
            }
            DateTime rkDateTim = new DateTime();
            if (DateTime.TryParse(rkTime.Text.Trim(), out rkDateTim))
            {
                rkDate = rkDateTim.ToShortDateString();
                
            }
            else
            {
                MessageBox.Show("入库时间不是标准的时间格式，请重新选择！");
                return;
            }
            if (txtRKPers.Text.Trim() == "")
            {
                MessageBox.Show("入库人不能为空，请确认！");
                return;
            }
            else
            {
                brkPers = txtRKPers.Text.Trim();
            }
            if (txtSaleOrNot.Text.Trim() != "是" && txtSaleOrNot.Text.Trim() != "否")
            {
                MessageBox.Show("是否售出不能为空，且只能填写是或否，请确认！");
                return;
            }
            else
            {
                saleOrNot = txtSaleOrNot.Text.Trim();
            }
            //如果是否售出为是，则需要判断相关字段是否为空
            if (txtSaleOrNot.Text.Trim() == "是")
            {
                if (txtSaler.Text.Trim() == "")
                {
                    MessageBox.Show("车辆售出后销售员不能为空，请确认！");
                    return;
                }
                else
                {
                    saler = txtSaler.Text.Trim();
                }
                DateTime salesDateTim = new DateTime();
                if (DateTime.TryParse(saleTime.Text.Trim(), out salesDateTim))
                {
                    saleDate = salesDateTim.ToShortDateString();

                }
                else
                {
                    MessageBox.Show("销售时间不是标准的时间格式，请重新选择！");
                    return;
                }
            }
            else
            {
                saler = "";
                saleDate = null;
             
            }
            string bNote = txtNote.Text.Trim();//备注

            try
            {
                OdbcCommand cmd = new OdbcCommand();
                cmd.Connection = GlobalVar.SysDbConn;

                string insertSql = string.Format("Update {0} set 车型 = '{1}',品牌名 ='{2}',入库时间 = '{3}',入库人 ='{4}',是否售出='{5}',销售员 = '{6}',销售时间 = '{7}',备注 ='{8}' Where 车辆ID ='{9}' ", "车辆库存表",
                                                                         bType, bBrand, rkDate, brkPers, saleOrNot, saler, saleDate, bNote, bID);
                cmd.CommandText = insertSql;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("修改成功！");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("修改失败，原因如下："+ex.Message);
            }
            

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void combBId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combBId.Text.Trim() == "")
            {
                MessageBox.Show("车辆ID不能为空，请确认！");
                return;
            }
            else
            {
                bID = combBId.Text.Trim();
            }
            //判定数据库中是否存在指定车联ID的记录
            string sqlSel = string.Format("Select * From 车辆库存表 Where 车辆ID = '{0}'", bID);
            System.Data.DataTable dtBId = GlobalUtility.GetDataTable(sqlSel,GlobalVar.SysDbConn);
            if (dtBId.Rows.Count > 0)
            {
                //初始化控件的值
                txtType.Text = dtBId.Rows[0]["车型"].ToString();
                txtBrand.Text = dtBId.Rows[0]["品牌名"].ToString();
                txtRKPers.Text = dtBId.Rows[0]["入库人"].ToString();
                txtSaleOrNot.Text = dtBId.Rows[0]["是否售出"].ToString();
                txtNote.Text = dtBId.Rows[0]["备注"].ToString();
                txtSaler.Text = dtBId.Rows[0]["销售员"].ToString();

                rkTime.Value = DateTime.Parse(dtBId.Rows[0]["入库时间"].ToString());
                if (dtBId.Rows[0]["是否售出"].ToString().Trim() == "是")
                {
                    saleTime.Value = DateTime.Parse(dtBId.Rows[0]["销售时间"].ToString());
                }
                else if (dtBId.Rows[0]["是否售出"].ToString().Trim() == "否")
                {
                    saleTime.Value = DateTime.Now;
                }
            }
            else
            {
                MessageBox.Show("数据库中不存在车辆ID为" + bID + "的记录，请核实！");
                return;
            }



        }



    }
}
