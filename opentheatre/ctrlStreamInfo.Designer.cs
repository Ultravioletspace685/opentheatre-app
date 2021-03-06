﻿namespace OpenTheatre
{
    partial class ctrlStreamInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.infoFileHost = new System.Windows.Forms.Label();
            this.infoFileName = new System.Windows.Forms.Label();
            this.panelFileInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWatchNow = new CButtonLib.CButton();
            this.btnDownload = new CButtonLib.CButton();
            this.btnReportBroken = new CButtonLib.CButton();
            this.contextFileName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgAddToBookmarks = new System.Windows.Forms.PictureBox();
            this.panelFileInfo.SuspendLayout();
            this.contextFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).BeginInit();
            this.SuspendLayout();
            // 
            // infoFileHost
            // 
            this.infoFileHost.AutoEllipsis = true;
            this.infoFileHost.AutoSize = true;
            this.infoFileHost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoFileHost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileHost.Location = new System.Drawing.Point(2, 3);
            this.infoFileHost.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.infoFileHost.Name = "infoFileHost";
            this.infoFileHost.Size = new System.Drawing.Size(74, 17);
            this.infoFileHost.TabIndex = 0;
            this.infoFileHost.Text = "Host Name";
            // 
            // infoFileName
            // 
            this.infoFileName.AutoEllipsis = true;
            this.infoFileName.AutoSize = true;
            this.infoFileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoFileName.Location = new System.Drawing.Point(76, 3);
            this.infoFileName.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.infoFileName.Name = "infoFileName";
            this.infoFileName.Size = new System.Drawing.Size(66, 17);
            this.infoFileName.TabIndex = 1;
            this.infoFileName.Text = "File Name";
            // 
            // panelFileInfo
            // 
            this.panelFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFileInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelFileInfo.Controls.Add(this.infoFileHost);
            this.panelFileInfo.Controls.Add(this.infoFileName);
            this.panelFileInfo.Location = new System.Drawing.Point(23, 0);
            this.panelFileInfo.Name = "panelFileInfo";
            this.panelFileInfo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.panelFileInfo.Size = new System.Drawing.Size(156, 25);
            this.panelFileInfo.TabIndex = 3;
            this.panelFileInfo.WrapContents = false;
            // 
            // btnWatchNow
            // 
            this.btnWatchNow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWatchNow.BackColor = System.Drawing.Color.Transparent;
            this.btnWatchNow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnWatchNow.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnWatchNow.Corners.All = 1;
            this.btnWatchNow.Corners.LowerLeft = 1;
            this.btnWatchNow.Corners.LowerRight = 1;
            this.btnWatchNow.Corners.UpperLeft = 1;
            this.btnWatchNow.Corners.UpperRight = 1;
            this.btnWatchNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchNow.DesignerSelected = false;
            this.btnWatchNow.DimFactorClick = 0;
            this.btnWatchNow.DimFactorHover = 0;
            this.btnWatchNow.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnWatchNow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnWatchNow.ImageIndex = 0;
            this.btnWatchNow.Location = new System.Drawing.Point(184, 1);
            this.btnWatchNow.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnWatchNow.Name = "btnWatchNow";
            this.btnWatchNow.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnWatchNow.Size = new System.Drawing.Size(92, 23);
            this.btnWatchNow.TabIndex = 5;
            this.btnWatchNow.Text = "Watch Now";
            this.btnWatchNow.TextShadowShow = false;
            this.btnWatchNow.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnPlay_ClickButtonArea);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnDownload.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(185)))), ((int)(((byte)(93)))));
            this.btnDownload.Corners.All = 1;
            this.btnDownload.Corners.LowerLeft = 1;
            this.btnDownload.Corners.LowerRight = 1;
            this.btnDownload.Corners.UpperLeft = 1;
            this.btnDownload.Corners.UpperRight = 1;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.DesignerSelected = false;
            this.btnDownload.DimFactorClick = 0;
            this.btnDownload.DimFactorHover = 0;
            this.btnDownload.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnDownload.ImageIndex = 0;
            this.btnDownload.Location = new System.Drawing.Point(282, 1);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnDownload.Size = new System.Drawing.Size(80, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextShadowShow = false;
            this.btnDownload.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnDownload_ClickButtonArea);
            // 
            // btnReportBroken
            // 
            this.btnReportBroken.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReportBroken.BackColor = System.Drawing.Color.Transparent;
            this.btnReportBroken.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnReportBroken.ColorFillSolid = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnReportBroken.Corners.All = 1;
            this.btnReportBroken.Corners.LowerLeft = 1;
            this.btnReportBroken.Corners.LowerRight = 1;
            this.btnReportBroken.Corners.UpperLeft = 1;
            this.btnReportBroken.Corners.UpperRight = 1;
            this.btnReportBroken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportBroken.DesignerSelected = false;
            this.btnReportBroken.DimFactorClick = 0;
            this.btnReportBroken.DimFactorHover = 0;
            this.btnReportBroken.FillType = CButtonLib.CButton.eFillType.Solid;
            this.btnReportBroken.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnReportBroken.ImageIndex = 0;
            this.btnReportBroken.Location = new System.Drawing.Point(368, 1);
            this.btnReportBroken.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.btnReportBroken.Name = "btnReportBroken";
            this.btnReportBroken.ShowFocus = CButtonLib.CButton.eFocus.None;
            this.btnReportBroken.Size = new System.Drawing.Size(108, 23);
            this.btnReportBroken.TabIndex = 6;
            this.btnReportBroken.Text = "Report Broken";
            this.btnReportBroken.TextMargin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnReportBroken.TextShadowShow = false;
            this.btnReportBroken.ClickButtonArea += new CButtonLib.CButton.ClickButtonAreaEventHandler(this.btnReportBroken_ClickButtonArea);
            // 
            // contextFileName
            // 
            this.contextFileName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenWithToolStripMenuItem});
            this.contextFileName.Name = "contextMenuStrip1";
            this.contextFileName.ShowImageMargin = false;
            this.contextFileName.ShowItemToolTips = false;
            this.contextFileName.Size = new System.Drawing.Size(114, 26);
            // 
            // OpenWithToolStripMenuItem
            // 
            this.OpenWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WMPToolStripMenuItem,
            this.VLCToolStripMenuItem,
            this.MPCToolStripMenuItem});
            this.OpenWithToolStripMenuItem.Name = "OpenWithToolStripMenuItem";
            this.OpenWithToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.OpenWithToolStripMenuItem.Text = "Open with...";
            // 
            // WMPToolStripMenuItem
            // 
            this.WMPToolStripMenuItem.Name = "WMPToolStripMenuItem";
            this.WMPToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.WMPToolStripMenuItem.Text = "WMP";
            this.WMPToolStripMenuItem.Click += new System.EventHandler(this.WMPToolStripMenuItem_Click);
            // 
            // VLCToolStripMenuItem
            // 
            this.VLCToolStripMenuItem.Name = "VLCToolStripMenuItem";
            this.VLCToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.VLCToolStripMenuItem.Text = "VLC";
            this.VLCToolStripMenuItem.Click += new System.EventHandler(this.VLCToolStripMenuItem_Click);
            // 
            // MPCToolStripMenuItem
            // 
            this.MPCToolStripMenuItem.Name = "MPCToolStripMenuItem";
            this.MPCToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.MPCToolStripMenuItem.Text = "MPC";
            // 
            // imgAddToBookmarks
            // 
            this.imgAddToBookmarks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imgAddToBookmarks.BackColor = System.Drawing.Color.Transparent;
            this.imgAddToBookmarks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAddToBookmarks.Image = global::OpenTheatre.Properties.Resources.bookmark_plus;
            this.imgAddToBookmarks.Location = new System.Drawing.Point(1, 1);
            this.imgAddToBookmarks.Name = "imgAddToBookmarks";
            this.imgAddToBookmarks.Size = new System.Drawing.Size(23, 23);
            this.imgAddToBookmarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddToBookmarks.TabIndex = 14;
            this.imgAddToBookmarks.TabStop = false;
            this.imgAddToBookmarks.Click += new System.EventHandler(this.imgAddToBookmarks_Click);
            // 
            // ctrlStreamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.imgAddToBookmarks);
            this.Controls.Add(this.panelFileInfo);
            this.Controls.Add(this.btnWatchNow);
            this.Controls.Add(this.btnReportBroken);
            this.Controls.Add(this.btnDownload);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctrlStreamInfo";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(476, 25);
            this.Load += new System.EventHandler(this.ctrlStreamInfo_Load);
            this.panelFileInfo.ResumeLayout(false);
            this.panelFileInfo.PerformLayout();
            this.contextFileName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddToBookmarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label infoFileHost;
        public System.Windows.Forms.Label infoFileName;
        private System.Windows.Forms.FlowLayoutPanel panelFileInfo;
        private CButtonLib.CButton btnDownload;
        private CButtonLib.CButton btnWatchNow;
        public System.Windows.Forms.ContextMenuStrip contextFileName;
        private System.Windows.Forms.ToolStripMenuItem OpenWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VLCToolStripMenuItem;
        private CButtonLib.CButton btnReportBroken;
        private System.Windows.Forms.ToolStripMenuItem MPCToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgAddToBookmarks;
    }
}
