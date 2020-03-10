using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace EBike
{
    public static class GlobalVar
    {
        //系统数据库连接
        private static OdbcConnection sysDbConn = null;
        public static OdbcConnection SysDbConn
        {
            get { return sysDbConn; }
            set { sysDbConn = value; }
        }
    }
}


