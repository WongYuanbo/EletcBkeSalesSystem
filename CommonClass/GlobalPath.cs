using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBike
{
    public static class GlobalPath
    {
        private static string mainPath = null;

        //MainPath
        public static string MainPath
        {
            get
            {
                return mainPath;
            }

            set
            {
                mainPath = value;
                mainPath = mainPath.Substring(0, mainPath.LastIndexOfAny("\\".ToCharArray()));
            }
        }
        #region 系统路径
        public static string DataPath
        {
            get
            {
                return mainPath + "\\System";
            }
        }
        public static string DataPathAndName
        {
            get
            {
                return mainPath + "\\System"+ @"\SysTable.mdb";;
            }
        }
        public static string MainLicensePath
        {
            get
            {
                return mainPath + "\\License";
            }
        }
        #endregion
    }
}


