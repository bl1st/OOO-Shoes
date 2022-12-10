using OOO_Shoes.Entities;
using OOO_Shoes.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Shoes
{
	public partial class FormAuthorization : Form
	{
		Timer t = new Timer();
		int attempts = 0;
		string messageAuthorization = "Неправильный логин или пароль";
		public FormAuthorization()
		{
			InitializeComponent();
			tlpHeader.BackColor = Color.FromArgb(Convert.ToInt16("B3",16), Convert.ToInt16("F4",16), Convert.ToInt16("E9", 16));
			btnExit.BackColor = Color.FromArgb(Convert.ToInt16("A5", 16), Convert.ToInt16("E8", 16), Convert.ToInt16("87", 16));
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (t.Enabled) 
				return;
			string login = textBoxLogin.Text;
			string password = textBoxPassword.Text;
			var user = Helper.MyDBContext.context.User.Where(x => x.UserLogin == login && x.UserPassword == password).FirstOrDefault();
			if (user == null)
			{
				MessageBox.Show(messageAuthorization, "Ошибка");
				MessageBox.Show("Блокировка авторизации на 10 секунд", "Ошибка");
				t.Interval = 10000;
				t.Enabled = true;
				t.Tick += TimerTick;
				t.Start();
				return;
			}

			string userRole = user.Role.RoleName;
			MessageBox.Show($"Добро пожаловать, {user.UserName} {user.UserPatronymic} \nРоль: {userRole}", "Приветствие");
			Form form = new FormProducts(userRole);
			this.Hide();
			form.ShowDialog();
			this.Show();

		}

		private void FormAuthorization_Load(object sender, EventArgs e)
		{

		}

		private void buttonLoginAsGuest_Click(object sender, EventArgs e)
		{
			if (t.Enabled)
				return;
			MessageBox.Show($"Добро пожаловать, гость", "Приветствие");
			Form form = new FormProducts("Гость");
			this.Hide();
			form.ShowDialog();
			this.Show();

		}

		public void TimerTick(object sender, EventArgs e)
		{
			Timer t = (sender as Timer);
			t.Stop();
			t.Enabled = false;

		}
	}
}
