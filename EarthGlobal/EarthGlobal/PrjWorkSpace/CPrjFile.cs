using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EarthGlobal.PrjWorkSpace
{
    [Serializable]
    public class CPrjInfo
    {
        private string m_PrjPath;
        public string PrjPath
        {
            get
            {
                return m_PrjPath;
            }

            set
            {
                m_PrjPath = value;
            }
        }
        /// <summary>
        /// smwu工作空间路径
        /// </summary>
        private string m_WorkspacePath;

        public string WorkspacePath
        {
            get
            {
                return m_WorkspacePath;
            }

            set
            {
                m_WorkspacePath = value;
            }
        }
        private string m_WorkspaceName;
        public string WorkspaceName
        {
            get
            {
                return m_WorkspaceName;
            }

            set
            {
                m_WorkspaceName = value;
            }
        }
        private string m_DataSourceName;
        public string DataSourceName
        {
            get {
                return this.m_DataSourceName;
            }
            set
            {
                this.m_DataSourceName = value;
            }
        }

        private string m_DataSourceFilePath;
        public string DataSourceFilePath
        {
            get
            {
                return this.m_DataSourceFilePath;
            }
            set
            {
                this.m_DataSourceFilePath = value;
            }
        }




    }
}
