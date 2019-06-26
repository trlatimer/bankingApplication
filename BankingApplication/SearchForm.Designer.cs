namespace BankingApplication
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchResultsDGV = new System.Windows.Forms.DataGridView();
            this.searchParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.searchSubmitButton = new System.Windows.Forms.Button();
            this.searchTextTextBox = new System.Windows.Forms.TextBox();
            this.searchTextLabel = new System.Windows.Forms.Label();
            this.searchByComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDGV)).BeginInit();
            this.searchParametersGroupBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchResultsDGV);
            this.panel1.Controls.Add(this.searchParametersGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 294);
            this.panel1.TabIndex = 0;
            // 
            // searchResultsDGV
            // 
            this.searchResultsDGV.AllowUserToAddRows = false;
            this.searchResultsDGV.AllowUserToDeleteRows = false;
            this.searchResultsDGV.AllowUserToOrderColumns = true;
            this.searchResultsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultsDGV.Location = new System.Drawing.Point(21, 158);
            this.searchResultsDGV.MultiSelect = false;
            this.searchResultsDGV.Name = "searchResultsDGV";
            this.searchResultsDGV.RowHeadersVisible = false;
            this.searchResultsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultsDGV.Size = new System.Drawing.Size(321, 109);
            this.searchResultsDGV.TabIndex = 1;
            // 
            // searchParametersGroupBox
            // 
            this.searchParametersGroupBox.Controls.Add(this.searchSubmitButton);
            this.searchParametersGroupBox.Controls.Add(this.searchTextTextBox);
            this.searchParametersGroupBox.Controls.Add(this.searchTextLabel);
            this.searchParametersGroupBox.Controls.Add(this.searchByComboBox);
            this.searchParametersGroupBox.Controls.Add(this.label2);
            this.searchParametersGroupBox.Location = new System.Drawing.Point(21, 25);
            this.searchParametersGroupBox.Name = "searchParametersGroupBox";
            this.searchParametersGroupBox.Size = new System.Drawing.Size(321, 127);
            this.searchParametersGroupBox.TabIndex = 0;
            this.searchParametersGroupBox.TabStop = false;
            this.searchParametersGroupBox.Text = "Search Parameters";
            // 
            // searchSubmitButton
            // 
            this.searchSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSubmitButton.Location = new System.Drawing.Point(116, 98);
            this.searchSubmitButton.Name = "searchSubmitButton";
            this.searchSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.searchSubmitButton.TabIndex = 2;
            this.searchSubmitButton.Text = "Search";
            this.searchSubmitButton.UseVisualStyleBackColor = true;
            this.searchSubmitButton.Click += new System.EventHandler(this.SearchSubmitButton_Click);
            // 
            // searchTextTextBox
            // 
            this.searchTextTextBox.Location = new System.Drawing.Point(143, 58);
            this.searchTextTextBox.Name = "searchTextTextBox";
            this.searchTextTextBox.Size = new System.Drawing.Size(121, 20);
            this.searchTextTextBox.TabIndex = 1;
            // 
            // searchTextLabel
            // 
            this.searchTextLabel.AutoSize = true;
            this.searchTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextLabel.Location = new System.Drawing.Point(43, 59);
            this.searchTextLabel.Name = "searchTextLabel";
            this.searchTextLabel.Size = new System.Drawing.Size(83, 16);
            this.searchTextLabel.TabIndex = 2;
            this.searchTextLabel.Text = "Search Text:";
            // 
            // searchByComboBox
            // 
            this.searchByComboBox.FormattingEnabled = true;
            this.searchByComboBox.Items.AddRange(new object[] {
            "Member ID",
            "Name",
            "Social Security Number"});
            this.searchByComboBox.Location = new System.Drawing.Point(143, 26);
            this.searchByComboBox.Name = "searchByComboBox";
            this.searchByComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchByComboBox.TabIndex = 0;
            this.searchByComboBox.Text = "-- Search by --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search By:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for a Member";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBackButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(399, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchBackButton
            // 
            this.searchBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchBackButton.Image = ((System.Drawing.Image)(resources.GetObject("searchBackButton.Image")));
            this.searchBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBackButton.Name = "searchBackButton";
            this.searchBackButton.Size = new System.Drawing.Size(36, 22);
            this.searchBackButton.Text = "Back";
            this.searchBackButton.Click += new System.EventHandler(this.SearchBackButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(399, 372);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SearchForm";
            this.Text = "Banking App | Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsDGV)).EndInit();
            this.searchParametersGroupBox.ResumeLayout(false);
            this.searchParametersGroupBox.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton searchBackButton;
        private System.Windows.Forms.DataGridView searchResultsDGV;
        private System.Windows.Forms.GroupBox searchParametersGroupBox;
        private System.Windows.Forms.ComboBox searchByComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button searchSubmitButton;
        private System.Windows.Forms.TextBox searchTextTextBox;
        private System.Windows.Forms.Label searchTextLabel;
    }
}