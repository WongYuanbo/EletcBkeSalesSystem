using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Data.Odbc;

namespace EBike
{
    public static class GlobalUtility
    {   /// <summary>
        /// 方法：获取系统表的数据连接
        /// </summary>
        /// <returns></returns>
        public static  OdbcConnection GetMainSysDbConnection()
        {
           OdbcConnection odbcConn = new OdbcConnection();
            odbcConn.Dispose();
            try
            {
                string file = GlobalPath.DataPath + @"\SysTable.mdb";
                if (GetOSBit() == 32)
                {
                    odbcConn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb)};DBQ=" + file; //32位操作系统
                }
                else if (GetOSBit() == 64)
                {
                    odbcConn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" + file; //64位操作系统
                }
                odbcConn.Close();
                if (odbcConn.State == System.Data.ConnectionState.Closed)
                {
                    odbcConn.Open();
                }
            }
            catch (SystemException ex)
            {
                throw new SystemException(ex.Message);
            }

            return odbcConn;
        }
        /// <summary>
        /// 获取操作系统位数（x32/64）
        /// </summary>
        /// <returns>int</returns>
        public static int GetOSBit()
        {
            try
            {
                string addressWidth = String.Empty;
                ConnectionOptions mConnOption = new ConnectionOptions();
                ManagementScope mMs = new ManagementScope(@"\\localhost", mConnOption);
                ObjectQuery mQuery = new ObjectQuery("select AddressWidth from Win32_Processor");
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(mMs, mQuery);
                ManagementObjectCollection mObjectCollection = mSearcher.Get();
                foreach (ManagementObject mObject in mObjectCollection)
                {
                    addressWidth = mObject["AddressWidth"].ToString();
                }
                return Int32.Parse(addressWidth);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 32;
            }

        }
        //获取数据库
        public static System.Data.DataTable GetDataTable(string sqlStr, OdbcConnection odbcConn)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            OdbcCommand odbcCmd = new OdbcCommand();
            OdbcDataAdapter odbcDA = new OdbcDataAdapter();
            try
            {
                odbcCmd = new OdbcCommand();
                odbcCmd.Connection = odbcConn;
                odbcCmd.CommandText = sqlStr;
                odbcDA = new OdbcDataAdapter(odbcCmd);

                //odbcDA.FillSchema(dt, SchemaType.Mapped);
                odbcDA.Fill(dt);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(string.Format("获取表时出现异常。\n{0}。\n系统错误信息：{1}", sqlStr, ex.Message));
            }

            odbcCmd.Dispose();
            odbcDA.Dispose();

            return dt;
        }
        /// <summary>
        /// 方法：获取系统用户表的数据连接
        /// </summary>
        /// <param name="mdbFile">用户数据库</param>
        /// <returns></returns>
        public static OdbcConnection GetUserDbConnection(string mdbFile)
        {
            OdbcConnection odbcConn = new OdbcConnection();
            try
            {
                if (GetOSBit() == 32)
                {
                    odbcConn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb)};DBQ=" + mdbFile; //32位操作系统
                }
                else if (GetOSBit() == 64)
                {
                    odbcConn.ConnectionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" + mdbFile; //64位操作系统
                }

                odbcConn.Open();
            }

            catch (SystemException ex)
            {
                throw new SystemException(ex.Message);
            }

            return odbcConn;
        }
    }
}
