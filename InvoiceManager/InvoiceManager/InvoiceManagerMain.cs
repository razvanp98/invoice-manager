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
using Word = Microsoft.Office.Interop.Word;

namespace InvoiceManager
{
    public partial class InvoiceManagerMain : Form
    {
        private CrudRepository<InvoiceEntity> invoiceRepository = new InvoiceRepository();
        private List<InvoiceEntity> invoices = new List<InvoiceEntity>();

        public InvoiceManagerMain()
        {
            InitializeComponent();
            this.invoices = invoiceRepository.getAll();
            populateTable();
        }

        public void refresh()
        {
            this.invoices = invoiceRepository.getAll();
            populateTable();
        }

        private void saveDocxBtn_Click(object sender, EventArgs e)
        {
            Word.Application app = getWordApplicationInstance();
            app.Visible = true;
        }

        private void sendMailBtn_Click(object sender, EventArgs e)
        {
            SendMailView sendMailView = new SendMailView();
            sendMailView.Show();
          
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void populateTable()
        {
            invoiceWrapperGridView.Rows.Clear();

            foreach (InvoiceEntity e in this.invoices)
            {
                object[] row =
                {
                    e.id,
                    e.invoiceNumber,
                    e.vatPercentage,
                    e.invoiceCustomerName,
                    e.grossPrice,
                    e.netPrice
                };

                invoiceWrapperGridView.Rows.Add(row);
            }
        }

        private void insertRecordBtn_Click(object sender, EventArgs e)
        {
            InvoiceInsertView invoiceInsertView = new InvoiceInsertView();
            invoiceInsertView.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void invoiceWrapperGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int invoiceId = int.Parse(invoiceWrapperGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            invoiceRepository.delete(invoiceId);
            refresh();
        }

        private Word.Application getWordApplicationInstance()
        {
            Word.Application app = new Word.Application();
            Word.Document document = app.Documents.Add();
            Word.Range range = document.Range();

            range.Text = "Invoice Report";
            range.Font.Name = "Calibri";
            range.Font.Size = 16;
            range.Font.Bold = -1;
            range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            range.InsertAfter("\nGenerated at " + DateTime.Now + "\n\n\n");
            range.Font.Size = 12;
            range.Bold = 0;
            range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            range.Paragraphs.FirstLineIndent = 40;
            range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            Word.Table table = range.Tables.Add(range, invoices.Count + 1, invoiceWrapperGridView.ColumnCount);
            table.Range.Font.Size = 10;
            table.Range.Bold = 1;
            table.Borders.Enable = 1;
            table.Cell(1, 1).Range.Text = "Invoice ID";
            table.Cell(1, 2).Range.Text = "Invoice Number";
            table.Cell(1, 3).Range.Text = "VAT Percentage (%)";
            table.Cell(1, 4).Range.Text = "Customer Name";
            table.Cell(1, 5).Range.Text = "Gross Price (RON)";
            table.Cell(1, 6).Range.Text = "Net Price (RON)";

            for (int i = 1; i <= 6; i++)
            {
                table.Cell(1, i).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorAqua;
            }

            for (int i = 0; i < invoices.Count; i++)
            {
                InvoiceEntity entity = invoices.ElementAt(i);
                table.Cell(i + 2, 1).Range.Text = entity.id.ToString();
                table.Cell(i + 2, 2).Range.Text = entity.invoiceNumber;
                table.Cell(i + 2, 3).Range.Text = entity.vatPercentage.ToString();
                table.Cell(i + 2, 4).Range.Text = entity.invoiceCustomerName;
                table.Cell(i + 2, 5).Range.Text = entity.grossPrice.ToString();
                table.Cell(i + 2, 6).Range.Text = entity.netPrice.ToString();
            }

            return app;
        }
    }
}
