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
    public partial class ItemMasterForm : Form
    {

        ItemMaster selectedItem = new ItemMaster();

        public ItemMasterForm()
        {
            InitializeComponent();
        }

        private void ItemMasterForm_Load(object sender, EventArgs e)
        {
            reloadItems();
        }

        public void updateFields()
        {
            txtID.Text = selectedItem.itemNo;
            txtDescription.Text = selectedItem.itemDescription;
            txtUOM.Text = selectedItem.itemUOM;
            txtLastCost.Text = selectedItem.lastCost.ToString();
            txtPriceGroup.Text = selectedItem.priceGroup;
            maskedTextBoxCostMargin.Text = selectedItem.costMarginVariationAllowed.ToString();
            comboRounding.SelectedIndex = selectedItem.roundingMethod - 1;
            dateTimePickerLastChange.Value = selectedItem.lastPriceChangeDate;
            maskedTextBoxPriceMargin.Text = selectedItem.salesPriceMarging.ToString();
            maskedTextBoxLastPrice.Text = selectedItem.priceBeforeChange.ToString();
            maskedTextBoxLastAssignedPrice.Text = selectedItem.lastPriceSetted.ToString();
            dateTimePickerDeleted.Value = selectedItem.deletedDate;
            checkBoxDeleted.Checked = selectedItem.deleted;
            checkBoxTicketRequired.Checked = selectedItem.labelRequired;
            checkBoxExlude.Checked = selectedItem.excludeForPriceChange;


            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridViewRow row = dataGridView1.Rows[0];
            rowToItem(row);
            updateFields();*/
        }


        private void rowToItem(DataGridViewRow row)
        {
           selectedItem.itemNo = row.Cells[0].Value.ToString();
           selectedItem.itemDescription = row.Cells[1].Value.ToString();
           selectedItem.itemUOM = row.Cells[2].Value.ToString();
           selectedItem.priceGroup = row.Cells[3].Value.ToString();
           selectedItem.lastCost = float.Parse(row.Cells[4].Value.ToString() == null || String.IsNullOrEmpty(row.Cells[4].Value.ToString()) ? "0" : row.Cells[4].Value.ToString());
           selectedItem.costMarginVariationAllowed = float.Parse(row.Cells[5].Value.ToString());
           selectedItem.roundingMethod = Int16.Parse(row.Cells[6].Value.ToString());
           selectedItem.lastPriceChangeDate = Convert.ToDateTime(row.Cells[7].Value.ToString() == null || String.IsNullOrEmpty(row.Cells[7].Value.ToString()) ? "2001-01-01" : row.Cells[7].Value.ToString());
           selectedItem.salesPriceMarging = float.Parse(row.Cells[8].Value.ToString());
           selectedItem.priceBeforeChange = float.Parse(row.Cells[9].Value.ToString() == null || String.IsNullOrEmpty(row.Cells[9].Value.ToString()) ? "0" : row.Cells[9].Value.ToString());
           selectedItem.lastPriceSetted = float.Parse(row.Cells[10].Value.ToString() == null || String.IsNullOrEmpty(row.Cells[10].Value.ToString()) ? "0" : row.Cells[10].Value.ToString());
           selectedItem.deleted = Boolean.Parse(row.Cells[11].Value.ToString());
           selectedItem.deletedDate = Convert.ToDateTime(row.Cells[12].Value.ToString() == null || String.IsNullOrEmpty(row.Cells[12].Value.ToString()) ? "2001-01-01" : row.Cells[12].Value.ToString());
           selectedItem.labelRequired = Boolean.Parse(row.Cells[13].Value.ToString());
           selectedItem.excludeForPriceChange = Boolean.Parse(row.Cells[14].Value.ToString());
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            rowToItem(row);
            updateFields();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxPriceMargin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (selectedItem == null || selectedItem.itemNo == null || String.IsNullOrEmpty(selectedItem.itemNo))
            {
                MessageBox.Show("No puede guardarse información en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String query = String.Format("update APC_MASTER set cost_variation_margin_allowed = {0},\n"+
                "rounding = {1}, sales_price_margin = {2}, label_required={3}, exclude_for_pricing_change = {4}\n"+
                "where item_id='{5}' and unit_of_measure_code='{6}' and price_group='{7}'",
                maskedTextBoxCostMargin.Text,
                comboRounding.SelectedIndex+1, maskedTextBoxPriceMargin.Text, checkBoxTicketRequired.Checked ? 1 : 0, checkBoxExlude.Checked ? 1: 0,
                selectedItem.itemNo,selectedItem.itemUOM,selectedItem.priceGroup);

            //MessageBox.Show(query);

            DBConnection.executeOnTable(query);

            reloadItems();

        }

        private void reloadItems()
        {

            List<ItemMaster> itemsList = new List<ItemMaster>();
            DataTable dt = new DataTable();
            //Query viejo para trabaja para NAV 2015, version original en la cual se creó esta aplicacion
            //String query = "select top 100 Item.description,APC_MASTER.* from APC_MASTER inner join Item on Item.[No_] =APC_MASTER.item_id";

            //Query adaptado para trabajar con BC 27
            String query = "SELECT TOP 100 i.[Description],APC_MASTER.* FROM APC_MASTER " +
               "INNER JOIN [dbo].[HLF$Item$437dbf0e-84ff-417a-965d-ed2bb9650972] i on i.[No_] =APC_MASTER.item_id;";


            dt = DBConnection.queryTable(query);
            foreach (DataRow row in dt.Rows)
            {
                ItemMaster item = new ItemMaster();

                item.itemDescription = row[0].ToString();
                item.id = Convert.ToInt64(row[1].ToString());
                item.itemNo = row[2].ToString();
                item.itemUOM = row[3].ToString();
                item.priceGroup = row[4].ToString();
                item.lastCost = float.Parse(row[5].ToString());
                item.costMarginVariationAllowed = float.Parse(row[6].ToString());
                item.roundingMethod = Convert.ToInt16(row[7].ToString());
                item.lastPriceChangeDate = Convert.ToDateTime(row[8].ToString() == null || String.IsNullOrEmpty(row[8].ToString()) ? "2001-01-01" : row[8].ToString());
                item.salesPriceMarging = float.Parse(row[9].ToString());
                item.priceBeforeChange = float.Parse(row[10].ToString() == null || String.IsNullOrEmpty(row[10].ToString()) ? "0" : row[10].ToString());
                item.lastPriceSetted = float.Parse(row[11].ToString() == null || String.IsNullOrEmpty(row[11].ToString()) ? "0" : row[11].ToString());
                item.deleted = Convert.ToBoolean(row[12].ToString());
                item.deletedDate = Convert.ToDateTime(row[13].ToString() == null || String.IsNullOrEmpty(row[13].ToString()) ? "2001-01-01" : row[13].ToString());
                item.labelRequired = Convert.ToBoolean(row[14].ToString());
                item.excludeForPriceChange = Convert.ToBoolean(row[15].ToString());
                //MessageBox.Show(item.itemDescription, "Aviso");
                itemsList.Add(item);
            }

            //dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = itemsList;
            dataGridView1.Refresh();
        }


    }
    
}
