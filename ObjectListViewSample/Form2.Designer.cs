namespace ObjectListViewSample
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lstEmployees = new BrightIdeasSoftware.ObjectListView();
            this.colFullName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colKpi = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imglstIcons = new System.Windows.Forms.ImageList(this.components);
            this.imglstPhotos = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlEditing = new System.Windows.Forms.Panel();
            this.numKpi = new System.Windows.Forms.NumericUpDown();
            this.btnBrowsePhoto = new System.Windows.Forms.Button();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.tboxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPhoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxJob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxFilter = new System.Windows.Forms.TextBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.chkHighlightLowKpi = new System.Windows.Forms.CheckBox();
            this.chkFilterHighKpi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFilterVacation = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstEmployees)).BeginInit();
            this.pnlEditing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKpi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmployees
            // 
            this.lstEmployees.AllColumns.Add(this.colFullName);
            this.lstEmployees.AllColumns.Add(this.colKpi);
            this.lstEmployees.AllColumns.Add(this.colState);
            this.lstEmployees.AllColumns.Add(this.colAction);
            this.lstEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEmployees.CellEditUseWholeCell = false;
            this.lstEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFullName,
            this.colKpi,
            this.colState,
            this.colAction});
            this.lstEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstEmployees.FullRowSelect = true;
            this.lstEmployees.Location = new System.Drawing.Point(13, 93);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.RowHeight = 54;
            this.lstEmployees.ShowGroups = false;
            this.lstEmployees.Size = new System.Drawing.Size(774, 558);
            this.lstEmployees.SmallImageList = this.imglstIcons;
            this.lstEmployees.TabIndex = 1;
            this.lstEmployees.UseCompatibleStateImageBehavior = false;
            this.lstEmployees.UseFilterIndicator = true;
            this.lstEmployees.UseFiltering = true;
            this.lstEmployees.UseNotifyPropertyChanged = true;
            this.lstEmployees.UseTranslucentSelection = true;
            this.lstEmployees.View = System.Windows.Forms.View.Details;
            this.lstEmployees.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.lstEmployees_FormatRow);
            this.lstEmployees.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstEmployees_ItemSelectionChanged);
            // 
            // colFullName
            // 
            this.colFullName.AspectName = "FullName";
            this.colFullName.FillsFreeSpace = true;
            this.colFullName.Text = "Employee";
            // 
            // colKpi
            // 
            this.colKpi.AspectName = "Kpi";
            this.colKpi.Text = "KPI";
            this.colKpi.Width = 120;
            // 
            // colState
            // 
            this.colState.AspectName = "State";
            this.colState.Text = "Status";
            this.colState.Width = 150;
            // 
            // colAction
            // 
            this.colAction.AspectName = "State";
            this.colAction.IsButton = true;
            this.colAction.Text = "";
            this.colAction.Width = 170;
            // 
            // imglstIcons
            // 
            this.imglstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstIcons.ImageStream")));
            this.imglstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstIcons.Images.SetKeyName(0, "vacation");
            this.imglstIcons.Images.SetKeyName(1, "money");
            this.imglstIcons.Images.SetKeyName(2, "working");
            // 
            // imglstPhotos
            // 
            this.imglstPhotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstPhotos.ImageStream")));
            this.imglstPhotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstPhotos.Images.SetKeyName(0, "unknown");
            this.imglstPhotos.Images.SetKeyName(1, "male");
            this.imglstPhotos.Images.SetKeyName(2, "female");
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Location = new System.Drawing.Point(13, 659);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "➕";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(84, 659);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(48, 48);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "➖";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlEditing
            // 
            this.pnlEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditing.Controls.Add(this.numKpi);
            this.pnlEditing.Controls.Add(this.btnBrowsePhoto);
            this.pnlEditing.Controls.Add(this.cbbGender);
            this.pnlEditing.Controls.Add(this.tboxLastName);
            this.pnlEditing.Controls.Add(this.label2);
            this.pnlEditing.Controls.Add(this.tboxPhoto);
            this.pnlEditing.Controls.Add(this.label4);
            this.pnlEditing.Controls.Add(this.tboxJob);
            this.pnlEditing.Controls.Add(this.label7);
            this.pnlEditing.Controls.Add(this.label3);
            this.pnlEditing.Controls.Add(this.tboxFirstName);
            this.pnlEditing.Controls.Add(this.label5);
            this.pnlEditing.Controls.Add(this.label1);
            this.pnlEditing.Location = new System.Drawing.Point(803, 14);
            this.pnlEditing.Name = "pnlEditing";
            this.pnlEditing.Size = new System.Drawing.Size(347, 637);
            this.pnlEditing.TabIndex = 2;
            // 
            // numKpi
            // 
            this.numKpi.Location = new System.Drawing.Point(7, 386);
            this.numKpi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numKpi.Name = "numKpi";
            this.numKpi.Size = new System.Drawing.Size(120, 26);
            this.numKpi.TabIndex = 6;
            this.numKpi.ValueChanged += new System.EventHandler(this.numKpi_ValueChanged);
            // 
            // btnBrowsePhoto
            // 
            this.btnBrowsePhoto.Location = new System.Drawing.Point(249, 309);
            this.btnBrowsePhoto.Name = "btnBrowsePhoto";
            this.btnBrowsePhoto.Size = new System.Drawing.Size(75, 26);
            this.btnBrowsePhoto.TabIndex = 5;
            this.btnBrowsePhoto.Text = "Browse";
            this.btnBrowsePhoto.UseVisualStyleBackColor = true;
            this.btnBrowsePhoto.Click += new System.EventHandler(this.btnBrowsePhoto_Click);
            // 
            // cbbGender
            // 
            this.cbbGender.DisplayMember = "Value";
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Location = new System.Drawing.Point(7, 236);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(323, 28);
            this.cbbGender.TabIndex = 3;
            this.cbbGender.SelectedIndexChanged += new System.EventHandler(this.cbbGender_SelectedIndexChanged);
            // 
            // tboxLastName
            // 
            this.tboxLastName.Location = new System.Drawing.Point(7, 95);
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(323, 26);
            this.tboxLastName.TabIndex = 1;
            this.tboxLastName.TextChanged += new System.EventHandler(this.tboxLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last name";
            // 
            // tboxPhoto
            // 
            this.tboxPhoto.Location = new System.Drawing.Point(7, 309);
            this.tboxPhoto.Name = "tboxPhoto";
            this.tboxPhoto.Size = new System.Drawing.Size(236, 26);
            this.tboxPhoto.TabIndex = 4;
            this.tboxPhoto.TextChanged += new System.EventHandler(this.tboxPhoto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Photo";
            // 
            // tboxJob
            // 
            this.tboxJob.Location = new System.Drawing.Point(7, 162);
            this.tboxJob.Name = "tboxJob";
            this.tboxJob.Size = new System.Drawing.Size(323, 26);
            this.tboxJob.TabIndex = 2;
            this.tboxJob.TextChanged += new System.EventHandler(this.tboxJob_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "KPI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Job";
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(7, 35);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(323, 26);
            this.tboxFirstName.TabIndex = 0;
            this.tboxFirstName.TextChanged += new System.EventHandler(this.tboxFirstName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // tboxFilter
            // 
            this.tboxFilter.Location = new System.Drawing.Point(6, 20);
            this.tboxFilter.Name = "tboxFilter";
            this.tboxFilter.Size = new System.Drawing.Size(208, 26);
            this.tboxFilter.TabIndex = 0;
            this.tboxFilter.TextChanged += new System.EventHandler(this.tboxFilter_TextChanged);
            // 
            // chkGroup
            // 
            this.chkGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGroup.AutoSize = true;
            this.chkGroup.Location = new System.Drawing.Point(696, 9);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(73, 24);
            this.chkGroup.TabIndex = 4;
            this.chkGroup.Text = "Group";
            this.chkGroup.UseVisualStyleBackColor = true;
            this.chkGroup.CheckedChanged += new System.EventHandler(this.chkGroup_CheckedChanged);
            // 
            // chkHighlightLowKpi
            // 
            this.chkHighlightLowKpi.AutoSize = true;
            this.chkHighlightLowKpi.Location = new System.Drawing.Point(507, 9);
            this.chkHighlightLowKpi.Name = "chkHighlightLowKpi";
            this.chkHighlightLowKpi.Size = new System.Drawing.Size(146, 24);
            this.chkHighlightLowKpi.TabIndex = 5;
            this.chkHighlightLowKpi.Text = "Highlight low KPI";
            this.chkHighlightLowKpi.UseVisualStyleBackColor = true;
            this.chkHighlightLowKpi.CheckedChanged += new System.EventHandler(this.chkHighlightLowKpi_CheckedChanged);
            // 
            // chkFilterHighKpi
            // 
            this.chkFilterHighKpi.AutoSize = true;
            this.chkFilterHighKpi.Location = new System.Drawing.Point(6, 52);
            this.chkFilterHighKpi.Name = "chkFilterHighKpi";
            this.chkFilterHighKpi.Size = new System.Drawing.Size(90, 24);
            this.chkFilterHighKpi.TabIndex = 6;
            this.chkFilterHighKpi.Text = "High KPI";
            this.chkFilterHighKpi.UseVisualStyleBackColor = true;
            this.chkFilterHighKpi.CheckedChanged += new System.EventHandler(this.chkFilterHighKpi_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxFilter);
            this.groupBox1.Controls.Add(this.chkFilterVacation);
            this.groupBox1.Controls.Add(this.chkFilterHighKpi);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // chkFilterVacation
            // 
            this.chkFilterVacation.AutoSize = true;
            this.chkFilterVacation.Location = new System.Drawing.Point(102, 52);
            this.chkFilterVacation.Name = "chkFilterVacation";
            this.chkFilterVacation.Size = new System.Drawing.Size(112, 24);
            this.chkFilterVacation.TabIndex = 6;
            this.chkFilterVacation.Text = "On vacation";
            this.chkFilterVacation.UseVisualStyleBackColor = true;
            this.chkFilterVacation.CheckedChanged += new System.EventHandler(this.chkFilterVacation_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkHighlightLowKpi);
            this.Controls.Add(this.chkGroup);
            this.Controls.Add(this.pnlEditing);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.lstEmployees)).EndInit();
            this.pnlEditing.ResumeLayout(false);
            this.pnlEditing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKpi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView lstEmployees;
        private BrightIdeasSoftware.OLVColumn colFullName;
        private System.Windows.Forms.ImageList imglstPhotos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlEditing;
        private System.Windows.Forms.Button btnBrowsePhoto;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox tboxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxFilter;
        private System.Windows.Forms.ImageList imglstIcons;
        private BrightIdeasSoftware.OLVColumn colKpi;
        private BrightIdeasSoftware.OLVColumn colState;
        private BrightIdeasSoftware.OLVColumn colAction;
        private System.Windows.Forms.NumericUpDown numKpi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.CheckBox chkHighlightLowKpi;
        private System.Windows.Forms.CheckBox chkFilterHighKpi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFilterVacation;
    }
}