namespace OOO_Shoes.Views
{
	partial class FormProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
			this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.labelOrganisationName = new System.Windows.Forms.Label();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.panelProducts = new System.Windows.Forms.Panel();
			this.tlpFilters = new System.Windows.Forms.TableLayoutPanel();
			this.labelDiscount = new System.Windows.Forms.Label();
			this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
			this.labelSortBy = new System.Windows.Forms.Label();
			this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.labelProductCount = new System.Windows.Forms.Label();
			this.btnCreateProduct = new System.Windows.Forms.Button();
			this.tlpHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.tlpFilters.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpHeader
			// 
			this.tlpHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpHeader.ColumnCount = 3;
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlpHeader.Controls.Add(this.btnExit, 2, 0);
			this.tlpHeader.Controls.Add(this.labelOrganisationName, 1, 0);
			this.tlpHeader.Controls.Add(this.pbLogo, 0, 0);
			this.tlpHeader.Location = new System.Drawing.Point(2, 0);
			this.tlpHeader.Name = "tlpHeader";
			this.tlpHeader.RowCount = 1;
			this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpHeader.Size = new System.Drawing.Size(802, 83);
			this.tlpHeader.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExit.Location = new System.Drawing.Point(724, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 77);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Выход";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// labelOrganisationName
			// 
			this.labelOrganisationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelOrganisationName.AutoSize = true;
			this.labelOrganisationName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrganisationName.Location = new System.Drawing.Point(83, 0);
			this.labelOrganisationName.Name = "labelOrganisationName";
			this.labelOrganisationName.Size = new System.Drawing.Size(635, 83);
			this.labelOrganisationName.TabIndex = 1;
			this.labelOrganisationName.Text = "ООО \"Обувь\"";
			this.labelOrganisationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbLogo
			// 
			this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbLogo.Image = global::OOO_Shoes.Properties.Resources.logo;
			this.pbLogo.Location = new System.Drawing.Point(3, 3);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(74, 77);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 1;
			this.pbLogo.TabStop = false;
			// 
			// panelProducts
			// 
			this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.panelProducts.Location = new System.Drawing.Point(2, 141);
			this.panelProducts.Name = "panelProducts";
			this.panelProducts.Size = new System.Drawing.Size(802, 323);
			this.panelProducts.TabIndex = 2;
			// 
			// tlpFilters
			// 
			this.tlpFilters.ColumnCount = 5;
			this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpFilters.Controls.Add(this.labelDiscount, 2, 0);
			this.tlpFilters.Controls.Add(this.comboBoxDiscount, 3, 0);
			this.tlpFilters.Controls.Add(this.labelSortBy, 0, 0);
			this.tlpFilters.Controls.Add(this.comboBoxSortBy, 1, 0);
			this.tlpFilters.Controls.Add(this.labelProductName, 0, 1);
			this.tlpFilters.Controls.Add(this.textBoxProductName, 1, 1);
			this.tlpFilters.Controls.Add(this.labelProductCount, 2, 1);
			this.tlpFilters.Location = new System.Drawing.Point(5, 86);
			this.tlpFilters.Name = "tlpFilters";
			this.tlpFilters.RowCount = 2;
			this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpFilters.Size = new System.Drawing.Size(796, 84);
			this.tlpFilters.TabIndex = 3;
			// 
			// labelDiscount
			// 
			this.labelDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDiscount.AutoSize = true;
			this.labelDiscount.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDiscount.Location = new System.Drawing.Point(323, 13);
			this.labelDiscount.Name = "labelDiscount";
			this.labelDiscount.Size = new System.Drawing.Size(49, 15);
			this.labelDiscount.TabIndex = 2;
			this.labelDiscount.Text = "Скидка:";
			this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxDiscount
			// 
			this.comboBoxDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxDiscount.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxDiscount.FormattingEnabled = true;
			this.comboBoxDiscount.Location = new System.Drawing.Point(378, 9);
			this.comboBoxDiscount.Name = "comboBoxDiscount";
			this.comboBoxDiscount.Size = new System.Drawing.Size(204, 23);
			this.comboBoxDiscount.TabIndex = 3;
			// 
			// labelSortBy
			// 
			this.labelSortBy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelSortBy.AutoSize = true;
			this.labelSortBy.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSortBy.Location = new System.Drawing.Point(19, 13);
			this.labelSortBy.Name = "labelSortBy";
			this.labelSortBy.Size = new System.Drawing.Size(71, 15);
			this.labelSortBy.TabIndex = 0;
			this.labelSortBy.Text = "Стоимость:";
			this.labelSortBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxSortBy
			// 
			this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSortBy.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxSortBy.FormattingEnabled = true;
			this.comboBoxSortBy.Location = new System.Drawing.Point(113, 9);
			this.comboBoxSortBy.Name = "comboBoxSortBy";
			this.comboBoxSortBy.Size = new System.Drawing.Size(204, 23);
			this.comboBoxSortBy.TabIndex = 1;
			// 
			// labelProductName
			// 
			this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelProductName.AutoSize = true;
			this.labelProductName.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelProductName.Location = new System.Drawing.Point(3, 55);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(104, 15);
			this.labelProductName.TabIndex = 5;
			this.labelProductName.Text = "Название товара:";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxProductName.Location = new System.Drawing.Point(113, 52);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(204, 21);
			this.textBoxProductName.TabIndex = 4;
			// 
			// labelProductCount
			// 
			this.labelProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelProductCount.AutoSize = true;
			this.tlpFilters.SetColumnSpan(this.labelProductCount, 2);
			this.labelProductCount.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelProductCount.Location = new System.Drawing.Point(323, 55);
			this.labelProductCount.Name = "labelProductCount";
			this.labelProductCount.Size = new System.Drawing.Size(259, 15);
			this.labelProductCount.TabIndex = 6;
			this.labelProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCreateProduct
			// 
			this.btnCreateProduct.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreateProduct.Location = new System.Drawing.Point(12, 476);
			this.btnCreateProduct.Name = "btnCreateProduct";
			this.btnCreateProduct.Size = new System.Drawing.Size(156, 30);
			this.btnCreateProduct.TabIndex = 4;
			this.btnCreateProduct.Text = "Создать товар";
			this.btnCreateProduct.UseVisualStyleBackColor = true;
			this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateOrder_Click);
			// 
			// FormProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 518);
			this.Controls.Add(this.btnCreateProduct);
			this.Controls.Add(this.tlpFilters);
			this.Controls.Add(this.panelProducts);
			this.Controls.Add(this.tlpHeader);
			this.Font = new System.Drawing.Font("Candara Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(820, 489);
			this.Name = "FormProducts";
			this.Text = "ООО \"Обувь\"";
			this.Load += new System.EventHandler(this.FormProducts_Load);
			this.tlpHeader.ResumeLayout(false);
			this.tlpHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.tlpFilters.ResumeLayout(false);
			this.tlpFilters.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpHeader;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label labelOrganisationName;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Panel panelProducts;
		private System.Windows.Forms.TableLayoutPanel tlpFilters;
		private System.Windows.Forms.Label labelSortBy;
		private System.Windows.Forms.ComboBox comboBoxSortBy;
		private System.Windows.Forms.Label labelDiscount;
		private System.Windows.Forms.ComboBox comboBoxDiscount;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelProductCount;
		private System.Windows.Forms.Button btnCreateProduct;
	}
}