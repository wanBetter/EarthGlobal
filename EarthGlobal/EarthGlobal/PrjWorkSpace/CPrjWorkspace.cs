using SuperMap.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace EarthGlobal.PrjWorkSpace
{
    public class CPrjWorkspace
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
        public CPrjWorkspace()
        {
            m_workspace = new Workspace();
            m_connectionInfo = new WorkspaceConnectionInfo();
        }
        private CPrjInfo m_PrjInfo;
        public CPrjInfo PrjInfo
        {
            get {
                return this.m_PrjInfo;
            }
            set {
                this.m_PrjInfo = value;
            }
        }
        #region 加载工作空间
        internal void DefaultPrjLoad()
        {
            m_PrjInfo = new CPrjInfo();
            //主动读取配置文件
            System.Environment.CurrentDirectory = System.Windows.Forms.Application.StartupPath;
            string cfgPath = Application.StartupPath + @"\OrgData\Default.cfg";
            //反序列化
            try
            {
                //用于序列化和反序列化的对象
                IFormatter serializer = new BinaryFormatter();
                FileStream loadFile = new FileStream(cfgPath, FileMode.OpenOrCreate, FileAccess.Read);
                CPrjInfo prjInfo = serializer.Deserialize(loadFile) as CPrjInfo;
                //值拷贝
                foreach (PropertyInfo proInfo in prjInfo.GetType().GetProperties())
                {
                    proInfo.SetValue(m_PrjInfo, proInfo.GetValue(prjInfo));
                }
            }
            catch (Exception e)
            {

            }
            m_connectionInfo.Version = WorkspaceVersion.UGC60;
            m_connectionInfo.Type = WorkspaceType.SMWU;
            m_connectionInfo.Server =$"{m_PrjInfo.WorkspacePath}\\{m_PrjInfo.WorkspaceName}.smwu" ;
            m_connectionInfo.Name = m_PrjInfo.WorkspaceName;
            m_workspace.Create(m_connectionInfo);
            DatasourceConnectionInfo datasourceConInfo = new DatasourceConnectionInfo();
            datasourceConInfo.Server = $"{m_PrjInfo.WorkspacePath}\\{m_PrjInfo.DataSourceName}.udd";
            datasourceConInfo.Alias = m_PrjInfo.DataSourceName;
            m_workspace.Datasources.CloseAll();
            if (System.IO.File.Exists(m_PrjInfo.WorkspacePath))
                m_datasource = m_workspace.Datasources.Open(datasourceConInfo);
            else
                m_datasource = m_workspace.Datasources.Create(datasourceConInfo);
            UCEarthGlobal.m_MainSceneControl.Scene.Workspace = m_workspace;
        }
        public void LoadPrj(string _prjFilePath)
        {
            m_PrjInfo = new CPrjInfo();
            m_workspace.Save();
            //主动读取配置文件
            System.Environment.CurrentDirectory = System.Windows.Forms.Application.StartupPath;
            string cfgPath = _prjFilePath;
            //反序列化
            try
            {
                //用于序列化和反序列化的对象
                IFormatter serializer = new BinaryFormatter();
                FileStream loadFile = new FileStream(cfgPath, FileMode.OpenOrCreate, FileAccess.Read);
                CPrjInfo prjInfo = serializer.Deserialize(loadFile) as CPrjInfo;
                //值拷贝
                foreach (PropertyInfo proInfo in prjInfo.GetType().GetProperties())
                {
                    proInfo.SetValue(m_PrjInfo, proInfo.GetValue(prjInfo));
                }
            }
            catch (Exception e)
            {

            }
            m_connectionInfo.Version = WorkspaceVersion.UGC60;
            m_connectionInfo.Type = WorkspaceType.SMWU;
            m_connectionInfo.Server = $"{m_PrjInfo.WorkspacePath}\\{m_PrjInfo.WorkspaceName}.smwu";
            m_connectionInfo.Name = m_PrjInfo.WorkspaceName;
            m_workspace.Create(m_connectionInfo);
            DatasourceConnectionInfo datasourceConInfo = new DatasourceConnectionInfo();
            datasourceConInfo.Server = $"{m_PrjInfo.DataSourceFilePath}\\{m_PrjInfo.DataSourceName}.udd";
            datasourceConInfo.Alias = m_PrjInfo.DataSourceName;
            m_workspace.Datasources.CloseAll();
            if (System.IO.File.Exists(m_PrjInfo.DataSourceName))
                m_datasource = m_workspace.Datasources.Open(datasourceConInfo);
            else
                m_datasource = m_workspace.Datasources.Create(datasourceConInfo);
            UCEarthGlobal.m_MainSceneControl.Scene.Workspace = m_workspace;
        }

        #endregion
        #region 保存工作空间

        public void SaveAsPrj(string _prjFilePath)
        {
            m_PrjInfo.PrjPath = _prjFilePath;
            SaveAs(_prjFilePath);
        }
        public void SavePrj()
        {
            Save();
        }
        
        public void CreateNewPrj(string _prjFullPath)
        {
            m_PrjInfo = new CPrjInfo { PrjPath= _prjFullPath,
                WorkspacePath = Path.GetDirectoryName(_prjFullPath),
                WorkspaceName = Path.GetFileNameWithoutExtension(_prjFullPath),
            DataSourceFilePath= Path.GetDirectoryName(_prjFullPath),
            DataSourceName= Path.GetFileNameWithoutExtension(_prjFullPath)
            };
            m_connectionInfo.Version = WorkspaceVersion.UGC60;
            m_connectionInfo.Type = WorkspaceType.SMWU;
            m_connectionInfo.Server = $"{m_PrjInfo.WorkspacePath}\\{m_PrjInfo.WorkspaceName}.smwu";
            m_connectionInfo.Name = m_PrjInfo.WorkspaceName;
            m_workspace.Create(m_connectionInfo);

            DatasourceConnectionInfo datasourceConInfo = new DatasourceConnectionInfo();
            datasourceConInfo.Server = $"{m_PrjInfo.DataSourceFilePath}\\{m_PrjInfo.DataSourceName}.udd";
            datasourceConInfo.Alias = m_PrjInfo.DataSourceName;
            m_workspace.Datasources.CloseAll();
            if (System.IO.File.Exists(m_PrjInfo.DataSourceName))
                m_datasource = m_workspace.Datasources.Open(datasourceConInfo);
            else
                m_datasource = m_workspace.Datasources.Create(datasourceConInfo);
            UCEarthGlobal.m_MainSceneControl.Scene.Workspace = m_workspace;
            SaveAsPrj(_prjFullPath);
        }
        #endregion
        #region 序列化帮助类
        private void Save()
        {
            FileStream saveFile = null;
            //用于序列化和反序列化的对象
            IFormatter serializer = new BinaryFormatter();
            string cfgPath = m_PrjInfo.PrjPath;
            try
            {
                saveFile = new FileStream(cfgPath, FileMode.Create, FileAccess.Write);
                serializer.Serialize(saveFile, this);
            }
            catch
            {
            }
            finally
            {
                if (saveFile != null)
                {
                    try
                    {
                        saveFile.Close();
                    }
                    catch { }
                }
            }
        }
        private void SaveAs(string _prjFile)
        {
            FileStream saveFile = null;
            //用于序列化和反序列化的对象
            IFormatter serializer = new BinaryFormatter();
            string cfgPath = _prjFile;
            try
            {
                saveFile = new FileStream(cfgPath, FileMode.Create, FileAccess.Write);
                serializer.Serialize(saveFile, this);
            }
            catch
            {
            }
            finally
            {
                if (saveFile != null)
                {
                    try
                    {
                        saveFile.Close();
                    }
                    catch { }
                }
            }
        }
        #endregion
    }
}
