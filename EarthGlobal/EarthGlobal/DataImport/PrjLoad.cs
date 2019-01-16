using SuperMap.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EarthGlobal.DataImport
{
    public class PrjLoad
    {
        private Workspace m_workspace;
        private WorkspaceConnectionInfo m_connectionInfo;
        private Datasource m_datasource;
        public Workspace Workspace
        {
            get { return this.m_workspace; }
            set { this.m_workspace = value; }
        }
        public Datasource Datasource
        {
            get { return this.m_datasource; }
            set { this.m_datasource = value; }
        }
        public PrjLoad()
        {
            m_workspace = new Workspace();
            m_connectionInfo = new WorkspaceConnectionInfo();
        }
        /// <summary>
        /// 加载默认的工作空间
        /// </summary>
        internal void DefaultPrjLoad()
        {
            
            m_connectionInfo.Version = WorkspaceVersion.UGC60;
            m_connectionInfo.Type = WorkspaceType.SMWU;
            m_connectionInfo.Server = $"{AppDomain.CurrentDomain.BaseDirectory}\\Default.smwu";
            m_connectionInfo.Name = "Default";
            m_workspace.Create(m_connectionInfo);
            DatasourceConnectionInfo datasourceConInfo = new DatasourceConnectionInfo();
            datasourceConInfo.Server = $"{AppDomain.CurrentDomain.BaseDirectory}\\Default.udb";
            datasourceConInfo.Alias = "Default";
            m_workspace.Datasources.CloseAll();
            if (System.IO.File.Exists("Default.udb"))
                m_datasource = m_workspace.Datasources.Open(datasourceConInfo);
            else
                m_datasource = m_workspace.Datasources.Create(datasourceConInfo);
            UCEarthGlobal.m_MainSceneControl.Scene.Workspace = m_workspace;
        }
        public void LoadPrj(string _prjFilePath)
        {

        }
    }
}
