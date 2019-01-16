
using SuperMap.Data;
using SuperMap.Data.Conversion;
using SuperMap.Realspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EarthGlobal.DataImport
{
    public class CDataImport
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
        public CDataImport()
        {
            m_workspace = new Workspace();
            m_connectionInfo = new WorkspaceConnectionInfo();
        }
        #region 加载工作空间
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
        #endregion

        #region 加载DEM
        public void LoadDem(string _demFilePath)
        {
            SuperMap.Data.Conversion.DataImport m_dataImport = new SuperMap.Data.Conversion.DataImport();
            //导入dem
            m_dataImport.ImportSettings.Clear();
            ImportSettingIMG imgSetting = new ImportSettingIMG();
            imgSetting.ImportMode = ImportMode.Overwrite;
            imgSetting.SourceFilePath = _demFilePath;
            imgSetting.TargetDatasource = UCEarthGlobal.m_MainSceneControl.Scene.Workspace.Datasources["Default"];
            imgSetting.MultiBandImportMode = MultiBandImportMode.SingleBand;
            imgSetting.ImportingAsGrid = true;

            m_dataImport.ImportSettings.Add(imgSetting);
            m_dataImport.Run();

            DatasetGrid importResult = UCEarthGlobal.m_MainSceneControl.Scene.Workspace.Datasources["Default"].Datasets[0] as DatasetGrid;
            TerrainLayer terrainLayer = UCEarthGlobal.m_MainSceneControl.Scene.TerrainLayers.Add(importResult, true);
            UCEarthGlobal.m_MainSceneControl.Scene.Fly(new Camera { Latitude = terrainLayer.Bounds.Center.X, Longitude = terrainLayer.Bounds.Center.Y, Altitude = 10 });
        }
        #endregion

        #region 加载Ddom
        public void LoadDom(string _domFilePath)
        {
            SuperMap.Data.Conversion.DataImport m_dataImport = new SuperMap.Data.Conversion.DataImport();
            m_dataImport.ImportSettings.Clear();
            ImportSettingIMG imgSetting1 = new ImportSettingIMG();

            imgSetting1.ImportMode = ImportMode.Overwrite;
            imgSetting1.SourceFilePath = _domFilePath;
            imgSetting1.TargetDatasource = UCEarthGlobal.m_MainSceneControl.Scene.Workspace.Datasources["Default"];
            imgSetting1.MultiBandImportMode = MultiBandImportMode.MultiBand;
            imgSetting1.ImportingAsGrid = false;

            m_dataImport.ImportSettings.Add(imgSetting1);
            m_dataImport.Run();
            DatasetImage importResult1 = UCEarthGlobal.m_MainSceneControl.Scene.Workspace.Datasources["Default"].Datasets[1] as DatasetImage;
        }
        #endregion

        #region 加载shp文件
        public void LoadShp(string _shpFilePath)
        {

        }
        #endregion
    }
}
