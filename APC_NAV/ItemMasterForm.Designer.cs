namespace APC_NAV
{
    partial class ItemMasterForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPriceGroup = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxCostMargin = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxExlude = new System.Windows.Forms.CheckBox();
            this.checkBoxTicketRequired = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDeleted = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxDeleted = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxLastAssignedPrice = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBoxLastPrice = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxPriceMargin = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerLastChange = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboRounding = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastCost = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUOM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costMarginVariationAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundingMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPriceChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPriceMarging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBeforeChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPriceSetted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deletedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRequired = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.excludeForPriceChange = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPriceGroup);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.maskedTextBoxCostMargin);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxExlude);
            this.groupBox1.Controls.Add(this.checkBoxTicketRequired);
            this.groupBox1.Controls.Add(this.dateTimePickerDeleted);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.checkBoxDeleted);
            this.groupBox1.Controls.Add(this.maskedTextBoxLastAssignedPrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.maskedTextBoxLastPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.maskedTextBoxPriceMargin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePickerLastChange);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboRounding);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLastCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUOM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edición";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPriceGroup
            // 
            this.txtPriceGroup.AcceptsReturn = true;
            this.txtPriceGroup.Location = new System.Drawing.Point(223, 103);
            this.txtPriceGroup.Name = "txtPriceGroup";
            this.txtPriceGroup.ReadOnly = true;
            this.txtPriceGroup.Size = new System.Drawing.Size(212, 22);
            this.txtPriceGroup.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Grupo de precios:";
            // 
            // maskedTextBoxCostMargin
            // 
            this.maskedTextBoxCostMargin.Location = new System.Drawing.Point(223, 159);
            this.maskedTextBoxCostMargin.Name = "maskedTextBoxCostMargin";
            this.maskedTextBoxCostMargin.Size = new System.Drawing.Size(181, 22);
            this.maskedTextBoxCostMargin.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxExlude
            // 
            this.checkBoxExlude.AutoSize = true;
            this.checkBoxExlude.Location = new System.Drawing.Point(635, 211);
            this.checkBoxExlude.Name = "checkBoxExlude";
            this.checkBoxExlude.Size = new System.Drawing.Size(154, 20);
            this.checkBoxExlude.TabIndex = 25;
            this.checkBoxExlude.Text = "Excluir sugerencia";
            this.checkBoxExlude.UseVisualStyleBackColor = true;
            // 
            // checkBoxTicketRequired
            // 
            this.checkBoxTicketRequired.AutoSize = true;
            this.checkBoxTicketRequired.Location = new System.Drawing.Point(635, 185);
            this.checkBoxTicketRequired.Name = "checkBoxTicketRequired";
            this.checkBoxTicketRequired.Size = new System.Drawing.Size(141, 20);
            this.checkBoxTicketRequired.TabIndex = 24;
            this.checkBoxTicketRequired.Text = "Ticket requerido";
            this.checkBoxTicketRequired.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDeleted
            // 
            this.dateTimePickerDeleted.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerDeleted.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDeleted.Enabled = false;
            this.dateTimePickerDeleted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeleted.Location = new System.Drawing.Point(635, 131);
            this.dateTimePickerDeleted.Name = "dateTimePickerDeleted";
            this.dateTimePickerDeleted.Size = new System.Drawing.Size(182, 22);
            this.dateTimePickerDeleted.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(481, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fecha de eliminado:";
            // 
            // checkBoxDeleted
            // 
            this.checkBoxDeleted.AutoSize = true;
            this.checkBoxDeleted.Enabled = false;
            this.checkBoxDeleted.Location = new System.Drawing.Point(635, 159);
            this.checkBoxDeleted.Name = "checkBoxDeleted";
            this.checkBoxDeleted.Size = new System.Drawing.Size(96, 20);
            this.checkBoxDeleted.TabIndex = 21;
            this.checkBoxDeleted.Text = "Eliminado";
            this.checkBoxDeleted.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxLastAssignedPrice
            // 
            this.maskedTextBoxLastAssignedPrice.Location = new System.Drawing.Point(636, 99);
            this.maskedTextBoxLastAssignedPrice.Name = "maskedTextBoxLastAssignedPrice";
            this.maskedTextBoxLastAssignedPrice.ReadOnly = true;
            this.maskedTextBoxLastAssignedPrice.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBoxLastAssignedPrice.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Último precio asignado:";
            // 
            // maskedTextBoxLastPrice
            // 
            this.maskedTextBoxLastPrice.Location = new System.Drawing.Point(636, 75);
            this.maskedTextBoxLastPrice.Name = "maskedTextBoxLastPrice";
            this.maskedTextBoxLastPrice.ReadOnly = true;
            this.maskedTextBoxLastPrice.Size = new System.Drawing.Size(181, 22);
            this.maskedTextBoxLastPrice.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Precio antes de cambio:";
            // 
            // maskedTextBoxPriceMargin
            // 
            this.maskedTextBoxPriceMargin.Location = new System.Drawing.Point(636, 47);
            this.maskedTextBoxPriceMargin.Name = "maskedTextBoxPriceMargin";
            this.maskedTextBoxPriceMargin.Size = new System.Drawing.Size(181, 22);
            this.maskedTextBoxPriceMargin.TabIndex = 16;
            this.maskedTextBoxPriceMargin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxPriceMargin_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Margen de precio:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimePickerLastChange
            // 
            this.dateTimePickerLastChange.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePickerLastChange.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerLastChange.Enabled = false;
            this.dateTimePickerLastChange.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLastChange.Location = new System.Drawing.Point(637, 23);
            this.dateTimePickerLastChange.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerLastChange.Name = "dateTimePickerLastChange";
            this.dateTimePickerLastChange.Size = new System.Drawing.Size(182, 22);
            this.dateTimePickerLastChange.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de último cambio:";
            // 
            // comboRounding
            // 
            this.comboRounding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRounding.FormattingEnabled = true;
            this.comboRounding.Items.AddRange(new object[] {
            "Entero",
            ".99",
            ".99 Arriba"});
            this.comboRounding.Location = new System.Drawing.Point(223, 185);
            this.comboRounding.Name = "comboRounding";
            this.comboRounding.Size = new System.Drawing.Size(181, 24);
            this.comboRounding.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rounding:";
            // 
            // txtLastCost
            // 
            this.txtLastCost.Location = new System.Drawing.Point(222, 131);
            this.txtLastCost.Name = "txtLastCost";
            this.txtLastCost.ReadOnly = true;
            this.txtLastCost.Size = new System.Drawing.Size(212, 22);
            this.txtLastCost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Margen de costo permitido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Último costo:";
            // 
            // txtUOM
            // 
            this.txtUOM.AcceptsReturn = true;
            this.txtUOM.Location = new System.Drawing.Point(223, 78);
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.ReadOnly = true;
            this.txtUOM.Size = new System.Drawing.Size(212, 22);
            this.txtUOM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "UOM:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(223, 50);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(214, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(223, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(97, 22);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNo,
            this.itemDescription,
            this.itemUOM,
            this.priceGroup,
            this.lastCost,
            this.costMarginVariationAllowed,
            this.roundingMethod,
            this.lastPriceChangeDate,
            this.salesPriceMarging,
            this.priceBeforeChange,
            this.lastPriceSetted,
            this.deleted,
            this.deletedDate,
            this.labelRequired,
            this.excludeForPriceChange});
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 277);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // itemNo
            // 
            this.itemNo.DataPropertyName = "itemNo";
            this.itemNo.HeaderText = "Item ID";
            this.itemNo.Name = "itemNo";
            this.itemNo.ReadOnly = true;
            // 
            // itemDescription
            // 
            this.itemDescription.DataPropertyName = "itemDescription";
            this.itemDescription.HeaderText = "Descripción";
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.ReadOnly = true;
            // 
            // itemUOM
            // 
            this.itemUOM.DataPropertyName = "itemUOM";
            this.itemUOM.HeaderText = "UDM";
            this.itemUOM.Name = "itemUOM";
            this.itemUOM.ReadOnly = true;
            // 
            // priceGroup
            // 
            this.priceGroup.DataPropertyName = "priceGroup";
            this.priceGroup.HeaderText = "Grupo precios";
            this.priceGroup.Name = "priceGroup";
            this.priceGroup.ReadOnly = true;
            // 
            // lastCost
            // 
            this.lastCost.DataPropertyName = "lastCost";
            this.lastCost.HeaderText = "Ultimo costo";
            this.lastCost.Name = "lastCost";
            this.lastCost.ReadOnly = true;
            // 
            // costMarginVariationAllowed
            // 
            this.costMarginVariationAllowed.DataPropertyName = "costMarginVariationAllowed";
            this.costMarginVariationAllowed.HeaderText = "Margen de costo";
            this.costMarginVariationAllowed.Name = "costMarginVariationAllowed";
            this.costMarginVariationAllowed.ReadOnly = true;
            // 
            // roundingMethod
            // 
            this.roundingMethod.DataPropertyName = "roundingMethod";
            this.roundingMethod.HeaderText = "Methodo de redondeo";
            this.roundingMethod.Name = "roundingMethod";
            this.roundingMethod.ReadOnly = true;
            // 
            // lastPriceChangeDate
            // 
            this.lastPriceChangeDate.DataPropertyName = "lastPriceChangeDate";
            this.lastPriceChangeDate.HeaderText = "Fecha ultimo cambio de precio";
            this.lastPriceChangeDate.Name = "lastPriceChangeDate";
            this.lastPriceChangeDate.ReadOnly = true;
            // 
            // salesPriceMarging
            // 
            this.salesPriceMarging.DataPropertyName = "salesPriceMarging";
            this.salesPriceMarging.HeaderText = "Margen de precio";
            this.salesPriceMarging.Name = "salesPriceMarging";
            this.salesPriceMarging.ReadOnly = true;
            // 
            // priceBeforeChange
            // 
            this.priceBeforeChange.DataPropertyName = "priceBeforeChange";
            this.priceBeforeChange.HeaderText = "Precio anterior";
            this.priceBeforeChange.Name = "priceBeforeChange";
            this.priceBeforeChange.ReadOnly = true;
            // 
            // lastPriceSetted
            // 
            this.lastPriceSetted.DataPropertyName = "lastPriceSetted";
            this.lastPriceSetted.HeaderText = "Ultimo precio asignado";
            this.lastPriceSetted.Name = "lastPriceSetted";
            this.lastPriceSetted.ReadOnly = true;
            // 
            // deleted
            // 
            this.deleted.DataPropertyName = "deleted";
            this.deleted.HeaderText = "Eliminado";
            this.deleted.Name = "deleted";
            this.deleted.ReadOnly = true;
            // 
            // deletedDate
            // 
            this.deletedDate.DataPropertyName = "deletedDate";
            this.deletedDate.HeaderText = "Fecha de eliminacion";
            this.deletedDate.Name = "deletedDate";
            this.deletedDate.ReadOnly = true;
            // 
            // labelRequired
            // 
            this.labelRequired.DataPropertyName = "labelRequired";
            this.labelRequired.HeaderText = "Requiere etiqueta";
            this.labelRequired.Name = "labelRequired";
            this.labelRequired.ReadOnly = true;
            // 
            // excludeForPriceChange
            // 
            this.excludeForPriceChange.DataPropertyName = "excludeForPriceChange";
            this.excludeForPriceChange.HeaderText = "Excluir de sugerencias";
            this.excludeForPriceChange.Name = "excludeForPriceChange";
            this.excludeForPriceChange.ReadOnly = true;
            this.excludeForPriceChange.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.excludeForPriceChange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // itemMasterBindingSource
            // 
            this.itemMasterBindingSource.DataSource = typeof(APC_NAV.ItemMaster);
            // 
            // ItemMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemMasterForm";
            this.Text = "Maestro de producto";
            this.Load += new System.EventHandler(this.ItemMasterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeleted;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxDeleted;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLastAssignedPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLastPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPriceMargin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastChange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboRounding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtLastCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxExlude;
        private System.Windows.Forms.CheckBox checkBoxTicketRequired;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemMasterBindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCostMargin;
        private System.Windows.Forms.TextBox txtPriceGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn costMarginVariationAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundingMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPriceChangeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPriceMarging;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceBeforeChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPriceSetted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn labelRequired;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excludeForPriceChange;
    }
}