﻿namespace ObjectListViewSample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tvFilesystem = new BrightIdeasSoftware.TreeListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colSize = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colLastWriteTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imglstIcons = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tvFilesystem)).BeginInit();
            this.SuspendLayout();
            // 
            // tvFilesystem
            // 
            this.tvFilesystem.AllColumns.Add(this.colName);
            this.tvFilesystem.AllColumns.Add(this.colSize);
            this.tvFilesystem.AllColumns.Add(this.colLastWriteTime);
            this.tvFilesystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFilesystem.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClickAlways;
            this.tvFilesystem.CellEditUseWholeCell = false;
            this.tvFilesystem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colLastWriteTime});
            this.tvFilesystem.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvFilesystem.Location = new System.Drawing.Point(18, 18);
            this.tvFilesystem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvFilesystem.Name = "tvFilesystem";
            this.tvFilesystem.ShowGroups = false;
            this.tvFilesystem.Size = new System.Drawing.Size(799, 529);
            this.tvFilesystem.SmallImageList = this.imglstIcons;
            this.tvFilesystem.TabIndex = 0;
            this.tvFilesystem.UseCompatibleStateImageBehavior = false;
            this.tvFilesystem.UseHotItem = true;
            this.tvFilesystem.UseTranslucentHotItem = true;
            this.tvFilesystem.UseTranslucentSelection = true;
            this.tvFilesystem.View = System.Windows.Forms.View.Details;
            this.tvFilesystem.VirtualMode = true;
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.CellEditUseWholeCell = true;
            this.colName.FillsFreeSpace = true;
            this.colName.Text = "Name";
            // 
            // colSize
            // 
            this.colSize.AspectName = "Size";
            this.colSize.Text = "Size";
            this.colSize.Width = 120;
            // 
            // colLastWriteTime
            // 
            this.colLastWriteTime.AspectName = "LastWriteTime";
            this.colLastWriteTime.Text = "Modified";
            this.colLastWriteTime.Width = 160;
            // 
            // imglstIcons
            // 
            this.imglstIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglstIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 561);
            this.Controls.Add(this.tvFilesystem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tvFilesystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView tvFilesystem;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn colSize;
        private BrightIdeasSoftware.OLVColumn colLastWriteTime;
        private System.Windows.Forms.ImageList imglstIcons;
    }
}

