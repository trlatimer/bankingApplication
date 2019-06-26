namespace BankingApplication
{
    partial class ViewTransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransactionsForm));
            this.viewTransactionsTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.transactionsBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewTransactionsDGV = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTransactionsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // viewTransactionsTitle
            // 
            this.viewTransactionsTitle.AutoSize = true;
            this.viewTransactionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTransactionsTitle.Location = new System.Drawing.Point(26, 41);
            this.viewTransactionsTitle.Name = "viewTransactionsTitle";
            this.viewTransactionsTitle.Size = new System.Drawing.Size(192, 20);
            this.viewTransactionsTitle.TabIndex = 0;
            this.viewTransactionsTitle.Text = "Transactions for account: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsBackButton,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(480, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // transactionsBackButton
            // 
            this.transactionsBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.transactionsBackButton.Image = ((System.Drawing.Image)(resources.GetObject("transactionsBackButton.Image")));
            this.transactionsBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transactionsBackButton.Name = "transactionsBackButton";
            this.transactionsBackButton.Size = new System.Drawing.Size(36, 22);
            this.transactionsBackButton.Text = "Back";
            this.transactionsBackButton.Click += new System.EventHandler(this.transactionsBackButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // viewTransactionsDGV
            // 
            this.viewTransactionsDGV.AllowUserToAddRows = false;
            this.viewTransactionsDGV.AllowUserToDeleteRows = false;
            this.viewTransactionsDGV.AllowUserToOrderColumns = true;
            this.viewTransactionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewTransactionsDGV.Location = new System.Drawing.Point(12, 73);
            this.viewTransactionsDGV.MultiSelect = false;
            this.viewTransactionsDGV.Name = "viewTransactionsDGV";
            this.viewTransactionsDGV.ReadOnly = true;
            this.viewTransactionsDGV.RowHeadersVisible = false;
            this.viewTransactionsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewTransactionsDGV.Size = new System.Drawing.Size(457, 230);
            this.viewTransactionsDGV.TabIndex = 2;
            // 
            // ViewTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(480, 316);
            this.Controls.Add(this.viewTransactionsDGV);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.viewTransactionsTitle);
            this.Name = "ViewTransactionsForm";
            this.Text = "ViewTransactionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTransactionsForm_FormClosed);
            this.Load += new System.EventHandler(this.ViewTransactionsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTransactionsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewTransactionsTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton transactionsBackButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView viewTransactionsDGV;
    }
}