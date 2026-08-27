namespace APC_NAV
{
    partial class ApprovedPrices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugestionGenerationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newSugestedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costVariation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugestionStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceAssignedTochange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceChangeMargin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastStatusGenerationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatPercet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVendorInvoiceList = new System.Windows.Forms.ComboBox();
            this.lblOutStandingTotal = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.itemSugestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSugestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemNo,
            this.itemDescription,
            this.itemUOM,
            this.priceGroup,
            this.sugestionGenerationTime,
            this.previousCost,
            this.newCost,
            this.previousPrice,
            this.newSugestedPrice,
            this.costVariation,
            this.sugestionStatus,
            this.priceAssignedTochange,
            this.priceChangeMargin,
            this.lastStatusGenerationTime,
            this.vatPercet,
            this.quantity,
            this.userID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1707, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID sugerencia";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // itemNo
            // 
            this.itemNo.DataPropertyName = "itemNo";
            this.itemNo.HeaderText = "Item No,";
            this.itemNo.Name = "itemNo";
            this.itemNo.ReadOnly = true;
            this.itemNo.Width = 50;
            // 
            // itemDescription
            // 
            this.itemDescription.DataPropertyName = "itemDescription";
            this.itemDescription.HeaderText = "Descripción";
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.ReadOnly = true;
            this.itemDescription.Width = 300;
            // 
            // itemUOM
            // 
            this.itemUOM.DataPropertyName = "itemUOM";
            this.itemUOM.HeaderText = "UDM";
            this.itemUOM.Name = "itemUOM";
            this.itemUOM.ReadOnly = true;
            this.itemUOM.Width = 40;
            // 
            // priceGroup
            // 
            this.priceGroup.DataPropertyName = "priceGroup";
            this.priceGroup.HeaderText = "Grupo de precios";
            this.priceGroup.Name = "priceGroup";
            this.priceGroup.ReadOnly = true;
            // 
            // sugestionGenerationTime
            // 
            this.sugestionGenerationTime.DataPropertyName = "sugestionGenerationTime";
            this.sugestionGenerationTime.HeaderText = "Hora de generación";
            this.sugestionGenerationTime.Name = "sugestionGenerationTime";
            this.sugestionGenerationTime.ReadOnly = true;
            this.sugestionGenerationTime.Width = 80;
            // 
            // previousCost
            // 
            this.previousCost.DataPropertyName = "previousCost";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.previousCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.previousCost.HeaderText = "Costo previo";
            this.previousCost.Name = "previousCost";
            this.previousCost.ReadOnly = true;
            this.previousCost.Width = 60;
            // 
            // newCost
            // 
            this.newCost.DataPropertyName = "newCost";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.newCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.newCost.HeaderText = "Nuevo costo";
            this.newCost.Name = "newCost";
            this.newCost.ReadOnly = true;
            this.newCost.Width = 60;
            // 
            // previousPrice
            // 
            this.previousPrice.DataPropertyName = "previousPrice";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.previousPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.previousPrice.HeaderText = "Precio actual";
            this.previousPrice.Name = "previousPrice";
            this.previousPrice.ReadOnly = true;
            this.previousPrice.Width = 60;
            // 
            // newSugestedPrice
            // 
            this.newSugestedPrice.DataPropertyName = "newSugestedPrice";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.newSugestedPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.newSugestedPrice.HeaderText = "Precio sugerido";
            this.newSugestedPrice.Name = "newSugestedPrice";
            this.newSugestedPrice.ReadOnly = true;
            this.newSugestedPrice.Width = 60;
            // 
            // costVariation
            // 
            this.costVariation.DataPropertyName = "costVariation";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.costVariation.DefaultCellStyle = dataGridViewCellStyle5;
            this.costVariation.HeaderText = "% Variación";
            this.costVariation.Name = "costVariation";
            this.costVariation.ReadOnly = true;
            this.costVariation.Width = 60;
            // 
            // sugestionStatus
            // 
            this.sugestionStatus.DataPropertyName = "sugestionStatus";
            this.sugestionStatus.HeaderText = "Acción";
            this.sugestionStatus.Items.AddRange(new object[] {
            "No realizar cambio",
            "Realizar cambio",
            "Excluir de pendientes"});
            this.sugestionStatus.Name = "sugestionStatus";
            // 
            // priceAssignedTochange
            // 
            this.priceAssignedTochange.DataPropertyName = "priceAssignedTochange";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.priceAssignedTochange.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceAssignedTochange.HeaderText = "Precio asignado";
            this.priceAssignedTochange.Name = "priceAssignedTochange";
            // 
            // priceChangeMargin
            // 
            this.priceChangeMargin.DataPropertyName = "priceChangeMargin";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.priceChangeMargin.DefaultCellStyle = dataGridViewCellStyle7;
            this.priceChangeMargin.HeaderText = "% Margen";
            this.priceChangeMargin.Name = "priceChangeMargin";
            this.priceChangeMargin.ReadOnly = true;
            // 
            // lastStatusGenerationTime
            // 
            this.lastStatusGenerationTime.DataPropertyName = "lastStatusGenerationTime";
            this.lastStatusGenerationTime.HeaderText = "Fecha ultimo cambio";
            this.lastStatusGenerationTime.Name = "lastStatusGenerationTime";
            this.lastStatusGenerationTime.ReadOnly = true;
            this.lastStatusGenerationTime.Width = 80;
            // 
            // vatPercet
            // 
            this.vatPercet.DataPropertyName = "vatPercet";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.vatPercet.DefaultCellStyle = dataGridViewCellStyle8;
            this.vatPercet.HeaderText = "ITBIS";
            this.vatPercet.Name = "vatPercet";
            this.vatPercet.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle9;
            this.quantity.HeaderText = "Cantidad";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.userID.DefaultCellStyle = dataGridViewCellStyle10;
            this.userID.HeaderText = "Usuario";
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factura:";
            // 
            // comboBoxVendorInvoiceList
            // 
            this.comboBoxVendorInvoiceList.BackColor = System.Drawing.Color.White;
            this.comboBoxVendorInvoiceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVendorInvoiceList.FormattingEnabled = true;
            this.comboBoxVendorInvoiceList.Location = new System.Drawing.Point(86, 187);
            this.comboBoxVendorInvoiceList.Name = "comboBoxVendorInvoiceList";
            this.comboBoxVendorInvoiceList.Size = new System.Drawing.Size(465, 21);
            this.comboBoxVendorInvoiceList.TabIndex = 3;
            this.comboBoxVendorInvoiceList.SelectedIndexChanged += new System.EventHandler(this.comboBoxVendorInvoiceList_SelectedIndexChanged);
            // 
            // lblOutStandingTotal
            // 
            this.lblOutStandingTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutStandingTotal.AutoSize = true;
            this.lblOutStandingTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutStandingTotal.ForeColor = System.Drawing.Color.Red;
            this.lblOutStandingTotal.Location = new System.Drawing.Point(699, 9);
            this.lblOutStandingTotal.Name = "lblOutStandingTotal";
            this.lblOutStandingTotal.Size = new System.Drawing.Size(19, 29);
            this.lblOutStandingTotal.TabIndex = 5;
            this.lblOutStandingTotal.Text = ".";
            this.lblOutStandingTotal.Click += new System.EventHandler(this.lblOutStandingTotal_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1511, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 54);
            this.button4.TabIndex = 8;
            this.button4.Text = "Excluir todos de pendientes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cambios de precios aprobados (Pendientes de cambio)";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::APC_NAV.Properties.Resources.include;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1511, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 57);
            this.button3.TabIndex = 7;
            this.button3.Text = "No realizar cambios a aprobación";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APC_NAV.Properties.Resources.LOGO_HIPERMERCADO_LA_FUENTE_2_png;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::APC_NAV.Properties.Resources.icon_flash_512;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1534, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ejecutar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::APC_NAV.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(557, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recargar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemSugestionBindingSource
            // 
            this.itemSugestionBindingSource.DataSource = typeof(APC_NAV.ItemSugestion);
            // 
            // itemMasterBindingSource
            // 
            this.itemMasterBindingSource.DataSource = typeof(APC_NAV.ItemMaster);
            // 
            // ApprovedPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1731, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOutStandingTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxVendorInvoiceList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApprovedPrices";
            this.Text = "Precios aprobados";
            this.Load += new System.EventHandler(this.ApprovedPrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSugestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemMasterBindingSource;
        private System.Windows.Forms.BindingSource itemSugestionBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVendorInvoiceList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOutStandingTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn sugestionGenerationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn newSugestedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn costVariation;
        private System.Windows.Forms.DataGridViewComboBoxColumn sugestionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceAssignedTochange;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceChangeMargin;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastStatusGenerationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatPercet;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
    }
}