using OOO_Shoes.CustomViewElements;
using OOO_Shoes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Shoes.Views
{
	public partial class FormProducts : Form
	{
		string _userRole;
		int totalRows = 0;

		public FormProducts(string userRole)
		{
			_userRole = userRole;
			InitializeComponent();
			tlpHeader.BackColor = Color.FromArgb(Convert.ToInt16("B3", 16), Convert.ToInt16("F4", 16), Convert.ToInt16("E9", 16));
			btnExit.BackColor = Color.FromArgb(Convert.ToInt16("A5", 16), Convert.ToInt16("E8", 16), Convert.ToInt16("87", 16));
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{
			if (_userRole != "Администратор")
			{
				btnCreateProduct.Enabled = false;
				btnCreateProduct.Visible = false;
			}
			else
			{
				btnCreateProduct.Enabled = true;
				btnCreateProduct.Visible = true;
			}

			comboBoxSortBy.Items.Add("По возрастанию");
			comboBoxSortBy.Items.Add("По убыванию");
			comboBoxSortBy.SelectedIndex = 0;

			comboBoxDiscount.Items.Add("Все диапазоны");
			comboBoxDiscount.Items.Add("0-10%");
			comboBoxDiscount.Items.Add("11-14%");
			comboBoxDiscount.Items.Add("15% и более");
			comboBoxDiscount.SelectedIndex = 1;

			comboBoxSortBy.SelectedIndexChanged += comboBoxDiscount_SelectedIndexChanged;
			comboBoxDiscount.SelectedIndexChanged += comboBoxDiscount_SelectedIndexChanged;
			textBoxProductName.TextChanged += comboBoxDiscount_SelectedIndexChanged;

			panelProducts.AutoScroll = true;

			getProductsFromDB();

		}

		private void comboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
		{
			getProductsFromDB();
		}


		private void getProductsFromDB()
		{
			bool byDescending = comboBoxSortBy.SelectedItem.ToString() == "По убыванию" ? true : false;
			int startDiscount = 0;
			int endDiscount = 100;
			string productName = textBoxProductName.Text;

			switch (comboBoxDiscount.SelectedIndex)
			{
				case 2:
					endDiscount = 10;
					break;

				case 3:
					startDiscount = 11;
					endDiscount = 14;
					break;
				case 4:
					startDiscount = 15;
					break;
			}
			//!!
			var products = Helper.MyDBContext.context.Product.Where(
			   p => (p.ProductName.Contains(productName)
			&& p.ProductDiscountAmount >= startDiscount
			&& p.ProductDiscountAmount <= endDiscount)).ToList();

			totalRows = products.Count();

			if (byDescending)
			{
				products.OrderByDescending(p => p.ProductCost).ToList();
			}
			else
			{
				products.OrderBy(p => p.ProductCost).ToList();
			}

			List<Product> pr = products.ToList();

			SetProductsToPanel(pr);
		}

		private void SetProductsToPanel(List<Product> products)
		{
			panelProducts.Controls.Clear();
			int pos = 0;
			int startPanel = 5;
			foreach (Product product in products)
			{
				ProductPanel prodPanel = new ProductPanel(product, panelProducts);
				prodPanel.Tag = product;
				prodPanel.Location = new Point(0 , pos++ * prodPanel.Height + startPanel);
				
				panelProducts.Controls.Add(prodPanel);
				//prodPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
				prodPanel.DoubleClick += productDoubleClick;
			}
			labelProductCount .Text = $"Найдено: {products.Count} из {totalRows}";
		}



		public void productDoubleClick(object sender, EventArgs e)
		{
			ProductPanel prodPanel = sender as ProductPanel;
			Product p = (Product)prodPanel.Tag;
			if (_userRole == "Администратор")
			{
				Form form = new ProductEdit(p);
				this.Hide();
				form.ShowDialog();
				form.Dispose();
				this.Show();
				getProductsFromDB();

			}
			else
			{
				Form form = new FormProductinformation(p);
				this.Hide();
				form.ShowDialog();
				form.Dispose();
				this.Show();
				getProductsFromDB();

			}
		
		}

		private void btnCreateOrder_Click(object sender, EventArgs e)
		{
			if (_userRole != "Администратор")
			{
				MessageBox.Show("Недостаточно прав","Ошибка");
			}
			Form form = new ProductEdit(null);
			this.Hide();
			form.ShowDialog();
			form.Dispose();
			this.Show();
			getProductsFromDB();

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
