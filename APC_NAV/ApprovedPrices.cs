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
    public partial class ApprovedPrices : Form
    {
        public ApprovedPrices()
        {
            InitializeComponent();
        }

        private void ApprovedPrices_Load(object sender, EventArgs e)
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

            //Query viejo para NAV2015
            //String query = "select Item.description,APC_sugestion_queue.*,[Hipermercado La Fuente, SA$VAT Posting Setup].[VAT _],APC_sugestion_queue.last_change_user from APC_sugestion_queue inner join APC_Approved_queue on APC_Approved_queue.suggestion_id = APC_sugestion_queue.id inner join Item on Item.[No_] =APC_sugestion_queue.item_id inner join [dbo].[Hipermercado La Fuente, SA$VAT Posting Setup] on [dbo].[Hipermercado La Fuente, SA$VAT Posting Setup].[VAT Prod_ Posting Group] = [Item].[VAT Prod_ Posting Group] and [dbo].[Hipermercado La Fuente, SA$VAT Posting Setup].[VAT Bus_ Posting Group]= 'NAC' where APC_Approved_queue.status = 0  and APC_sugestion_queue.posted_invoice_id='" + ((StringComboBoxItem)comboBoxVendorInvoiceList.SelectedItem).value + "'";
            
            //Nuevo query adaptado para BC27
            String query = "" +
                "SELECT i.[Description], " +
                "APC_sugestion_queue.*, " +
                "vpsetup.[VAT _]," +
                "APC_sugestion_queue.last_change_user " +
                "FROM APC_sugestion_queue " +
                "INNER JOIN APC_Approved_queue on APC_Approved_queue.suggestion_id = APC_sugestion_queue.id " +
                "INNER JOIN [dbo].[HLF$Item$437dbf0e-84ff-417a-965d-ed2bb9650972] i on i.[No_] = APC_sugestion_queue.item_id " +
                "inner join [dbo].[HLF$VAT Posting Setup$437dbf0e-84ff-417a-965d-ed2bb9650972] vpsetup on vpsetup.[VAT Prod_ Posting Group] = i.[VAT Prod_ Posting Group] and vpsetup.[VAT Bus_ Posting Group]= 'NAC' " +
                "where APC_Approved_queue.status = 0  and APC_sugestion_queue.posted_invoice_id='" + ((StringComboBoxItem)comboBoxVendorInvoiceList.SelectedItem).value + "'";
            dt = DBConnection.queryTable(query);
            
            foreach (DataRow row in dt.Rows)
            {
                ItemSugestion item = new ItemSugestion();
                float suggestedPrice = float.Parse(row[12].ToString() == null || String.IsNullOrEmpty(row[12].ToString()) ? "0" : row[12].ToString());
                float previousPrice = float.Parse(row[11].ToString() == null || String.IsNullOrEmpty(row[11].ToString()) ? "0" : row[11].ToString());
                float varPercent = float.Parse(row[16].ToString() == null || String.IsNullOrEmpty(row[16].ToString()) ? "0" : row[16].ToString());
                float assignedPrice = float.Parse(row[13].ToString() == null || String.IsNullOrEmpty(row[13].ToString()) ? "0" : row[13].ToString());
                
                item.itemDescription = row[0].ToString();
                item.id = Convert.ToInt64(row[1].ToString());
                item.itemNo = row[2].ToString();
                item.itemUOM = row[3].ToString();
                item.priceGroup = row[4].ToString();
                item.postedInvoiceId = row[5].ToString();
                item.sugestionGenerationTime = DateTime.Parse(row[6].ToString());
                item.sugestionStatus = "No realizar cambio";
                item.lastStatusGenerationTime = DateTime.Parse(row[8].ToString());
                item.previousCost = float.Parse(row[9].ToString());
                item.newCost = float.Parse(row[10].ToString());
                item.previousPrice = previousPrice;
                item.newSugestedPrice = suggestedPrice;
                item.costVariation = item.previousCost == 0 ? 100 : ((item.newCost - item.previousCost) / item.previousCost) *100 ;
                item.priceChangeMargin = previousPrice == 0 ? 100 : ((assignedPrice - (item.newCost + (item.newCost * (varPercent / 100)))) / (item.newCost + (item.newCost * (varPercent / 100)))) * 100;
                item.priceAssignedTochange = assignedPrice;
                item.vatPercet = varPercent;
                item.quantity = float.Parse(row[15].ToString());
                item.userID = row[17].ToString();
                //MessageBox.Show(item.itemDescription, "Aviso");
                
                itemsSugestionList.Add(item);
            }

            //dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = itemsSugestionList;
            dataGridView1.Columns[12].ReadOnly = true;
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
            
            //Query para NAV 2015
            /* String query = "select APC_sugestion_queue.posted_invoice_id, [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Buy-from Vendor Name],\n"+
                             "[Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Posting Date]\n"+
                             "from APC_sugestion_queue inner join APC_Approved_queue on APC_Approved_queue.suggestion_id = APC_sugestion_queue.id join [dbo].[Hipermercado La Fuente, SA$Purch_ Inv_ Header]\n" +
                             "on [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[No_] = APC_sugestion_queue.posted_invoice_id\n"+
                             "where APC_Approved_queue.status = 0\n" +
                             "group by APC_sugestion_queue.posted_invoice_id, [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Buy-from Vendor Name],[Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Posting Date]\n" +
                             "order by [Hipermercado La Fuente, SA$Purch_ Inv_ Header].[Posting Date] asc";*/

            //Query adaptado para BC27
            String query = "select APC_sugestion_queue.posted_invoice_id, pih.[Buy-from Vendor Name],pih.[Posting Date] " +
                "FROM APC_sugestion_queue " +
                "INNER JOIN APC_Approved_queue on APC_Approved_queue.suggestion_id = APC_sugestion_queue.id " +
                "JOIN [dbo].[HLF$Purch_ Inv_ Header$437dbf0e-84ff-417a-965d-ed2bb9650972] pih on pih.[No_] = APC_sugestion_queue.posted_invoice_id " +
                "WHERE APC_Approved_queue.status = 0 " +
                "GROUP BY APC_sugestion_queue.posted_invoice_id, pih.[Buy-from Vendor Name], pih.[Posting Date] " +
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

            lblOutStandingTotal.Text = "Facturas pendientes de cambio: " + comboBoxVendorInvoiceList.Items.Count.ToString();
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
            Boolean exludingLine = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[11].Value.ToString() == "Realizar cambio" && Convert.ToDouble(row.Cells[12].Value.ToString()) == 0)
                {
                    MessageBox.Show(String.Format("No puede incluír productos con precio 0, Producto: \"{0}\" en la línea: {1}", row.Cells[1].Value.ToString() + "-" + row.Cells[2].Value.ToString(), row.Index + 1),"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (row.Cells[11].Value.ToString() == "Realizar cambio" && Math.Abs(Convert.ToDouble(row.Cells[12].Value.ToString()) - Convert.ToDouble(row.Cells[8].Value.ToString())) < 0.05)
                {
                    MessageBox.Show(String.Format("No puede establecer el mismo precio para el producto: \"{0}\" en la línea: {1}", row.Cells[1].Value.ToString() + "-" + row.Cells[2].Value.ToString(), row.Index + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (row.Cells[11].Value.ToString() == "Excluir de pendientes")
                {
                    exludingLine = true;
                }

            }


            if (MessageBox.Show("Esta seguro que desea guardar esta los cambios a la aprobación", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }



            if (exludingLine)
            {
                if (MessageBox.Show("Esta seguro que desea continuar, algunas lineas serán excluidas una vez registrado no se podrán reversar los cambios", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            }


            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null || String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    continue;

                if (row.Cells[11].Value.ToString() == "Realizar cambio")
                     caseStatus="1";
                if (row.Cells[11].Value.ToString() == "No realizar cambio")
                    caseStatus = "2";
                if (row.Cells[11].Value.ToString() == "Excluir de pendientes")
                     caseStatus="3";


                if (caseStatus == "1")
                {
                    //MODIFICAR SUGESTION PRICE 
                    String updateCommand = String.Format("update APC_sugestion_queue set last_status_change_generation =GETDATE(),\n" +
                    "price_assigned_to_change={0}, last_change_user='{1}' where id={2}", row.Cells[12].Value.ToString(), System.Security.Principal.WindowsIdentity.GetCurrent().Name, row.Cells[0].Value.ToString());
                    DBConnection.executeOnTable(updateCommand);
                }


                if (caseStatus == "3")
                {
                    //MODIFICAR APPROVED STATUS
                    String updateCommand = String.Format("update APC_Approved_queue set status={0}, commited_time =GETDATE(),\n" +
                    "commited_by='{1}' where suggestion_id={2}", caseStatus, System.Security.Principal.WindowsIdentity.GetCurrent().Name, row.Cells[0].Value.ToString());
                    DBConnection.executeOnTable(updateCommand);
                }




            }

            MessageBox.Show("Cambios registrados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


            if (e.ColumnIndex == 11 && e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString() == "Realizar cambio")
                    dataGridView1.Columns[12].ReadOnly = false;
                else
                    dataGridView1.Columns[12].ReadOnly = true;
            }

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[11].Value = "No realizar cambio";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea continuar, no podrá reversar los cambios de lineas excluidas posterior al registro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[11].Value = "Excluir de pendientes";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
