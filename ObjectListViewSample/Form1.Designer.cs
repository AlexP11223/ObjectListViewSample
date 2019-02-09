namespace ObjectListViewSample
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.colProgress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvFilesystem)).BeginInit();
            this.SuspendLayout();
            // 
            // tvFilesystem
            // 
            this.tvFilesystem.AllColumns.Add(this.colName);
            this.tvFilesystem.AllColumns.Add(this.colSize);
            this.tvFilesystem.AllColumns.Add(this.colLastWriteTime);
            this.tvFilesystem.AllColumns.Add(this.colProgress);
            this.tvFilesystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFilesystem.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.tvFilesystem.CellEditUseWholeCell = false;
            this.tvFilesystem.CheckBoxes = true;
            this.tvFilesystem.CheckedAspectName = "";
            this.tvFilesystem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize,
            this.colLastWriteTime});
            this.tvFilesystem.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvFilesystem.FullRowSelect = true;
            this.tvFilesystem.HierarchicalCheckboxes = true;
            this.tvFilesystem.Location = new System.Drawing.Point(13, 55);
            this.tvFilesystem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvFilesystem.MultiSelect = false;
            this.tvFilesystem.Name = "tvFilesystem";
            this.tvFilesystem.SelectAllOnControlA = false;
            this.tvFilesystem.ShowGroups = false;
            this.tvFilesystem.Size = new System.Drawing.Size(799, 505);
            this.tvFilesystem.SmallImageList = this.imglstIcons;
            this.tvFilesystem.TabIndex = 0;
            this.tvFilesystem.UseCompatibleStateImageBehavior = false;
            this.tvFilesystem.UseHotItem = true;
            this.tvFilesystem.UseNotifyPropertyChanged = true;
            this.tvFilesystem.UseTranslucentHotItem = true;
            this.tvFilesystem.UseTranslucentSelection = true;
            this.tvFilesystem.View = System.Windows.Forms.View.Details;
            this.tvFilesystem.VirtualMode = true;
            this.tvFilesystem.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.tvFilesystem_ItemChecked);
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
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(13, 16);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(98, 31);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // colProgress
            // 
            this.colProgress.AspectName = "Progress";
            this.colProgress.DisplayIndex = 3;
            this.colProgress.IsVisible = false;
            this.colProgress.Text = "Progress";
            this.colProgress.Width = 120;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(608, 16);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(204, 31);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process something";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 574);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnRemove);
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
        private System.Windows.Forms.Button btnRemove;
        private BrightIdeasSoftware.OLVColumn colProgress;
        private System.Windows.Forms.Button btnProcess;
    }
}

