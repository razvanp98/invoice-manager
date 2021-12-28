using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManager.model
{
    internal class InvoiceEntity
    {
        public int id { get; set; }
        public string invoiceNumber { get; set; }
        public double vatPercentage { get; set; }
        public string invoiceCustomerName { get; set; }
        public double grossPrice { get; set; }
        public double netPrice { get; set; }

        public InvoiceEntity(int id, string invoiceNumber, double vatPercentage,
            string invoiceCustomerName, double grossPrice, double netPrice)
        {
            this.id = id;
            this.invoiceNumber = invoiceNumber;
            this.vatPercentage = vatPercentage;
            this.invoiceCustomerName = invoiceCustomerName;
            this.grossPrice = grossPrice;
            this.netPrice = netPrice;
        }

        public static InvoiceBuilder builder()
        {
            return new InvoiceBuilder();
        }

        public class InvoiceBuilder 
        {
            private int id;
            private string invoiceNumber;
            private double vatPercentage;
            private string invoiceCustomerName;
            private double grossPrice;
            private double netPrice;

            public InvoiceBuilder withId(int id)
            {
                this.id = id;
                return this;
            }

            public InvoiceBuilder withInvoiceNumber(string invoiceNumber)
            {
                this.invoiceNumber = invoiceNumber;
                return this;
            }

            public InvoiceBuilder withVAT(double vatPercentage)
            {
                this.vatPercentage = vatPercentage < 0 ? 0 : vatPercentage;
                return this;
            }

            public InvoiceBuilder ofCustomer(string invoiceCustomerName)
            {
                this.invoiceCustomerName = invoiceCustomerName;
                return this;
            }

            public InvoiceBuilder hasGrossPrice(double grossPrice)
            {
                this.grossPrice = grossPrice < 0 ? 0 : grossPrice;
                return this;
            }

            public InvoiceEntity build()
            {
                this.netPrice = (this.grossPrice * vatPercentage / 100) + this.grossPrice;
                return new InvoiceEntity(id, invoiceNumber, vatPercentage, invoiceCustomerName, grossPrice, netPrice);
            }

        }
    }
}
