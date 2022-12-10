using OOO_Shoes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Shoes.Views
{
	public partial class FormProductinformation : Form
	{
		Product product;
		public FormProductinformation(Product product)
		{
			this.product = product;
			InitializeComponent();
		
			tlpHeader.BackColor = Color.FromArgb(Convert.ToInt16("B3", 16), Convert.ToInt16("F4", 16), Convert.ToInt16("E9", 16));
			btnBack.BackColor = Color.FromArgb(Convert.ToInt16("A5", 16), Convert.ToInt16("E8", 16), Convert.ToInt16("87", 16));
		
		}

		private void FormProductinformation_Load(object sender, EventArgs e)
		{
			tbArticul.Text = product.ProductArticle;
			tbName.Text = product.ProductName;
			tbCategory.Text = product.Category.CategoryName;
			tbManufacturer.Text = product.Manufacturer.ManufacturerName;
			tbMeasurement.Text = product.MeasurementUnit.MeasurementUnitName;
			tbVendor.Text = product.Vendor.VendorName;
			numMaxDiscount.Value = product.ProductMaximumDiscount;
			numCurDiscount.Value = product.ProductDiscountAmount;
			numCost.Value = product.ProductCost;
			numQuantity.Value = product.ProductCost;
			rtbDescription.Text = product.ProductDescription;

			if (!(product.ProductPhoto == null))
			{
				pbImage.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\" + product.ProductPhoto);
			}
			else
			{
				pbImage.Image = Properties.Resources.picture;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void labelOrganisationName_Click(object sender, EventArgs e)
		{

		}
	}
}
