using InvoiceManager.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager.repository
{
    public class InvoiceRepository : CrudRepository<InvoiceEntity>
    {
        private const string DB_USERNAME = "root";
        private const string DB_PASSWORD = "root1234";
        private const string DB_HOST = "localhost";
        private const string DB_NAME = "invoice_sys";

        private const string CONN_STRING =
            "datasource=" + DB_HOST + ";port=3306;username=" +
            DB_USERNAME + ";password=" + DB_PASSWORD +
            ";database=" + DB_NAME;

       List<InvoiceEntity> CrudRepository<InvoiceEntity>.getAll()
        {
            MySqlConnection conn = new MySqlConnection(CONN_STRING);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM invoice", conn);
            cmd.CommandTimeout = 120;

            MySqlDataReader reader;
            List<InvoiceEntity> invoices = new List<InvoiceEntity>();

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader.GetString(0);
                        string invoiceNumber = reader.GetString(1);
                        string vatPercentage = reader.GetString(2);
                        string invoiceCustomerName = reader.GetString(3);
                        string grossPrice = reader.GetString(4);

                        InvoiceEntity invoiceEntity = InvoiceEntity.builder()
                            .withId(int.Parse(id))
                            .withInvoiceNumber(invoiceNumber)
                            .withVAT(double.Parse(vatPercentage))
                            .ofCustomer(invoiceCustomerName)
                            .hasGrossPrice(double.Parse(grossPrice))
                            .build();

                        invoices.Add(invoiceEntity);
                    }
                } else
                {
                    MessageBox.Show("No invoices present in database.", "No results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch (Exception e)
            {
                MessageBox.Show("Could not get invoices. Caused by: " + e.Message, "Database error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                conn.Close();
            }

            return invoices;
        }

        void CrudRepository<InvoiceEntity>.Add(InvoiceEntity entity)
        {
            string cmdText = "INSERT INTO invoice (invoice_number, vat_percentage, invoice_customer_name, gross_price) " +
                "VALUES (?invoiceNumber, ?vatPercentage, ?customerName, ?grossPrice)";
            MySqlConnection conn = new MySqlConnection(CONN_STRING);
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.CommandTimeout = 120;
            cmd.Parameters.Add("?invoiceNumber", MySqlDbType.VarChar).Value = entity.invoiceNumber;
            cmd.Parameters.Add("?vatPercentage", MySqlDbType.Float).Value = entity.vatPercentage;
            cmd.Parameters.Add("?customerName", MySqlDbType.VarChar).Value = entity.invoiceCustomerName;
            cmd.Parameters.Add("?grossPrice", MySqlDbType.Float).Value = entity.grossPrice;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            } catch (Exception e)
            {
                MessageBox.Show("Could not create record. Caused by: " + e.Message, "Database error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                conn.Close();

                DialogResult result = MessageBox.Show("New record created.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    Application.OpenForms["InvoiceInsertView"].Close();
                }

            }
        }
        public void delete(int invoiceId)
        {
            MySqlConnection conn = new MySqlConnection(CONN_STRING);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM invoice WHERE id = ?invoiceId", conn);
            cmd.CommandTimeout = 120;
            cmd.Parameters.Add("?invoiceId", MySqlDbType.Int32).Value = invoiceId;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Could not delete record. Caused by: " + e.Message, "Database error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

                DialogResult result = MessageBox.Show("Invoice deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
