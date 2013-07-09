namespace CompingIndexer
{
    partial class IndexingRepoter
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
            this.AvailableCompetitions = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webBrowserActual = new System.Windows.Forms.WebBrowser();
            this.excludeFacebook = new System.Windows.Forms.CheckBox();
            this.excludeTwitter = new System.Windows.Forms.CheckBox();
            this.numPagesSelector = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagesSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailableCompetitions
            // 
            this.AvailableCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableCompetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableCompetitions.FormattingEnabled = true;
            this.AvailableCompetitions.ItemHeight = 16;
            this.AvailableCompetitions.Location = new System.Drawing.Point(3, 3);
            this.AvailableCompetitions.Name = "AvailableCompetitions";
            this.AvailableCompetitions.Size = new System.Drawing.Size(298, 539);
            this.AvailableCompetitions.TabIndex = 0;
            this.AvailableCompetitions.SelectedIndexChanged += new System.EventHandler(this.AvailableCompetitions_SelectedIndexChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(606, 312);
            this.webBrowser.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(914, 625);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AvailableCompetitions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 625);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GoButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numPagesSelector);
            this.panel1.Controls.Add(this.excludeTwitter);
            this.panel1.Controls.Add(this.excludeFacebook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 74);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Link";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(67, 51);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(228, 20);
            this.textBoxLink.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webBrowser);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.webBrowserActual);
            this.splitContainer2.Size = new System.Drawing.Size(606, 625);
            this.splitContainer2.SplitterDistance = 312;
            this.splitContainer2.TabIndex = 2;
            // 
            // webBrowserActual
            // 
            this.webBrowserActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserActual.Location = new System.Drawing.Point(0, 0);
            this.webBrowserActual.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserActual.Name = "webBrowserActual";
            this.webBrowserActual.ScriptErrorsSuppressed = true;
            this.webBrowserActual.Size = new System.Drawing.Size(606, 309);
            this.webBrowserActual.TabIndex = 0;
            // 
            // excludeFacebook
            // 
            this.excludeFacebook.AutoSize = true;
            this.excludeFacebook.Location = new System.Drawing.Point(6, 28);
            this.excludeFacebook.Name = "excludeFacebook";
            this.excludeFacebook.Size = new System.Drawing.Size(143, 17);
            this.excludeFacebook.TabIndex = 2;
            this.excludeFacebook.Text = "Exclude Facebook Links";
            this.excludeFacebook.UseVisualStyleBackColor = true;
            // 
            // excludeTwitter
            // 
            this.excludeTwitter.AutoSize = true;
            this.excludeTwitter.Location = new System.Drawing.Point(6, 5);
            this.excludeTwitter.Name = "excludeTwitter";
            this.excludeTwitter.Size = new System.Drawing.Size(127, 17);
            this.excludeTwitter.TabIndex = 3;
            this.excludeTwitter.Text = "Exclude Twitter Links";
            this.excludeTwitter.UseVisualStyleBackColor = true;
            // 
            // numPagesSelector
            // 
            this.numPagesSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPagesSelector.Location = new System.Drawing.Point(228, 2);
            this.numPagesSelector.Name = "numPagesSelector";
            this.numPagesSelector.Size = new System.Drawing.Size(60, 20);
            this.numPagesSelector.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pages";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(188, 24);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(100, 23);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Start";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // IndexingRepoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 625);
            this.Controls.Add(this.splitContainer1);
            this.Name = "IndexingRepoter";
            this.Text = "Competition Tool";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPagesSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AvailableCompetitions;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.WebBrowser webBrowserActual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.CheckBox excludeTwitter;
        private System.Windows.Forms.CheckBox excludeFacebook;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPagesSelector;
    }
}

