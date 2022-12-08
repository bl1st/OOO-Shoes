namespace OOO_Shoes
{
	partial class FormAuthorization
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
			this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.labelOrganisationName = new System.Windows.Forms.Label();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.tlpBody = new System.Windows.Forms.TableLayoutPanel();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonLoginAsGuest = new System.Windows.Forms.Button();
			this.tlpHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.tlpBody.SuspendLayout();
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
			this.tlpHeader.Size = new System.Drawing.Size(771, 83);
			this.tlpHeader.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExit.Location = new System.Drawing.Point(696, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 77);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Выход";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// labelOrganisationName
			// 
			this.labelOrganisationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelOrganisationName.AutoSize = true;
			this.labelOrganisationName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrganisationName.Location = new System.Drawing.Point(80, 0);
			this.labelOrganisationName.Name = "labelOrganisationName";
			this.labelOrganisationName.Size = new System.Drawing.Size(610, 83);
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
			this.pbLogo.Size = new System.Drawing.Size(71, 77);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 1;
			this.pbLogo.TabStop = false;
			// 
			// tlpBody
			// 
			this.tlpBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpBody.ColumnCount = 4;
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tlpBody.Controls.Add(this.labelLogin, 1, 1);
			this.tlpBody.Controls.Add(this.labelPassword, 1, 2);
			this.tlpBody.Controls.Add(this.textBoxLogin, 2, 1);
			this.tlpBody.Controls.Add(this.textBoxPassword, 2, 2);
			this.tlpBody.Controls.Add(this.buttonLogin, 1, 3);
			this.tlpBody.Controls.Add(this.buttonLoginAsGuest, 2, 3);
			this.tlpBody.Location = new System.Drawing.Point(2, 86);
			this.tlpBody.Name = "tlpBody";
			this.tlpBody.RowCount = 5;
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tlpBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tlpBody.Size = new System.Drawing.Size(771, 392);
			this.tlpBody.TabIndex = 1;
			// 
			// labelLogin
			// 
			this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLogin.AutoSize = true;
			this.labelLogin.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLogin.Location = new System.Drawing.Point(195, 117);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(186, 58);
			this.labelLogin.TabIndex = 0;
			this.labelLogin.Text = "Логин:";
			this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelPassword
			// 
			this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPassword.AutoSize = true;
			this.labelPassword.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPassword.Location = new System.Drawing.Point(195, 175);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(186, 58);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Пароль:";
			this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxLogin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.Location = new System.Drawing.Point(387, 132);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(186, 27);
			this.textBoxLogin.TabIndex = 1;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassword.Location = new System.Drawing.Point(387, 190);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(186, 27);
			this.textBoxPassword.TabIndex = 2;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLogin.Location = new System.Drawing.Point(195, 236);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(186, 33);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "Войти";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// buttonLoginAsGuest
			// 
			this.buttonLoginAsGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoginAsGuest.Location = new System.Drawing.Point(387, 236);
			this.buttonLoginAsGuest.Name = "buttonLoginAsGuest";
			this.buttonLoginAsGuest.Size = new System.Drawing.Size(186, 33);
			this.buttonLoginAsGuest.TabIndex = 4;
			this.buttonLoginAsGuest.Text = "Войти как гость";
			this.buttonLoginAsGuest.UseVisualStyleBackColor = true;
			this.buttonLoginAsGuest.Click += new System.EventHandler(this.buttonLoginAsGuest_Click);
			// 
			// FormAuthorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 481);
			this.Controls.Add(this.tlpBody);
			this.Controls.Add(this.tlpHeader);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(792, 520);
			this.Name = "FormAuthorization";
			this.Text = "ООО \"Обувь\"";
			this.Load += new System.EventHandler(this.FormAuthorization_Load);
			this.tlpHeader.ResumeLayout(false);
			this.tlpHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.tlpBody.ResumeLayout(false);
			this.tlpBody.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpHeader;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label labelOrganisationName;
		private System.Windows.Forms.TableLayoutPanel tlpBody;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLoginAsGuest;
	}
}

