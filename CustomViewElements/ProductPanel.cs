using OOO_Shoes.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Shoes.CustomViewElements
{
	public class ProductPanel : Panel
	{
		public PictureBox pbImage;

		public new Label ProductName;
		public Label ProductDescription;
		public Label ProductManufacturer;
		public Label ProductCost;
		public Label ProductDiscount;
		public Product product { get; }

		public ProductPanel(Product product, Panel panelProducts)
		{
			this.Width = panelProducts.Width - 20;
			this.Height = 100;
			int gap = this.Height / 8;


			this.BorderStyle = BorderStyle.FixedSingle;

			pbImage = new PictureBox();
			pbImage.Size = new Size(this.Height - gap, this.Height - gap);
			pbImage.Location = new Point(gap, gap);
			pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

			int textX = pbImage.Location.X + pbImage.Width + 10;
			int textY = this.Height / 5;
			int pos = 0;

			ProductName = new Label();
			ProductName.Font = new Font("Candara", 12.0f, FontStyle.Bold);
			ProductName.Location = new Point(textX,(textY * pos) + 10);
			ProductName.AutoSize = true;
			pos++;

			ProductDescription = new Label();
			ProductDescription.Font = new Font("Candara", 12.0f, FontStyle.Regular);
			ProductDescription.Location = new Point(textX, (textY * pos) + 10);
			ProductDescription.AutoSize = true;
			pos++;

			ProductManufacturer = new Label();
			ProductManufacturer.Font = new Font("Candara", 12.0f, FontStyle.Regular);
			ProductManufacturer.Location = new Point(textX, (textY * pos) + 10);
			ProductManufacturer.AutoSize = true;
			pos++;

			ProductCost = new Label();
			ProductCost.Font = new Font("Candara", 12.0f, FontStyle.Regular);
			ProductCost.Location = new Point(textX, (textY * pos) + 10);
			ProductCost.AutoSize = true;
			
			ProductDiscount = new Label();
			ProductDiscount.Font = new Font("Candara", 12.0f, FontStyle.Regular);

			int discountLocationY = this.Height/2  - ProductDiscount.Height / 2;
			int discountLocationX = this.Width - 160;
			ProductDiscount.Location = new Point(discountLocationX, discountLocationY);
			ProductDiscount.AutoSize = true;
			ProductDiscount.TextAlign = ContentAlignment.MiddleCenter;

			this.SizeChanged += Resize;


			SetElements(product);


		}

		public new void Resize(object sender, EventArgs e)
		{
			int gap = this.Height / 8;
			pbImage.Size = new Size(this.Height - gap, this.Height - gap);
			pbImage.Location = new Point(gap, gap);

			int textX = pbImage.Location.X + pbImage.Width + 10;
			int textY = this.Height / 5;
			int pos = 0;
			ProductName.Location = new Point(textX, (textY * pos) + 10);
			pos++;
			ProductDescription.Location = new Point(textX, (textY * pos) + 10);
			pos++;
			ProductManufacturer.Location = new Point(textX, (textY * pos) + 10);
			pos++;
			ProductCost.Location = new Point(textX, (textY * pos) + 10);

			int discountLocationY = this.Height / 2 - ProductDiscount.Height / 2;
			int discountLocationX = this.Width - 160;
			ProductDiscount.Location = new Point(discountLocationX, discountLocationY);


		}
		private void SetElements(Product product)
		{
			string dir = Environment.CurrentDirectory;
			if (!(product.ProductPhoto == null))
			{
				Image img = Image.FromFile(dir + @"\Images\" + product.ProductPhoto);
				pbImage.Image = img;
			}
			else
			{
				pbImage.Image = Properties.Resources.picture;
			}


			ProductName.Text = product.ProductName;

			string description = product.ProductDescription;
			if (description.Length > 50)
			{
				string shorterDescription = description.Substring(0, 50);
				ProductDescription.Text = shorterDescription + "...";
			}
			else
			{
				ProductDescription.Text = description;
			}

			ProductManufacturer.Text = product.Manufacturer.ManufacturerName;
			
			if(product.ProductDiscountAmount > 0)
			{
				double cost = Convert.ToDouble(product.ProductCost);
				int discount = product.ProductDiscountAmount;
				double totalCost = cost - (cost * (discount * 0.01));
				totalCost = Math.Round(totalCost,2);
				ProductCost.Text = "Цена: " + totalCost.ToString() + " руб.";
				ProductDiscount.Text = $"Скидка: {discount}%\n{Math.Round(cost * (discount * 0.01),2)} руб."; 
			}
			else
			{
				ProductCost.Text = "Цена: " + product.ProductCost.ToString() + " руб.";
			}

			this.Controls.Add(pbImage);
			this.Controls.Add(ProductName);
			this.Controls.Add(ProductDescription);
			this.Controls.Add(ProductManufacturer);
			this.Controls.Add(ProductCost);
			this.Controls.Add(ProductDiscount);

		}
	}
}
