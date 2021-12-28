namespace InvoiceManager
{
    partial class InvoiceManagerMain
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
            this.saveDocxBtn = new System.Windows.Forms.Button();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.appTitle = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.invoiceWrapperGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertRecordBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceWrapperGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveDocxBtn
            // 
            this.saveDocxBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveDocxBtn.Location = new System.Drawing.Point(9, 500);
            this.saveDocxBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveDocxBtn.Name = "saveDocxBtn";
            this.saveDocxBtn.Size = new System.Drawing.Size(108, 50);
            this.saveDocxBtn.TabIndex = 0;
            this.saveDocxBtn.Text = "Save as DOCX";
            this.saveDocxBtn.UseVisualStyleBackColor = false;
            this.saveDocxBtn.Click += new System.EventHandler(this.saveDocxBtn_Click);
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.sendMailBtn.Location = new System.Drawing.Point(333, 500);
            this.sendMailBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(108, 50);
            this.sendMailBtn.TabIndex = 1;
            this.sendMailBtn.Text = "Send to mail";
            this.sendMailBtn.UseVisualStyleBackColor = false;
            this.sendMailBtn.Click += new System.EventHandler(this.sendMailBtn_Click);
            // 
            // appTitle
            // 
            this.appTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(268, 9);
            this.appTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(266, 37);
            this.appTitle.TabIndex = 2;
            this.appTitle.Text = "Invoice Manager";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(665, 500);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 50);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // invoiceWrapperGridView
            // 
            this.invoiceWrapperGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceWrapperGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.invoiceNumber,
            this.vatPercentage,
            this.customerName,
            this.grossPrice,
            this.netPrice});
            this.invoiceWrapperGridView.Location = new System.Drawing.Point(11, 94);
            this.invoiceWrapperGridView.Margin = new System.Windows.Forms.Padding(2);
            this.invoiceWrapperGridView.Name = "invoiceWrapperGridView";
            this.invoiceWrapperGridView.RowHeadersWidth = 51;
            this.invoiceWrapperGridView.RowTemplate.Height = 24;
            this.invoiceWrapperGridView.Size = new System.Drawing.Size(764, 309);
            this.invoiceWrapperGridView.TabIndex = 4;
            this.invoiceWrapperGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.invoiceWrapperGridView_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Invoice ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.HeaderText = "Invoice Number";
            this.invoiceNumber.MinimumWidth = 6;
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.Width = 125;
            // 
            // vatPercentage
            // 
            this.vatPercentage.HeaderText = "VAT Percentage (%)";
            this.vatPercentage.MinimumWidth = 6;
            this.vatPercentage.Name = "vatPercentage";
            this.vatPercentage.Width = 125;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.Width = 125;
            // 
            // grossPrice
            // 
            this.grossPrice.HeaderText = "Gross Price (RON)";
            this.grossPrice.MinimumWidth = 6;
            this.grossPrice.Name = "grossPrice";
            this.grossPrice.Width = 125;
            // 
            // netPrice
            // 
            this.netPrice.HeaderText = "Net Price (RON)";
            this.netPrice.MinimumWidth = 6;
            this.netPrice.Name = "netPrice";
            this.netPrice.Width = 125;
            // 
            // insertRecordBtn
            // 
            this.insertRecordBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertRecordBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insertRecordBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insertRecordBtn.Location = new System.Drawing.Point(9, 407);
            this.insertRecordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.insertRecordBtn.Name = "insertRecordBtn";
            this.insertRecordBtn.Size = new System.Drawing.Size(108, 50);
            this.insertRecordBtn.TabIndex = 5;
            this.insertRecordBtn.Text = "Create";
            this.insertRecordBtn.UseVisualStyleBackColor = false;
            this.insertRecordBtn.Click += new System.EventHandler(this.insertRecordBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refreshBtn.Location = new System.Drawing.Point(665, 407);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(108, 50);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // InvoiceManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.insertRecordBtn);
            this.Controls.Add(this.invoiceWrapperGridView);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.appTitle);
            this.Controls.Add(this.sendMailBtn);
            this.Controls.Add(this.saveDocxBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InvoiceManagerMain";
            this.Text = "Invoice Manager";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceWrapperGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveDocxBtn;
        private System.Windows.Forms.Button sendMailBtn;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView invoiceWrapperGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPrice;
        private System.Windows.Forms.Button insertRecordBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}

