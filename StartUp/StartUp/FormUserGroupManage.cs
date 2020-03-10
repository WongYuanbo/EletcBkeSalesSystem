using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace EBike.SrartByGroup
{
    public partial class FormUserGroupManage : Form
    {
        private byte[] keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        //string userFile = GlobalPath.MainLicensePath + "\\user.dat";
        //string appSystemPath = GlobalPath.MainSystemPath + "\\SysTable.mdb";
        //2018-5-16王渊博修改——将appSystemPath设置为static类型，便于.GetUserDbConnection（）方法的引用
        static string appSystemPath = GlobalPath.DataPath + "\\SysTable.mdb";
        OdbcConnection odbcSysConn = GlobalUtility.GetUserDbConnection(appSystemPath); 

        Dictionary<string, string> user = new Dictionary<string, string>();
        public  List<string> userGroupList = new List<string>();
        private static string groupname = null;
        public static string GroupName
        {
            get
            {
                return groupname;
            }

            set
            {
                groupname = value;
            }
        }

        public FormUserGroupManage(string groupnamenow)
        {
            InitializeComponent();

            groupBox1.Location = new Point(12, 12);
            groupBox1.Visible = true;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Visible = false; 
            groupBox3.Location = new Point(12, 12);
            groupBox3.Visible = false;
            groupBox4.Location = new Point(12, 12);
            groupBox4.Visible = false;

            this.Size = new Size(400, 288);
            //GroupName = groupnamenow;
            btnPre.Enabled = false;
            btnNext.Enabled = true;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            
            getAllUserByGroup();
            if (userGroupList.Count==0)
            {
                radioBtn_Del.Enabled = false;
            }
            radioBtn_ModifyPWD.Enabled = true;
        }

        //方法：获取指定用户组的全部用户名和密码
        private void getAllUserByGroup()
        {
            userGroupList.Clear();
            user.Clear();
            //王渊博2018-12-11王渊博修改，获取包含“管理员”的用户表，便于后面进行修改“管理员"d的密码
            //string sql = string.Format("Select 用户组名称,密码 from SYS_用户组表 where 用户组名称<>'管理员'");
            string sql = string.Format("Select 用户组名称,密码 from SYS_用户组表 Where 1=1");
            //王渊博2018-5-16修改
           // System.Data.DataTable dt = GlobalUtility.GetDataTable(sql, GlobalUtility.GetUserDbConnection(appSystemPath));
            System.Data.DataTable dt = GlobalUtility.GetDataTable(sql, odbcSysConn);
            if (dt.Rows.Count > 0)
            {
                //string groupCode = dt.Rows[0][0].ToString();
                //sql = string.Format("Select * from SYS_用户表 where 用户组代码='{0}'", groupCode);
                //dt = GlobalUtility.GetDataTable(sql, GlobalUtility.GetUserDbConnection(appSystemPath));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    userGroupList.Add(dt.Rows[i]["用户组名称"].ToString());
                    //string keywords = dt.Rows[i]["用户名"].ToString() + dt.Rows[i]["用户密码"].ToString();
                    string keywords = dt.Rows[i]["密码"].ToString();
                    ////解密 用户名和用户密码都为暗文 组合解密后存放到 user dictoonry中
                    string inLnStr = DecryptDES(keywords, "mhppspwd");
                    string[] user_pwd = inLnStr.Split(new char[] { ',' });
                    user.Add(user_pwd[0], user_pwd[1]);

                }

            }

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            btnPre.Enabled = false;
            btnNext.Text = "下一步";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            btnPre.Enabled = true;

            if (btnNext.Text == "创建")
            {
                CreateUser(); 
                return;
            }
            else if (btnNext.Text == "删除")
            {
                DelUser();
                return;
            }
            else if (btnNext.Text == "修改")
            {
                ModifyUser();
                return;
            }

            if (radioBtn_New.Checked)
            {
                groupBox2.Visible = true;
                btnNext.Text = "创建";
                tBoxPWD_New.Enabled = true;
                tBoxPWDConfirm_New.Enabled = true;
            }
            else if (radioBtn_Del.Checked)
            {
                listBoxUser_Del.Items.Clear();
                getAllUserByGroup();
                foreach (string s in userGroupList)
                {
                    if (s == "管理员")
                    {
                        continue;
                    }
                    else
                    {

                        listBoxUser_Del.Items.Add(s);
                    }
                }
                tBoxPWD_Del.Enabled = true;
                groupBox3.Visible = true;
                btnNext.Text = "删除";
            }
            else if (radioBtn_ModifyPWD.Checked)
            {
                listBoxUser_Modi.Items.Clear();
               // Dictionary<string, string>.KeyCollection keyColl = user.Keys;
                getAllUserByGroup();
                foreach (string s in userGroupList)
                {
                    listBoxUser_Modi.Items.Add(s);
                }

                groupBox4.Visible = true;
                btnNext.Text = "修改";
            }

        }

        private void listBoxUser_Del_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxPWD_Del.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            
        }
        //获取用户组代码
        private string GetUserGroupCode(string userGroupName)
        {
            string code = "";
            string sql = string.Format("Select 用户组代码 from SYS_用户组表 where 用户组名称='{0}'", userGroupName);
           //2018-5-16王渊博修改
           // System.Data.DataTable dt = GlobalUtility.GetDataTable(sql, GlobalUtility.GetUserDbConnection(appSystemPath));
            System.Data.DataTable dt = GlobalUtility.GetDataTable(sql, odbcSysConn);
            code = dt.Rows[0][0].ToString();
            return code;
            
        }
        /// <summary>
        /// 新建用户时对系统数据库进行更新
        /// </summary>
        /// <param name="encryptString"></param>
        /// <param name="connection"></param>
        private void UpdateUserPwd(string encryptString,OdbcConnection connection)
        {
            //string userName = encryptString.Substring(0,2);
            //string pwd = encryptString.Substring(2);
            //string groupCode="";
            int maxCode = CreateMaxCode();

            //string sql = string.Format("insert into SYS_用户表 (用户组代码,用户名,用户密码) values ('{0}','{1}','{2}') ", GetUserGroupCode(GroupName), userName, pwd);
            string sql = string.Format("insert into SYS_用户组表 (用户组名称,用户组代码,密码) values ('{0}','{1}','{2}') ", tBoxUser.Text.Trim(), string.Format("{0:00}", maxCode), encryptString);
            OdbcCommand sysCommand = new OdbcCommand();
            sysCommand.Connection = connection;
            sysCommand.CommandText = sql;
            sysCommand.ExecuteNonQuery();
            sysCommand.Dispose();

        }
        /// <summary>
        ///修改用户密码时对系统数据库进行更新
        /// </summary>
        /// <param name="encryptString"></param>
        /// <param name="connection"></param>
        private void UpdateUserPwdChange(string encryptString,string userName,OdbcConnection connection )
        {
            
            //int maxCode = CreateMaxCode();

            try
            {
                //string sql = string.Format("insert into SYS_用户表 (用户组代码,用户名,用户密码) values ('{0}','{1}','{2}') ", GetUserGroupCode(GroupName), userName, pwd);
                string sql = string.Format("Update SYS_用户组表 Set 密码 = '{0}' where 用户组名称 = '{1}'", encryptString, userName);
                OdbcCommand sysCommand = new OdbcCommand();
                sysCommand.Connection = connection;
                sysCommand.CommandText = sql;
                sysCommand.ExecuteNonQuery();
                sysCommand.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  int CreateMaxCode()
        {
            string sql = string.Format("select max(val(用户组代码))+1 FROM SYS_用户组表");//查找在前缀为PrefixNum开头的管点编号中,去除PrefixNum长度后值最大的行
           //王渊博修改2018-5-16
            // System.Data.DataTable dt = GlobalUtility.GetDataTable(sql, GlobalUtility.GetUserDbConnection(appSystemPath));
            System.Data.DataTable dt = GlobalUtility.GetDataTable(sql, odbcSysConn);
            try
            {
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                throw;
            }
            //dt.Dispose();
        }
        //创建新用户
        private void CreateUser() 
        {
            //重新获取最新的用户名信息
            getAllUserByGroup();
            if (tBoxUser.Text.Trim() == "" || tBoxPWD_New.Text.Trim() == "")
            {
                MessageBox.Show("用户名和密码不能为空，请确认！");
                return;
            }

            if (userGroupList.Contains(tBoxUser.Text.Trim()))
            {
                MessageBox.Show("已经存在该用户，请指定其它用户名");
                return;
            }

            if (tBoxPWD_New.Text.Trim() == tBoxPWDConfirm_New.Text.Trim())
            {
                string outLnStr = tBoxUser.Text.Trim() + "," + tBoxPWD_New.Text.Trim();
                string outLine = EncryptDES(outLnStr, "mhppspwd");
                //StreamWriter sw = new StreamWriter(userFile, true);
                //sw.WriteLine(outLine);
                //sw.Close();
                UpdateUserPwd(outLine, GlobalUtility.GetUserDbConnection(appSystemPath));
                //2018-12-11王渊博修改
                //userGroupList.Add(tBoxUser.Text.Trim());
                //user.Add(tBoxUser.Text.Trim(), tBoxPWD_New.Text.Trim());
                //创建完成之后更新用户组
                getAllUserByGroup();
                MessageBox.Show("新用户创建完成。");
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入.");
            }
        }

        //删除用户
        private void DelUser()
        {
            if (listBoxUser_Del.SelectedItem == null)
            {
                MessageBox.Show("请选择要删除的用户.");
                return;
            }
            else
            {
                DialogResult dialogRt = MessageBox.Show("是否删除选中行？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogRt == System.Windows.Forms.DialogResult.Yes)
                {
                    string s = listBoxUser_Del.SelectedItem.ToString();
                    string code = GetUserGroupCode(s);
                    RemoveUserFromGroupTable(code, GlobalUtility.GetUserDbConnection(appSystemPath));
                    RemoveUserFromAuthorTable(code, GlobalUtility.GetUserDbConnection(appSystemPath));
                    //2018-12-11王渊博修改 ——创建完成之后更新用户组user 和userGroupList
                    //userGroupList.Remove(s);
                    getAllUserByGroup();
                    listBoxUser_Del.Items.Remove(s);
                    listBoxUser_Del.Refresh();
                    MessageBox.Show("删除用户完成");
                }
                else
                {
                    return;
                }
            }
            //string pwd = "";
            //if (user.TryGetValue(listBoxUser_Del.SelectedItem.ToString(), out pwd))
            //{
            //    if (pwd == tBoxPWD_Del.Text.Trim())
            //    {
            //        Dictionary<string, string>.KeyCollection keyColl = user.Keys;
            //        foreach (string s in keyColl)
            //        {
            //            if (s == listBoxUser_Del.SelectedItem.ToString())
            //            {
            //                string code = GetUserGroupCode(s);
            //                listBoxUser_Del.Items.Remove(s);
            //                user.Remove(s);
            //                RemoveUserFromAuthorTable(code, GlobalUtility.GetUserDbConnection(appSystemPath));
            //                break;
            //            }
            //        }

            //        //StreamWriter sw = new StreamWriter(userFile, false, Encoding.GetEncoding(936));
            //        //keyColl = user.Keys;
            //        //foreach (string s in keyColl)
            //        //{
            //        //    if (user.TryGetValue(s, out pwd))
            //        //    {
            //        //        string outLnStr = s + "," + pwd;
            //        //        string outLine = EncryptDES(outLnStr, "mhppspwd");
            //        //        sw.WriteLine(outLine);
            //        //    }
            //        //}
            //        //sw.Close();

            //        MessageBox.Show("删除用户完成");
            //    }
            //    else
            //    {
            //        MessageBox.Show("用户密码不正确，拒绝删除.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("系统异常，没有找到该用户名.");
            //}
        }
        private void RemoveUserFromAuthorTable(string groupcode, OdbcConnection connection)
        {
            string sql = string.Format("Delete * from SYS_用户组权限表  where 用户组代码='{0}' ",groupcode);
            OdbcCommand sysCommand = new OdbcCommand();
            sysCommand.Connection = connection;
            sysCommand.CommandText = sql;
            sysCommand.ExecuteNonQuery();
            sysCommand.Dispose();
        }

        private void RemoveUserFromGroupTable(string groupcode, OdbcConnection connection)
        {
            string sql = string.Format("Delete * from SYS_用户组表  where 用户组代码='{0}' ", groupcode);
            OdbcCommand sysCommand = new OdbcCommand();
            sysCommand.Connection = connection;
            sysCommand.CommandText = sql;
            sysCommand.ExecuteNonQuery();
            sysCommand.Dispose();
        }
        //修改用户密码
        private void ModifyUser()
        {
            if (listBoxUser_Modi.SelectedItem == null)
            {
                MessageBox.Show("请选择要修改密码的用户名.");
                return;
            }
            if (tBoxNewPWD_Modi.Text.Trim() == "")
            { 
                MessageBox.Show("新密码不能为空！");
                return;
            }
            string pwd = "";
            if (user.TryGetValue(listBoxUser_Modi.SelectedItem.ToString(), out pwd))
            {
                if (pwd == tBoxOldPWD_Modi.Text.Trim())
                {
                    //StreamWriter sw = new StreamWriter(userFile, false, Encoding.GetEncoding(936));
                    if (tBoxNewPWD_Modi.Text.Trim() == tBoxNewPWDConfirm_Modi.Text.Trim())
                    {
                        Dictionary<string, string>.KeyCollection keyColl = user.Keys;
                        foreach (string s in keyColl)
                        {
                            if (user.TryGetValue(s, out pwd))
                            {
                                if (s == listBoxUser_Modi.SelectedItem.ToString())
                                {
                                    pwd = tBoxNewPWD_Modi.Text.Trim();
                                    string outLnStr = s + "," + pwd;
                                    string outLine = EncryptDES(outLnStr, "mhppspwd");
                                    //sw.WriteLine(outLine);
                                    UpdateUserPwdChange(outLine, s, GlobalUtility.GetUserDbConnection(appSystemPath));
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次输入密码不一致，请确认！");
                        return;
                    }
                    
                    //sw.Close();

                    MessageBox.Show("用户密码修改完成");
                }
                else
                {
                    MessageBox.Show("用户密码不正确，拒绝修改.");
                }
            }
            else
            {
                MessageBox.Show("系统异常，没有找到该用户名.");
            }
            //2018-12-11王渊博修改 ——创建完成之后更新用户组user 和userGroupList
            getAllUserByGroup();
        }

        //事件：验证用户名或密码是否为空，或是否包含西文逗号
        private void tBox_Validating(object sender, CancelEventArgs e)
        {
            //TextBox tBox = (TextBox)sender;
            //if (tBox.Text.Trim() == "")
            //{
            //    MessageBox.Show("用户名或密码不允许为空");
            //    e.Cancel = true;
            //}
            //else if (tBox.Text.IndexOf(",") != -1)
            //{
            //    MessageBox.Show("用户名或密码不允许出现西文逗号\",\"");
            //    e.Cancel = true;
            //}
        }

        //加密
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
    }
}
