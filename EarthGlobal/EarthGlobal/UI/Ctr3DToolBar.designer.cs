namespace EarthGlobal.UI
{
    partial class Ctr3DToolBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.northPic = new System.Windows.Forms.PictureBox();
            this.threeAreaMeasure = new System.Windows.Forms.PictureBox();
            this.dAreaMeasure = new System.Windows.Forms.PictureBox();
            this.kjMeasure = new System.Windows.Forms.PictureBox();
            this.czmeasure = new System.Windows.Forms.PictureBox();
            this.spmeasure = new System.Windows.Forms.PictureBox();
            this.clearPic = new System.Windows.Forms.PictureBox();
            this.rotatePic = new System.Windows.Forms.PictureBox();
            this.zoomOut = new System.Windows.Forms.PictureBox();
            this.zoomIn = new System.Windows.Forms.PictureBox();
            this.ToolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeAreaMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAreaMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kjMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czmeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotatePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomIn)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolPanel.BackgroundImage = global::EarthGlobal.Properties.Resources.toolbg;
            this.ToolPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolPanel.Controls.Add(this.northPic);
            this.ToolPanel.Controls.Add(this.threeAreaMeasure);
            this.ToolPanel.Controls.Add(this.dAreaMeasure);
            this.ToolPanel.Controls.Add(this.kjMeasure);
            this.ToolPanel.Controls.Add(this.czmeasure);
            this.ToolPanel.Controls.Add(this.spmeasure);
            this.ToolPanel.Controls.Add(this.clearPic);
            this.ToolPanel.Controls.Add(this.rotatePic);
            this.ToolPanel.Controls.Add(this.zoomOut);
            this.ToolPanel.Controls.Add(this.zoomIn);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(392, 44);
            this.ToolPanel.TabIndex = 159;
            this.ToolPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolPanel_MouseDown);
            // 
            // northPic
            // 
            this.northPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.northPic.Image = global::EarthGlobal.Properties.Resources.icon_north;
            this.northPic.Location = new System.Drawing.Point(128, 11);
            this.northPic.Name = "northPic";
            this.northPic.Size = new System.Drawing.Size(24, 24);
            this.northPic.TabIndex = 9;
            this.northPic.TabStop = false;
            this.northPic.Click += new System.EventHandler(this.northPic_Click);
            // 
            // threeAreaMeasure
            // 
            this.threeAreaMeasure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.threeAreaMeasure.Image = global::EarthGlobal.Properties.Resources.icon_3d面积量测;
            this.threeAreaMeasure.Location = new System.Drawing.Point(344, 11);
            this.threeAreaMeasure.Name = "threeAreaMeasure";
            this.threeAreaMeasure.Size = new System.Drawing.Size(24, 24);
            this.threeAreaMeasure.TabIndex = 8;
            this.threeAreaMeasure.TabStop = false;
            this.threeAreaMeasure.Click += new System.EventHandler(this.threeAreaMeasure_Click);
            // 
            // dAreaMeasure
            // 
            this.dAreaMeasure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dAreaMeasure.Image = global::EarthGlobal.Properties.Resources.icon_地面面积测量;
            this.dAreaMeasure.Location = new System.Drawing.Point(308, 11);
            this.dAreaMeasure.Name = "dAreaMeasure";
            this.dAreaMeasure.Size = new System.Drawing.Size(24, 24);
            this.dAreaMeasure.TabIndex = 7;
            this.dAreaMeasure.TabStop = false;
            this.dAreaMeasure.Click += new System.EventHandler(this.dAreaMeasure_Click);
            // 
            // kjMeasure
            // 
            this.kjMeasure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kjMeasure.Image = global::EarthGlobal.Properties.Resources.icon_空间量测;
            this.kjMeasure.Location = new System.Drawing.Point(272, 11);
            this.kjMeasure.Name = "kjMeasure";
            this.kjMeasure.Size = new System.Drawing.Size(24, 24);
            this.kjMeasure.TabIndex = 6;
            this.kjMeasure.TabStop = false;
            this.kjMeasure.Click += new System.EventHandler(this.kjMeasure_Click);
            // 
            // czmeasure
            // 
            this.czmeasure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.czmeasure.Image = global::EarthGlobal.Properties.Resources.icon_垂直量测;
            this.czmeasure.Location = new System.Drawing.Point(236, 11);
            this.czmeasure.Name = "czmeasure";
            this.czmeasure.Size = new System.Drawing.Size(24, 24);
            this.czmeasure.TabIndex = 5;
            this.czmeasure.TabStop = false;
            this.czmeasure.Click += new System.EventHandler(this.czmeasure_Click);
            // 
            // spmeasure
            // 
            this.spmeasure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.spmeasure.Image = global::EarthGlobal.Properties.Resources.icon_水平量测;
            this.spmeasure.Location = new System.Drawing.Point(200, 11);
            this.spmeasure.Name = "spmeasure";
            this.spmeasure.Size = new System.Drawing.Size(24, 24);
            this.spmeasure.TabIndex = 4;
            this.spmeasure.TabStop = false;
            this.spmeasure.Click += new System.EventHandler(this.spmeasure_Click);
            // 
            // clearPic
            // 
            this.clearPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearPic.Image = global::EarthGlobal.Properties.Resources.icon_清除;
            this.clearPic.Location = new System.Drawing.Point(164, 11);
            this.clearPic.Name = "clearPic";
            this.clearPic.Size = new System.Drawing.Size(24, 24);
            this.clearPic.TabIndex = 3;
            this.clearPic.TabStop = false;
            this.clearPic.Click += new System.EventHandler(this.clearPic_Click);
            // 
            // rotatePic
            // 
            this.rotatePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rotatePic.Image = global::EarthGlobal.Properties.Resources.icon_旋转;
            this.rotatePic.Location = new System.Drawing.Point(92, 11);
            this.rotatePic.Name = "rotatePic";
            this.rotatePic.Size = new System.Drawing.Size(24, 24);
            this.rotatePic.TabIndex = 2;
            this.rotatePic.TabStop = false;
            this.rotatePic.Click += new System.EventHandler(this.rotatePic_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zoomOut.Image = global::EarthGlobal.Properties.Resources.icon_缩小;
            this.zoomOut.Location = new System.Drawing.Point(56, 11);
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.Size = new System.Drawing.Size(24, 24);
            this.zoomOut.TabIndex = 1;
            this.zoomOut.TabStop = false;
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // zoomIn
            // 
            this.zoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zoomIn.Image = global::EarthGlobal.Properties.Resources.icon_放大;
            this.zoomIn.Location = new System.Drawing.Point(20, 11);
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.Size = new System.Drawing.Size(24, 24);
            this.zoomIn.TabIndex = 0;
            this.zoomIn.TabStop = false;
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // Ctr3DToolBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.ToolPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(392, 44);
            this.MinimumSize = new System.Drawing.Size(392, 44);
            this.Name = "Ctr3DToolBar";
            this.Size = new System.Drawing.Size(392, 44);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ctr3DToolBar_MouseDown);
            this.ToolPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.northPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeAreaMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAreaMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kjMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czmeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotatePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.PictureBox dAreaMeasure;
        private System.Windows.Forms.PictureBox kjMeasure;
        private System.Windows.Forms.PictureBox czmeasure;
        private System.Windows.Forms.PictureBox spmeasure;
        private System.Windows.Forms.PictureBox clearPic;
        private System.Windows.Forms.PictureBox rotatePic;
        private System.Windows.Forms.PictureBox zoomOut;
        private System.Windows.Forms.PictureBox zoomIn;
        private System.Windows.Forms.PictureBox threeAreaMeasure;
        private System.Windows.Forms.PictureBox northPic;
    }
}