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
    public partial class contrAddSingle : UserControl
    {
        //private OdbcConnection odbcConn = new OdbcConnection();
        public contrAddSingle()
        {
            InitializeComponent();
            //odbcConn = GlobalUtility.GetMainSysDbConnection();
            IniComBox();
        }
       
        private void IniComBox()
        {
            combType.Items.Clear();
            combBrand.Items.Clear();
            combPerson.Items.Clear();
            string sqlType = string.Format("Select 车型 from TC_车型 order by 车型 asc");
            System.Data.DataTable dtType = GlobalUtility.GetDataTable(sqlType, GlobalVar.SysDbConn);
            if (dtType.Rows.Count > 0)
            {
                for (int i = 0; i < dtType.Rows.Count; i++)
                {
                    combType.Items.Add(dtType.Rows[i][0].ToString());
                }
            }
            string sqlBrand = string.Format("Select 品牌名 from TC_品牌 order by 品牌名 asc");
            System.Data.DataTable dtBrand = GlobalUtility.GetDataTable(sqlBrand, GlobalVar.SysDbConn);
            if (dtBrand.Rows.Count > 0)
            {
                for (int i = 0; i < dtBrand.Rows.Count; i++)
                {
                    combBrand.Items.Add(dtBrand.Rows[i][0].ToString());
                }
            }
            string sqlPers = string.Format("Select 入库人 from TC_入库人 order by 入库人 asc");
            System.Data.DataTable dtPerS = GlobalUtility.GetDataTable(sqlPers, GlobalVar.SysDbConn);
            if (dtPerS.Rows.Count > 0)
            {
                for (int i = 0; i < dtPerS.Rows.Count; i++)
                {
                    combPerson.Items.Add(dtPerS.Rows[i][0].ToString());
                }
            }
            string sqlColor = string.Format("Select 颜色 from TC_颜色 order by 颜色 asc");
            //System.Data.DataTable dtColor = GlobalUtility.GetDataTable(sqlColor, odbcConn);
            System.Data.DataTable dtColor = GlobalUtility.GetDataTable(sqlColor,GlobalVar.SysDbConn);
            if (dtColor.Rows.Count > 0)
            {
                for (int i = 0; i < dtColor.Rows.Count; i++)
                {
                    comColor.Items.Add(dtColor.Rows[i][0].ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string rkDate = "";//入库时间
            string bColor= "";//车辆颜色
            string bType="";//车型
            string bBrand ="";//品牌名
            string brkPers="";//入库人
            double cost = 0;//成本
            double reWord = 0;//提成
            int num = 0;//数量
            if (txtCost.Text.Trim() == "")
            {
                MessageBox.Show("成本不能为空，请确认！");
                return;
            }
            else 
            {
                if (double.TryParse(txtCost.Text.Trim(), out cost))
                {

                }
                else
                {
                    MessageBox.Show("成本必须为数字，请确认！");
                    return;
                } 
            }
            if (txtRewrad.Text.Trim() == "")
            {
                MessageBox.Show("提成不能为空，请确认！");
                return;
            }
            else
            {
                if (double.TryParse(txtRewrad.Text.Trim(), out reWord))
                {

                }
                else
                {
                    MessageBox.Show("提成必须为数字，请确认！");
                    return;
                }
            }
            if (txtNum.Text.Trim() == "")
            {
                MessageBox.Show("数量不能为空，请确认！");
                return;
            }
            else
            {
                if (int.TryParse(txtNum.Text.Trim(), out num))
                {

                }
                else
                {
                    MessageBox.Show("数量必须为整数，请确认！");
                    return;
                }
            }
            if (comColor.Text.Trim() == "")
            {
                MessageBox.Show("颜色不能为空，请确认！");
                return;
            }
            else
            {
                bColor = comColor.Text.Trim();
            }
            if (combType.Text.Trim() == "")
            {
                MessageBox.Show("车型不能为空，请确认！");
                return;
            }
            else
            {
             bType = combType.Text.Trim();
            }
            if (combBrand.Text.Trim() == "")
            {
                MessageBox.Show("品牌名不能为空，请确认！");
                return;
            }
            else
            {
            bBrand =combBrand.Text.Trim();
            }
            if (txtDate.Text.Trim() == "")
            {
                MessageBox.Show("入库时间不能为空，请确认！");
                return;
            }
            DateTime rkDateTim = new DateTime();
            if(DateTime.TryParse(txtDate.Text.Trim(),out rkDateTim))
            {
                rkDate = rkDateTim.ToShortDateString();
                
            }
            else
            {
                MessageBox.Show("入库时间不是标准的时间格式，请重新选择！");
                return;
            }
            if (combPerson.Text.Trim() == "")
            {
                MessageBox.Show("入库人不能为空，请确认！");
                return;
            }
            else
            {
              brkPers =combPerson.Text.Trim();
            }
            string bNote = txtNote.Text.Trim();//备注
            
            try
            {
                OdbcCommand cmd = new OdbcCommand();
                for (int i = 0; i < num; i++)
                {
                    cmd.Connection = GlobalVar.SysDbConn;
                    Guid bID = System.Guid.NewGuid();
                    string insertSql = string.Format("Insert into {0} (车辆ID,品牌名,车型,颜色,成本,提成,入库人,入库时间,是否售出,备注) Values ('{1}','{2}','{3}','{4}',{5},{6},'{7}','{8}','{9}','{10}')", "车辆库存表", bID, bBrand,bType,bColor,cost,reWord,brkPers,rkDate,  "否", bNote);
                    cmd.CommandText = insertSql;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                
                MessageBox.Show("入库成功！");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("入库失败，原因如下："+ex.Message);
            }
           

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }
        
    }
}
