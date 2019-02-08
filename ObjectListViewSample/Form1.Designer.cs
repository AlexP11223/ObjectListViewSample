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
            this.tvFiles = new BrightIdeasSoftware.TreeListView();
            ((System.ComponentModel.ISupportInitialize)(this.tvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tvFiles
            // 
            this.tvFiles.CellEditUseWholeCell = false;
            this.tvFiles.Location = new System.Drawing.Point(18, 18);
            this.tvFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.ShowGroups = false;
            this.tvFiles.Size = new System.Drawing.Size(368, 437);
            this.tvFiles.TabIndex = 0;
            this.tvFiles.UseCompatibleStateImageBehavior = false;
            this.tvFiles.View = System.Windows.Forms.View.Details;
            this.tvFiles.VirtualMode = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 469);
            this.Controls.Add(this.tvFiles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tvFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView tvFiles;
    }
}

