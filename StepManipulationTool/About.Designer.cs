
namespace XTB.StepManipulationTool
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelImran = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelAlexey = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listAssemblies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Imran Akram";
            // 
            // linkLabelImran
            // 
            this.linkLabelImran.AutoSize = true;
            this.linkLabelImran.Location = new System.Drawing.Point(113, 238);
            this.linkLabelImran.Name = "linkLabelImran";
            this.linkLabelImran.Size = new System.Drawing.Size(90, 13);
            this.linkLabelImran.TabIndex = 42;
            this.linkLabelImran.TabStop = true;
            this.linkLabelImran.Text = "@imranakram365";
            this.linkLabelImran.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelImran_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Alexey Shytikov";
            // 
            // linkLabelAlexey
            // 
            this.linkLabelAlexey.AutoSize = true;
            this.linkLabelAlexey.Location = new System.Drawing.Point(113, 219);
            this.linkLabelAlexey.Name = "linkLabelAlexey";
            this.linkLabelAlexey.Size = new System.Drawing.Size(57, 13);
            this.linkLabelAlexey.TabIndex = 40;
            this.linkLabelAlexey.TabStop = true;
            this.linkLabelAlexey.Text = "@shytikov";
            this.linkLabelAlexey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAlexey_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Brought to you by:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(237, 120);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(22, 13);
            this.lblVersion.TabIndex = 37;
            this.lblVersion.Text = "1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Version:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(174, 83);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(375, 37);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Move plugin steps between plugin types while preserving step GUIDs (Dataverse/Dyn" +
    "amics 365) for cleaner ALM changes";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(172, 40);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(312, 31);
            this.lblHeading.TabIndex = 34;
            this.lblHeading.Text = "Step Manipulation Tool";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listAssemblies);
            this.groupBox1.Location = new System.Drawing.Point(208, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(358, 222);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // listAssemblies
            // 
            this.listAssemblies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAssemblies.FullRowSelect = true;
            this.listAssemblies.GridLines = true;
            this.listAssemblies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listAssemblies.HideSelection = false;
            this.listAssemblies.Location = new System.Drawing.Point(2, 15);
            this.listAssemblies.Margin = new System.Windows.Forms.Padding(2);
            this.listAssemblies.Name = "listAssemblies";
            this.listAssemblies.Scrollable = false;
            this.listAssemblies.ShowGroups = false;
            this.listAssemblies.Size = new System.Drawing.Size(354, 205);
            this.listAssemblies.TabIndex = 0;
            this.listAssemblies.UseCompatibleStateImageBehavior = false;
            this.listAssemblies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Assembly";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version";
            this.columnHeader2.Width = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XTB.StepManipulationTool.Properties.Resources.iconLarge;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabelImran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelAlexey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelImran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelAlexey;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listAssemblies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}