using InvoiceManager.model;
using InvoiceManager.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManager.mail
{
    public class MailProvider
    {
        private static MailProvider instance;

        public string smptHost = "smtp.gmail.com";
        public int smtpPort = 587;
        public bool sslEnabled = true;
        public bool isBodyHtml = true;

        public string recipient;
        public string subject;
        public string body;

        public string senderEmail;
        public string senderPassword;

        private MailProvider()
        {
            CrudRepository<InvoiceEntity> invoiceRepository = new InvoiceRepository();
            this.body = composeBody(invoiceRepository.getAll());
        }

        public static MailProvider getInstance()
        {
            if (instance == null)
                instance = new MailProvider();

            return instance;
        }

        private string composeBody(List<InvoiceEntity> invoices)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<head>");
            sb.Append("<style>");
            sb.Append("table, tr, td, th {border: 1px solid black;}");
            sb.Append("th {background: #7FFFD4;}");
            sb.Append("table {border-collapse: collapse}");
            sb.Append("</style>");
            sb.Append("</head>");
            sb.Append("</body>");
            sb.Append("<h3>Invoice Report No." + new Random().Next(1, 9999999) + "</h3>");
            sb.Append("<p>Generated at: " + DateTime.Now.ToString() + "</p>");
            sb.Append("<br><br>");
            sb.Append("<table><tr>");
            sb.Append("<th>Invoice ID</th>");
            sb.Append("<th>Invoice Number</th>");
            sb.Append("<th>Vat Percentage (%)</th>");
            sb.Append("<th>Customer Name</th>");
            sb.Append("<th>Gross Price (RON)</th>");
            sb.Append("<th>Net Price (RON)</th></tr>");

            foreach (InvoiceEntity i in invoices)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + i.id +"</td>");
                sb.Append("<td>" + i.invoiceNumber +"</td>");
                sb.Append("<td>" + i.vatPercentage +"</td>");
                sb.Append("<td>" + i.invoiceCustomerName +"</td>");
                sb.Append("<td>" + i.grossPrice +"</td>");
                sb.Append("<td>" + i.netPrice +"</td>");
                sb.Append("</tr>");
            }

            sb.Append("</table>");
            sb.Append("</body>");
            sb.Append("</html>");
            return sb.ToString();
        }
    }
}
