using InvoiceManager.model;
using InvoiceManager.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class InvoiceInsertView : Form
    {
        private CrudRepository<InvoiceEntity> invoiceRepository = new InvoiceRepository();

        public InvoiceInsertView()
        {
            InitializeComponent();
        }

        private void createInvoice_Btn_Click(object sender, EventArgs e)
        {
            InvoiceEntity newInvoice = collectInvoiceData();
            invoiceRepository.Add(newInvoice);

            Application.OpenForms["InvoiceManagerMain"].Refresh();
        }

        private InvoiceEntity collectInvoiceData()
        {
            string invoiceNumber = invoiceNumber_input.Text;
            double vatPercentage = double.Parse(vatPercentage_input.Text);
            string customerName = customerName_input.Text;
            double grossPrice = double.Parse(grossPrice_input.Text);

            return InvoiceEntity.builder()
                .withInvoiceNumber(invoiceNumber)
                .withVAT(vatPercentage)
                .ofCustomer(customerName)
                .hasGrossPrice(grossPrice)
                .build();
        }
    }
}
