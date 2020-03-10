using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EBike.MainForm
{
    public partial class FormMainView : Form
    {
        public FormMainView()
        {
            InitializeComponent();
        }
        private void FormMainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
            string procName = "电动车销售管理系统V1.0";
            KillProc(procName);
        }
        //private void FormMainView_Load(object sender, EventArgs e)
        //{
        //    this.Owner.Hide();
        //}
        //private void FormMainView_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    //Application.Exit()
        //    //Application.ExitThread();
        //    System.Environment.Exit(0);
        //    string procName = "电动车销售管理系统V1.0";
        //    KillProc(procName);
        //}
        /// 根据“精确进程名”结束进程
        /// </summary>
        /// <param name="strProcName">精确进程名</param>
        public void KillProc(string strProcName)
        {
            try
            {
                //精确进程名  用GetProcessesByName
                foreach (Process p in Process.GetProcessesByName(strProcName))
                {
                    if (!p.CloseMainWindow())
                    {
                        p.Kill();
                    }
                }
            }
            catch
            {

            }
        }
        private void 车辆入库ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            contrAddSingle contrAdd = new contrAddSingle();
            contrAdd.Size = this.panel1.Size;
            this.panel1.Controls.Add(contrAdd);

        }
        private void 单条件查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            contrSelectSingle contrSelect = new contrSelectSingle();
            contrSelect.Size = this.panel1.Size;
            this.panel1.Controls.Add(contrSelect);
        }
        private void 按车辆属性入库ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            contrSales contrSale = new contrSales();
            contrSale.Size = this.panel1.Size;
            this.panel1.Controls.Add(contrSale);
        }

        private void 单条件统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            StaticSales contrStaticSale = new StaticSales();
            contrStaticSale.Size = this.panel1.Size;
            this.panel1.Controls.Add(contrStaticSale);
        }
        private void 按车辆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            contrUpdate contrUpdate = new contrUpdate();
            contrUpdate.Size = this.panel1.Size;
            this.panel1.Controls.Add(contrUpdate);
        }

        private void 按条件删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            contrDeleteSingle ContrDelete = new contrDeleteSingle();
            ContrDelete.Size = this.panel1.Size;
            this.panel1.Controls.Add(ContrDelete);
        }


   

   
    }
}
