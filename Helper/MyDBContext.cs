using OOO_Shoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Shoes.Helper
{
	public static class MyDBContext
	{
		public static DBShoesEntities context;


		public static bool SaveDB()
		{
			try
			{
				context.SaveChanges();
			}
			catch (Exception e)
			{
				MessageBox.Show($"Произошла ошибка при сохранении изменений\nОшибка: {e.Message}", "Ошибка");
				return false;

			}
			return true;
		}
	}
}
