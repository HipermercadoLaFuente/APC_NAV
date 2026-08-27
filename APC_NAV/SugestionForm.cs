using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC_NAV
{
    public partial class SugestionForm : Form
    {
        public SugestionForm()
        {
            InitializeComponent();
        }

        private void SugestionForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["priceAssignedTochange"].DefaultCellStyle.BackColor = Color.LightBlue;
            Font font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridView1.Columns["priceAssignedTochange"].DefaultCellStyle.Font=font;

            dataGridView1.Columns["priceChangeMargin"].DefaultCellStyle.Font = font;

            reloadVendorInvoice();
            
            //reloadSugestions();
        }


        private void clearGrid()
        {
            List<ItemSugestion> itemsSugestionList = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = itemsSugestionList;
            dataGridView1.Refresh();
        }

        public void reloadSugestions()
        {
            List<ItemSugestion> itemsSugestionList = new List<ItemSugestion>();
            clearGrid();

            if (comboBoxVendorInvoiceList.SelectedIndex < 0)
            {
                return;
            }
                

            if (comboBoxVendorInvoiceList.SelectedItem == null || ((StringComboBoxItem)comboBoxVendorInvoiceList.SelectedItem).value == null || String.IsNullOrEmpty(((StringComboBoxItem)comboBoxVendorInvoiceList.SelectedItem).value))
                return;

            
            DataTable dt = new DataTable();
            //String query = "select Item.description,APC_sugestion_queue.*,[Hipermercado La Fuente, SA$VAT Posting Setup].[VAT _],APC_sugestion_queue.last_change_user from APC_sugestion_queue inner join Item on Item.[No_] =APC_sugestion_queue.item_id inner join [dbo].[Hipermercado La Fuente, SA$VAT Posting Setup] on [dbo].[Hipermercado La Fuente, SA$VAT Posting Setup].[VAT Prod_ Posting Group] = [Item].[VAT Prod_ Posting Group] and [dbo].[Hipermercado La Fuente, SA$VAT Posting Setup].[VAT Bus_ Posting Group]= 'NAC' where (APC_sugestion_queue.sugestion_status = 0 or sugestion_status=2) and APC_sugestion_queue.posted_invoice_id='" + ((StringComboBoxItem)comboBoxVendorInvoiceList.SelectedItem).value + "'";

            //Query adaptado para BC, falta probar por falta de data
            String query = "SELECT " +
                "i.[Description]," +
                "APC_sugestion_queue.*," +
                "vpsetup.[VAT _]," +
                "APC_sugestion_queue.last_change_user " +
                "FROM APC_sugestion_queue " +
                "INNER JOIN [dbo].[HLF$Item$437dbf0e-84ff-417a-965d-ed2bb9650972] i ON i.[No_] = APC_sugestion_queue.item_id " +
                "INNER JOIN [dbo].[HLF$VAT Posting Setup$437dbf0e-84ff-417a-965d-ed2bb9650972] vpsetup on vpsetup.[VAT Prod_ Posting Group] = i.[VAT Prod_ Posting Group] " +
                "and vpsetup.[VAT Bus_ Posting Group]= 'NAC' " +
                "where (APC_sugestion_queue.sugestion_status = 0 or sugestion_status=2) " +
                "and APC_sugestion_queue.posted_invoice_id='" + ((StringComboBoxItem)comboBoxVendorInvoiceList.SelectedItem).value + "'";


            dt = DBConnection.queryTable(query);
            
            foreach (DataRow row in dt.Rows)
            {
                ItemSugestion item = new ItemSugestion();
                float suggestedPrice = float.Parse(row[12].ToString() == null || String.IsNullOrEmpty(row[12].ToString()) ? "0" : row[12].ToString());
                float previousPrice = float.Parse(row[11].ToString() == null || String.IsNullOrEmpty(row[11].ToString()) ? "0" : row[11].ToString());
                float varPercent = float.Parse(row[16].ToString() == null || String.IsNullOrEmpty(row[16].ToString()) ? "0" : row[16].ToString());

                item.itemDescription = row[0].ToString();
                item.id = Convert.ToInt64(row[1].ToString());
                item.itemNo = row[2].ToString();
                item.itemUOM = row[3].ToString();
                item.priceGroup = row[4].ToString();
                item.postedInvoiceId = row[5].ToString();
                item.sugestionGenerationTime = DateTime.Parse(row[6].ToString());
                item.sugestionStatus ="Incluir";
                item.lastStatusGenerationTime = DateTime.Parse(row[8].ToString());
                item.previousCost = float.Parse(row[9].ToString());
                item.newCost = float.Parse(row[10].ToString());
                item.previousPrice = previousPrice;
                item.newSugestedPrice = suggestedPrice;
                item.costVariation = item.previousCost == 0 ? 100 : ((item.newCost - item.previousCost) / item.previousCost) *100 ;
                item.priceChangeMargin = previousPrice == 0 ? 100 : ((suggestedPrice - (item.newCost + (item.newCost * (varPercent / 100)))) / (item.newCost + (item.newCost * (varPercent / 100)))) * 100;
                item.priceAssignedTochange = suggestedPrice;
                item.vatPercet = varPercent;
                item.quantity = float.Parse(row[15].ToString());
                item.userID = row[17].ToString();
                //MessageBox.Show(item.itemDescription, "Aviso");
                itemsSugestionList.Add(item);
            }

            //dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = itemsSugestionList;
            dataGridView1.Refresh();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Security.Principal.WindowsIdentity.GetCurrent().Name
            reloadVendorInvoice();
            //reloadSugestions();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (Convert.ToDouble(r.Cells[8].Value.ToString()) > Convert.ToDouble(r.Cells[9].Value.ToString()))
                {
                    Font font =  new Font("Arial", 12F, FontStyle.Bold,GraphicsUnit.Pixel);
                    dataGridView1.Rows[r.Index].Cells[12].Style.BackColor = Color.PaleVioletRed;
                    dataGridView1.Rows[r.Index].Cells[12].Style.Font = font;
                }

                if (Convert.ToDouble(r.Cells[10].Value.ToString()) ==0)
                {
                    Font font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                    dataGridView1.Rows[r.Index].Cells[12].Style.BackColor = Color.Yellow;
                    dataGridView1.Rows[r.Index].Cells[12].Style.Font = font;
                }
                    
            }
        }

        private void reloadVendorInvoice()
        {

            dataGridView1.Refresh();

            //Antiguo query, trabaja con NAV 2015
            /*String query = "select APC_sugestion_queue.posted_invoice_id, [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Buy-from Vendor Name],\n"+
                            "[Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Posting Date]\n"+
                            "from APC_sugestion_queue inner join [dbo].[Hipermercado La Fuente, SA$Purch_ Inv_ Header]\n"+
                            "on [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[No_] = APC_sugestion_queue.posted_invoice_id\n"+
                            "where APC_sugestion_queue.sugestion_status = 0 or sugestion_status=2\n"+
                            "group by APC_sugestion_queue.posted_invoice_id, [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Buy-from Vendor Name],[Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Posting Date]\n" +
                            "order by [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Posting Date] asc";*/

            //Query adaptado para BC 27
            String query = "SELECT queue_.posted_invoice_id, pih.[Buy-from Vendor Name], pih.[Posting Date] " +
                "FROM APC_sugestion_queue queue_ " +
                "INNER JOIN [dbo].[HLF$Purch_ Inv_ Header$437dbf0e-84ff-417a-965d-ed2bb9650972] pih ON pih.[No_] = queue_.[posted_invoice_id] " +
                "WHERE queue_.sugestion_status = 0 or queue_.sugestion_status=2 " +
                "GROUP BY queue_.posted_invoice_id, pih.[Buy-from Vendor Name], pih.[Posting Date] " +
                "ORDER BY pih.[Posting Date] asc;";

            DataTable dt = DBConnection.queryTable(query);

            comboBoxVendorInvoiceList.Items.Clear();
            clearGrid();

            foreach (DataRow r in dt.Rows)
            {
                StringComboBoxItem item = new StringComboBoxItem();
                item.caption = r[0].ToString() + " - " + r[1].ToString() + " - " + Convert.ToDateTime(r[2].ToString()).ToString("dd/MM/yyyy");
                item.value = r[0].ToString();
                comboBoxVendorInvoiceList.Items.Add(item);
            }

            lblOutStandingTotal.Text = "Facturas pendiente: " + comboBoxVendorInvoiceList.Items.Count.ToString();
            if (comboBoxVendorInvoiceList.Items.Count > 0)
                comboBoxVendorInvoiceList.SelectedIndex = 0;
            else
                comboBoxVendorInvoiceList.SelectedIndex = -1;

        }

        private void comboBoxVendorInvoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadSugestions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String caseStatus="";


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[11].Value.ToString() == "Incluir" && Convert.ToDouble(row.Cells[12].Value.ToString())==0)
                {
                    MessageBox.Show(String.Format("No puede incluír productos con precio 0, Producto: \"{0}\" en la línea: {1}", row.Cells[1].Value.ToString() + "-" + row.Cells[2].Value.ToString(), row.Index + 1),"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (row.Cells[11].Value.ToString() == "Incluir" && Math.Abs(Convert.ToDouble(row.Cells[12].Value.ToString()) - Convert.ToDouble(row.Cells[8].Value.ToString())) < 0.05)
                {
                    MessageBox.Show(String.Format("No puede establecer el mismo precio para el producto: \"{0}\" en la línea: {1}", row.Cells[1].Value.ToString() + "-" + row.Cells[2].Value.ToString(), row.Index + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            if (MessageBox.Show("Esta seguro que desea guardar esta los cambios de la sugerencia", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }


            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null || String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    continue;
                if(row.Cells[11].Value.ToString() == "Incluir")
                     caseStatus="1";
                if(row.Cells[11].Value.ToString() == "Posponer")
                     caseStatus="2";
                if(row.Cells[11].Value.ToString() == "Excluir")
                     caseStatus="3";
                String insertCommand = String.Format("update APC_sugestion_queue set sugestion_status={0}, last_status_change_generation =GETDATE(),\n"+
                "price_assigned_to_change={1}, last_change_user='{2}' where id={3}", caseStatus, row.Cells[12].Value.ToString(), System.Security.Principal.WindowsIdentity.GetCurrent().Name, row.Cells[0].Value.ToString());
                DBConnection.executeOnTable(insertCommand);
            }

            MessageBox.Show("Factura registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            reloadVendorInvoice();
      
        }

        private void lblOutStandingTotal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
               

            if(e.ColumnIndex == 12 && e.RowIndex >=0)
            {

                ItemSugestion item = (ItemSugestion)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                dataGridView1.Rows[e.RowIndex].Cells[13].Value = item.previousPrice == 0 ? 100 : ((item.priceAssignedTochange - (item.newCost + (item.newCost * (item.vatPercet / 100)))) / (item.newCost + (item.newCost * (item.vatPercet / 100)))) * 100;
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[11].Value = "Incluir";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[11].Value = "Excluir";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
