namespace InvoiceManager
{
    partial class InvoiceInsertView
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
            this.invoiceNumber_input = new System.Windows.Forms.TextBox();
            this.vatPercentage_input = new System.Windows.Forms.TextBox();
            this.customerName_input = new System.Windows.Forms.TextBox();
            this.grossPrice_input = new System.Windows.Forms.TextBox();
            this.createInvoice_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoiceNumber_input
            // 
            this.invoiceNumber_input.Location = new System.Drawing.Point(12, 12);
            this.invoiceNumber_input.Name = "invoiceNumber_input";
            this.invoiceNumber_input.Size = new System.Drawing.Size(171, 20);
            this.invoiceNumber_input.TabIndex = 0;
            this.invoiceNumber_input.Text = "Invoice Number";
            // 
            // vatPercentage_input
            // 
            this.vatPercentage_input.Location = new System.Drawing.Point(12, 53);
            this.vatPercentage_input.Name = "vatPercentage_input";
            this.vatPercentage_input.Size = new System.Drawing.Size(171, 20);
            this.vatPercentage_input.TabIndex = 1;
            this.vatPercentage_input.Text = "VAT Percentage (%)";
            // 
            // customerName_input
            // 
            this.customerName_input.Location = new System.Drawing.Point(12, 96);
            this.customerName_input.Name = "customerName_input";
            this.customerName_input.Size = new System.Drawing.Size(171, 20);
            this.customerName_input.TabIndex = 2;
            this.customerName_input.Text = "Customer Name";
            // 
            // grossPrice_input
            // 
            this.grossPrice_input.Location = new System.Drawing.Point(12, 141);
            this.grossPrice_input.Name = "grossPrice_input";
            this.grossPrice_input.Size = new System.Drawing.Size(171, 20);
            this.grossPrice_input.TabIndex = 3;
            this.grossPrice_input.Text = "Gross Price (RON)";
            // 
            // createInvoice_Btn
            // 
            this.createInvoice_Btn.Location = new System.Drawing.Point(12, 217);
            this.createInvoice_Btn.Name = "createInvoice_Btn";
            this.createInvoice_Btn.Size = new System.Drawing.Size(98, 32);
            this.createInvoice_Btn.TabIndex = 4;
            this.createInvoice_Btn.Text = "Submit";
            this.createInvoice_Btn.UseVisualStyleBackColor = true;
            this.createInvoice_Btn.Click += new System.EventHandler(this.createInvoice_Btn_Click);
            // 
            // InvoiceInsertView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.createInvoice_Btn);
            this.Controls.Add(this.grossPrice_input);
            this.Controls.Add(this.customerName_input);
            this.Controls.Add(this.vatPercentage_input);
            this.Controls.Add(this.invoiceNumber_input);
            this.Name = "InvoiceInsertView";
            this.Text = "Create new invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox invoiceNumber_input;
        private System.Windows.Forms.TextBox vatPercentage_input;
        private System.Windows.Forms.TextBox customerName_input;
        private System.Windows.Forms.TextBox grossPrice_input;
        private System.Windows.Forms.Button createInvoice_Btn;
    }
}