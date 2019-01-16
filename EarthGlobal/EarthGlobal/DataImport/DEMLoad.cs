using SuperMap.Data;
using SuperMap.Data.Conversion;
using SuperMap.Realspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EarthGlobal.DataImport
{
    public class DEMLoad
    {
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
            TerrainLayer terrainLayer= UCEarthGlobal.m_MainSceneControl.Scene.TerrainLayers.Add(importResult, true);
            UCEarthGlobal.m_MainSceneControl.Scene.Fly(new Camera { Latitude = terrainLayer.Bounds.Center.X, Longitude = terrainLayer.Bounds.Center.Y, Altitude = 10 });
        }
    }
}
