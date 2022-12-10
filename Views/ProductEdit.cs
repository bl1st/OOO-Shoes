using OOO_Shoes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Shoes.Views
{
	public partial class ProductEdit : Form
	{
		Product product;
		string pictureName = null;
		public ProductEdit(Product product)
		{
			this.product = product;
			InitializeComponent();
		}

		private void ProductEdit_Load(object sender, EventArgs e)
		{
			btnDelete.BackColor = Color.FromArgb(Convert.ToInt16("A5", 16), Convert.ToInt16("E8", 16), Convert.ToInt16("87", 16));
			btnSave.BackColor = Color.FromArgb(Convert.ToInt16("A5", 16), Convert.ToInt16("E8", 16), Convert.ToInt16("87", 16));
			btnAddPic.BackColor = Color.FromArgb(Convert.ToInt16("A5", 16), Convert.ToInt16("E8", 16), Convert.ToInt16("87", 16));
			tlpHeader.BackColor = Color.FromArgb(Convert.ToInt16("B3", 16), Convert.ToInt16("F4", 16), Convert.ToInt16("E9", 16));
			tlpFooter.BackColor = Color.FromArgb(Convert.ToInt16("B3", 16), Convert.ToInt16("F4", 16), Convert.ToInt16("E9", 16));
		


			if (this.product != null)
			{
				tbArticul.ReadOnly = true;
				tbArticul.Text = product.ProductArticle;
				tbName.Text = product.ProductName;
				FillComboBoxes(product);
				numMaxDiscount.Value = product.ProductMaximumDiscount;
				numCurDiscount.Value = product.ProductDiscountAmount;
				numCost.Value = product.ProductCost;
				numQuantity.Value = product.ProductCost;
				rtbDescription.Text = product.ProductDescription;

				pictureName = product.ProductPhoto;
				GetPicture(product);
			}
			else
			{
				btnDelete.Enabled = false;
				btnDelete.Visible = false;
				tbArticul.ReadOnly = false;
				FillComboBoxes(product);
			}
		}


		private void GetPicture(Product product)
		{
			if (String.IsNullOrEmpty(product.ProductPhoto))
			{
				pbImage.Image = Properties.Resources.picture;
			}
			else
			{
				Image img = Image.FromFile(Directory.GetCurrentDirectory() + @"\Images\" + product.ProductPhoto);
				pbImage.Image = img;
			}
		}

		void FillComboBoxes(Product product)
		{
			List<Category> categories = Helper.MyDBContext.context.Category.ToList();
			cbCategory.DataSource = categories;
			cbCategory.ValueMember = "CategoryID";
			cbCategory.DisplayMember = "CategoryName";

			List<Manufacturer> manufacturers = Helper.MyDBContext.context.Manufacturer.ToList();
			cbManufacturer.DataSource = manufacturers;
			cbManufacturer.ValueMember = "ManufacturerID";
			cbManufacturer.DisplayMember = "ManufacturerName";

			List<Vendor> vendors = Helper.MyDBContext.context.Vendor.ToList();
			cbVendor.DataSource = vendors;
			cbVendor.ValueMember = "VendorID";
			cbVendor.DisplayMember = "VendorName";

			List<MeasurementUnit> measurements = Helper.MyDBContext.context.MeasurementUnit.ToList();
			cbMeasurementUnit.DataSource = measurements;
			cbMeasurementUnit.ValueMember = "MeasurementUnitID";
			cbMeasurementUnit.DisplayMember = "MeasurementUnitName";

			if (product != null)
			{
				SetComboBoxes(product);
			}
		}

		void SetComboBoxes(Product product)
		{		
			cbCategory.SelectedItem = product.Category;
			cbManufacturer.SelectedItem = product.Manufacturer;
			cbVendor.SelectedItem = product.Vendor;
			cbMeasurementUnit.SelectedItem = product.MeasurementUnit;
		}

		private void btnAddPic_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Open Image";
			ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				Image img = new Bitmap(ofd.FileName);
				pbImage.Image = pbImage.Image;
				pictureName = Path.GetFileName(ofd.FileName);
				img.Save((Directory.GetCurrentDirectory() + @"\Images\" + pictureName), ImageFormat.Png);
				
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (FindEmptyFields())
			{
				MessageBox.Show("Не все поля заполнены!");
				return;
			}
			if (product != null)
			{
				if (numCurDiscount.Value > numMaxDiscount.Value)
				{
					MessageBox.Show("Скидка выше максиальной!");
					return;
				}

				product.ProductName = tbName.Text;
				product.ProductDescription = rtbDescription.Text;
			//	product.Category = (Category)cbCategory.SelectedItem;
				product.ProductCategory = (int)cbCategory.SelectedValue;
			//	product.Vendor = (Vendor)cbCategory.SelectedItem;
				product.ProductVendor = (int)cbVendor.SelectedValue;
				product.ProductManufacturer = (int)cbManufacturer.SelectedValue;
				product.ProductMeasurementUnit = (int)cbMeasurementUnit.SelectedValue;
				product.ProductMaximumDiscount = (byte)numMaxDiscount.Value;
				product.ProductDiscountAmount = (byte)numCurDiscount.Value;
				product.ProductCost = (decimal)numCost.Value;
				product.ProductQuantity = (int)numQuantity.Value;
				product.ProductPhoto = pictureName;

				Helper.MyDBContext.SaveDB();
				MessageBox.Show("Товар успешно обновлен!","Оповещение");

			}
			else
			{
				if (numMaxDiscount.Value < numCurDiscount.Value)
				{
					MessageBox.Show("Текущая скидка больше максимальной!","Ошибка");
					return;
				}
				
				Product sameArticleProduct = Helper.MyDBContext.context.Product.
					Where(prod => prod.ProductArticle == tbArticul.Text).
					FirstOrDefault();

				if (sameArticleProduct != null)
				{
					MessageBox.Show("Товар с данным артиклем уже существует", "Ошибка");
					return;
				}

 
				Product p = new Product();
				p.ProductArticle = tbArticul.Text;
				p.ProductName = tbName.Text;
				p.ProductDescription = rtbDescription.Text;
				//	product.Category = (Category)cbCategory.SelectedItem;
				p.ProductCategory = (int)cbCategory.SelectedValue;
				//	product.Vendor = (Vendor)cbCategory.SelectedItem;
				p.ProductVendor = (int)cbVendor.SelectedValue;
				p.ProductManufacturer = (int)cbManufacturer.SelectedValue;
				p.ProductMeasurementUnit = (int)cbMeasurementUnit.SelectedValue;
				p.ProductMaximumDiscount = (byte)numMaxDiscount.Value;
				p.ProductDiscountAmount = (byte)numCurDiscount.Value;
				p.ProductCost = (decimal)numCost.Value;
				p.ProductQuantity = (int)numQuantity.Value;
				p.ProductPhoto = pictureName;

				Helper.MyDBContext.context.Product.Add(p);

				if (Helper.MyDBContext.SaveDB())
				{
					MessageBox.Show("Товар успешно добавлен!", "Оповещение");
				}
				

			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private bool FindEmptyFields()
		{
			if (tbArticul.Text == "") 
				return true;
			if (tbName.Text == "")
				return true;
			if (cbCategory.SelectedIndex == -1)
				return true;
			if (cbManufacturer.SelectedIndex == -1)
				return true;
			if (cbVendor.SelectedIndex == -1)
				return true;
			if (cbMeasurementUnit.SelectedIndex == -1)
				return true;
			if (numCost.Value == 0)
				return true;
			if (rtbDescription.Text == "")
				return true;

			return false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (product == null) 
				return;

			var res =  MessageBox.Show("Вы действительно хотите удалить товар?", "Уведомление",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (res == DialogResult.Yes)
			{
				Helper.MyDBContext.context.Product.Remove(product);
				Helper.MyDBContext.SaveDB();
				this.Close();
			}

		}
	}
}
