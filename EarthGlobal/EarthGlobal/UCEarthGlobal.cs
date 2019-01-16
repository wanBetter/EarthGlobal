using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.UI;


namespace EarthGlobal
{
    
    public partial class UCEarthGlobal : UserControl
    {

        internal static SceneControl m_MainSceneControl = new SceneControl { Dock = DockStyle.Fill };
        
        public UCEarthGlobal()
        {
            InitializeComponent();
            InitEarthGlobal();

        }
        private void InitEarthGlobal()
        {
            m_MainSceneControl.Scene.LatLonGrid.IsVisible = false;
            m_MainSceneControl.Scene.Sun.IsVisible = false;
            this.Controls.Add(m_MainSceneControl);
            DataImport.PrjLoad prjLoad = new DataImport.PrjLoad();
            prjLoad.DefaultPrjLoad();

        }
    }
}
