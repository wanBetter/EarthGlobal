using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EarthGlobal.Common;

namespace EarthGlobal.UI
{
    public partial class Ctr3DToolBar : UserControl
    {
        public Ctr3DToolBar( )
        {
            InitializeComponent();  
            SetWindowRegion();
        }

        private void ToolPanel_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm.moveForm(this);
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Navigate.ZoomIn();
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Navigate.ZoomOut();
        }

        private void rotatePic_Click(object sender, EventArgs e)
        {
            //int a = new Random().Next(0, 4);
            //Earth3D.UCWindow3D.m_MainWindow3D.Command.Execute(1057, a);
        }

        private void clearPic_Click(object sender, EventArgs e)
        {
            //string analyseID = Earth3D.UCWindow3D.m_MainWindow3D.ProjectTree.FindItem(ClsSkyDataGroup.analyzeGroupName);
            //if (analyseID != "")
            //{
            //    Earth3D.UCWindow3D.m_MainWindow3D.ProjectTree.DeleteItem(analyseID);
            //}
            //string prjOneID = Earth3D.UCWindow3D.m_MainWindow3D.ProjectTree.FindItem(ClsSkyDataGroup.prjOneMapGroup);
            //if (prjOneID != "")
            //{
            //    Earth3D.UCWindow3D.m_MainWindow3D.ProjectTree.DeleteItem(prjOneID);
            //}
        }

        private void czmeasure_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Command.Execute(1036, 0);

        }

        private void spmeasure_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Command.Execute(1034, 0);
        }

        private void threeAreaMeasure_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Command.Execute(1037, 0);
        }

        private void dAreaMeasure_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Command.Execute(1165, 0);
        }

        private void kjMeasure_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Command.Execute(1035, 0);
        }

        private void Ctr3DToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            DragForm.moveForm(this);
        }

        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            FormPath = GetRoundedRectPath(rect, 6);
            this.Region = new Region(FormPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rect">窗体大小</param>
        /// <param name="radius">圆角大小</param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arcRect, 180, 90);//左上角

            arcRect.X = rect.Right - diameter;//右上角
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = rect.Bottom - diameter;// 右下角
            path.AddArc(arcRect, 0, 90);

            arcRect.X = rect.Left;// 左下角
            path.AddArc(arcRect, 90, 90);
            path.CloseAllFigures();
            return path;

        }

        private void northPic_Click(object sender, EventArgs e)
        {
            //Earth3D.UCWindow3D.m_MainWindow3D.Command.Execute(1056, 0);
        }
    }
}
