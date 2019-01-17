using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EarthGlobal;


namespace EarthGlobalTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EarthGlobal.UCEarthGlobal m_MainEarthGlobal = new EarthGlobal.UCEarthGlobal { Dock = DockStyle.Fill };
            
            this.Controls.Add(m_MainEarthGlobal);
            //EarthGlobal.DataImport.DEMLoad demLoad = new EarthGlobal.DataImport.DEMLoad();
            //demLoad.LoadDem(@"E:\三维规划\04-DEM\demClip\DEM-CG-ALL-投影坐标_Clip.img");
        }
    }
}
