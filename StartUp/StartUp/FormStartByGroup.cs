using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text.RegularExpressions;
using System.Management;
using System.IO;
using System.Security.Cryptography;


namespace EBike.SrartByGroup
{
    public partial class FormStartByGroup : Form
    {
        private bool cadHasOpened = false;
        private byte[] keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        Dictionary<string, string> user = new Dictionary<string, string>();//Dictionary的用法
        Dictionary<string, string> manager = new Dictionary<string, string>();
        string systemPath = GlobalPath.MainPath + "\\System";
        List<string[]> listGroupAuthor = new List<string[]>();
        string nowGroup = "";
        //王渊博20190929添加
        OdbcConnection connSys = new OdbcConnection();

        //List<List<string>> listTool = new List<List<string>>();
        public FormStartByGroup()
        {
            //初始化路径
            GlobalPath.MainPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            InitializeComponent();
            //IsRegistedDog();//硬件狗环境查询
            //获取用户组
            getALlGroup();
        }

        //方法：获取全部用户类型
        private void getALlGroup()
        {
            string nowUser = "";
            int nowUserIdex = 0;
            systemPath =GlobalPath.MainPath + "\\System";
            //string sql = string.Format("Select 用户组名称,当前用户 from SYS_用户组表 order by ID asc");
            string sql = string.Format("Select 用户组名称,默认用户 from SYS_用户组表 order by ID asc");
            System.Data.DataTable dt = GlobalUtility.GetDataTable(sql, GlobalUtility.GetUserDbConnection(systemPath + @"\SysTable.mdb"));
            comboGroup.Items.Clear();
            user.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboGroup.Items.Add(dt.Rows[i][0].ToString());
                if (dt.Rows[i][1].ToString()=="Y")
                {
                    nowUser = dt.Rows[i][0].ToString();
                    nowUserIdex = i;
                }
            }
            if (comboGroup.Items.Count > 0)
            {
                comboGroup.SelectedIndex = 0;
                // 
                if (nowUser!="")
                {
                    comboGroup.SelectedIndex = nowUserIdex;
                }
                
            }
            if (comboGroup.Text!="管理员")
            {
                this.btnUserMgd.Visible = false;
            }
            else
            {
                this.btnUserMgd.Visible = true;
            }
           
        }
        //获取用户组代码
        private string GetGroupCodeByName(string Name)
        {
            string code = "";
            string sql = string.Format("Select * from SYS_用户组表 where 用户组名称='{0}'", Name);
            DataTable dtAuthor = GlobalUtility.GetDataTable(sql, GlobalUtility.GetUserDbConnection(systemPath + @"\SysTable.mdb"));
            if (dtAuthor.Rows.Count > 0)
            {
                code = dtAuthor.Rows[0]["用户组代码"].ToString();

            }
            else
            {
                MessageBox.Show("用户组未分配代码！");
            }
            return code;

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //登录  按照自定义的界面进入软件应用，在这里，需要做的限制是除过管理员，用户管理菜单不出现在其他用户应用中--暂定
            //记录默认用户
            try
            {
                string appPath = GlobalPath.MainPath;                
                //20181211王渊博添加，判断用户的密码是否正确
                if (ConfigPassWord(comboGroup.Text, txtPassword.Text))
                {
                    GlobalVar.SysDbConn = GlobalUtility.GetUserDbConnection(systemPath + @"\SysTable.mdb");
                    //更新默认用户
                    if (cekBoxSetNowUser.Checked == true)
                    {

                        OdbcCommand dbCommand = new OdbcCommand();
                        //dbCommand.Connection = GlobalUtility.GetUserDbConnection(systemPath + @"\SysTable.mdb");
                        dbCommand.Connection = GlobalVar.SysDbConn;
                        //string sqlUp = string.Format("update SYS_用户组表 set 当前用户=''");
                        string sqlUp = string.Format("update SYS_用户组表 set 默认用户=''");
                        dbCommand.CommandText = sqlUp;
                        dbCommand.ExecuteNonQuery();
                        sqlUp = string.Format("update SYS_用户组表 set 默认用户='Y' where 用户组名称='{0}'", comboGroup.Text);
                        dbCommand.CommandText = sqlUp;
                        dbCommand.ExecuteNonQuery();
                        dbCommand.Dispose();
                        nowGroup = comboGroup.Text;
                    }
                    //更新当前用户
                    OdbcCommand dbCommand1 = new OdbcCommand();
                    //dbCommand1.Connection = GlobalUtility.GetUserDbConnection(systemPath + @"\SysTable.mdb");
                    dbCommand1.Connection = GlobalVar.SysDbConn;
                    string sqlUp1 = string.Format("update SYS_用户组表 set 当前用户=''");
                    dbCommand1.CommandText = sqlUp1;
                    dbCommand1.ExecuteNonQuery();
                    sqlUp1 = string.Format("update SYS_用户组表 set 当前用户='Y' where 用户组名称='{0}'", comboGroup.Text);
                    dbCommand1.CommandText = sqlUp1;
                    dbCommand1.ExecuteNonQuery();
                    dbCommand1.Dispose();

                    btnOk.Enabled = false;//防止用户多次触发该事件
                    btnCancel.Enabled = false;

                    //打开主窗体
                    //this.Close();
                    //this.Dispose();
                    this.Hide();
                    EBike.MainForm.FormMainView frmMain = new MainForm.FormMainView();
                    frmMain.Show();
                   
                }
                else
                {
                    MessageBox.Show("用户名或密码有误，请确认后重新输入！");
                    return;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// 验证指定用户名的输入密码是否与数据库中一致
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        private bool ConfigPassWord(string userGroupName, string passWord)
        {
            bool config = false;
            string outLnStr = userGroupName.Trim() + "," + passWord.Trim();
            string passWordEncrypted = "";//加密过的密码
            try
            {
                systemPath = GlobalPath.MainPath + "\\System";
                string sql = string.Format("Select 用户组名称,密码 from SYS_用户组表 Where 用户组名称 = '{0}'", userGroupName);
                System.Data.DataTable dtUserGrop = GlobalUtility.GetDataTable(sql, GlobalUtility.GetUserDbConnection(systemPath + @"\SysTable.mdb"));
                if (dtUserGrop.Rows.Count > 0)
                {
                    passWordEncrypted = EncryptDES(outLnStr, "mhppspwd");
                    if (passWordEncrypted == dtUserGrop.Rows[0]["密码"].ToString().Trim())
                    {
                        config = true;
                    }
                }
                else
                {
                    MessageBox.Show("当前用户名不存在，请确认！");
                    return config;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("密码确认发生异常：" + ex.Message);
                return config;
            }

            return config;
        }
        //密码加密加密
        private string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                if (encryptKey.Length > 8) encryptKey = encryptKey.Substring(0, 8);

                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey);
                byte[] rgbIV = keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch (System.Exception ex)
            {
                return encryptString;
            }
        }

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            if (comboGroup.Text != "管理员")
            {
          
                this.btnUserMgd.Visible = false;
            }
            else
            {

                this.btnUserMgd.Visible = true;
            }

        }

        private void btnUserMgd_Click(object sender, EventArgs e)
        {
        
            if (ConfigPassWord(comboGroup.Text, txtPassword.Text))
            {
                FormUserGroupManage frm = new FormUserGroupManage(comboGroup.Text);
                frm.ShowDialog(this);
                //frm.ShowDialog();
                getALlGroup();
            }
            else
            {
                MessageBox.Show("管理员密码错误，请重新输入！");
            }
            
        }
        //读取管理员文件 解密 对输入进行判断 --manager.dat

        //管理员认证  用户管理及 权限管理需要进行管理员认证
        private bool HasManagement(string manageName,string pwd)
        {
            bool hasManagement = true;
            //读取管理员文件 解密 对输入进行判断 --manager.dat

            string userFile = GlobalPath.MainLicensePath + @"\\manager.dat";
            if (!File.Exists(userFile))
            {
                MessageBox.Show("管理员文件缺失！");
                hasManagement = false;
            }
            manager.Clear();
            //读取并解密用户名/密码数据
            StreamReader sr = new StreamReader(userFile);

            while (sr.Peek() >= 0)
            {
                string inLine = sr.ReadLine();
                string inLnStr = DecryptDES(inLine, "mhppspwd");
                string[] user_pwd = inLnStr.Split(new char[] { ',' });
                   manager.Add(user_pwd[0], user_pwd[1]);
            }
            sr.Close();

            if (!manager.TryGetValue(manageName, out pwd))
            {
                MessageBox.Show("用户名称不正确.");
                hasManagement = false;
            }
            else
            {
                if (pwd != txtPassword.Text)
                {
                    MessageBox.Show("密码不正确.");
                    hasManagement = false;
                }
            }
            return hasManagement;            
        }
        //解密
        private string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                if (decryptKey.Length > 8) decryptKey = decryptKey.Substring(0, 8);

                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }
 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }   
        
    }
}
