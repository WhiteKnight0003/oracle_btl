namespace Oracle.GUI
{
	partial class FormAddTeacher
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
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.dtInputTeacherBrithDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.gbSexteachers = new Guna.UI2.WinForms.Guna2GroupBox();
			this.rbTeacherFeMale = new System.Windows.Forms.RadioButton();
			this.rbTeacherMale = new System.Windows.Forms.RadioButton();
			this.tbInputTeacherPhone = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputTeacherEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputTeacherCountry = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputTeacherName = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnSubmitAddTeachers = new Guna.UI2.WinForms.Guna2Button();
			this.btnSubmitRefreshTeachers = new Guna.UI2.WinForms.Guna2Button();
			this.tbInputTeacherID = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.guna2Panel1.SuspendLayout();
			this.gbSexteachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(30, 13);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 25);
			this.guna2HtmlLabel1.TabIndex = 0;
			this.guna2HtmlLabel1.Text = "Thêm giáo viên";
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(67, 17);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(99, 21);
			this.guna2HtmlLabel2.TabIndex = 1;
			this.guna2HtmlLabel2.Text = "Mã giáo viên : ";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.dtInputTeacherBrithDay);
			this.guna2Panel1.Controls.Add(this.gbSexteachers);
			this.guna2Panel1.Controls.Add(this.tbInputTeacherPhone);
			this.guna2Panel1.Controls.Add(this.tbInputTeacherEmail);
			this.guna2Panel1.Controls.Add(this.tbInputTeacherCountry);
			this.guna2Panel1.Controls.Add(this.tbInputTeacherName);
			this.guna2Panel1.Controls.Add(this.tbInputTeacherID);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
			this.guna2Panel1.Location = new System.Drawing.Point(30, 44);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(701, 376);
			this.guna2Panel1.TabIndex = 2;
			// 
			// dtInputTeacherBrithDay
			// 
			this.dtInputTeacherBrithDay.Checked = true;
			this.dtInputTeacherBrithDay.FillColor = System.Drawing.Color.White;
			this.dtInputTeacherBrithDay.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtInputTeacherBrithDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInputTeacherBrithDay.Location = new System.Drawing.Point(279, 101);
			this.dtInputTeacherBrithDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtInputTeacherBrithDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtInputTeacherBrithDay.Name = "dtInputTeacherBrithDay";
			this.dtInputTeacherBrithDay.Size = new System.Drawing.Size(229, 21);
			this.dtInputTeacherBrithDay.TabIndex = 2;
			this.dtInputTeacherBrithDay.Value = new System.DateTime(2024, 11, 26, 23, 25, 7, 54);
			// 
			// gbSexteachers
			// 
			this.gbSexteachers.Controls.Add(this.rbTeacherFeMale);
			this.gbSexteachers.Controls.Add(this.rbTeacherMale);
			this.gbSexteachers.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.gbSexteachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.gbSexteachers.Location = new System.Drawing.Point(67, 261);
			this.gbSexteachers.Name = "gbSexteachers";
			this.gbSexteachers.Size = new System.Drawing.Size(298, 112);
			this.gbSexteachers.TabIndex = 3;
			this.gbSexteachers.Text = "Giới tính";
			// 
			// rbTeacherFeMale
			// 
			this.rbTeacherFeMale.AutoSize = true;
			this.rbTeacherFeMale.ForeColor = System.Drawing.Color.Black;
			this.rbTeacherFeMale.Location = new System.Drawing.Point(212, 61);
			this.rbTeacherFeMale.Name = "rbTeacherFeMale";
			this.rbTeacherFeMale.Size = new System.Drawing.Size(50, 24);
			this.rbTeacherFeMale.TabIndex = 7;
			this.rbTeacherFeMale.TabStop = true;
			this.rbTeacherFeMale.Text = "Nữ";
			this.rbTeacherFeMale.UseVisualStyleBackColor = true;
			// 
			// rbTeacherMale
			// 
			this.rbTeacherMale.AutoSize = true;
			this.rbTeacherMale.ForeColor = System.Drawing.Color.Black;
			this.rbTeacherMale.Location = new System.Drawing.Point(23, 61);
			this.rbTeacherMale.Name = "rbTeacherMale";
			this.rbTeacherMale.Size = new System.Drawing.Size(62, 24);
			this.rbTeacherMale.TabIndex = 6;
			this.rbTeacherMale.TabStop = true;
			this.rbTeacherMale.Text = "Nam";
			this.rbTeacherMale.UseVisualStyleBackColor = true;
			// 
			// tbInputTeacherPhone
			// 
			this.tbInputTeacherPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputTeacherPhone.DefaultText = "";
			this.tbInputTeacherPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputTeacherPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputTeacherPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputTeacherPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherPhone.Location = new System.Drawing.Point(279, 220);
			this.tbInputTeacherPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputTeacherPhone.Name = "tbInputTeacherPhone";
			this.tbInputTeacherPhone.PasswordChar = '\0';
			this.tbInputTeacherPhone.PlaceholderText = "";
			this.tbInputTeacherPhone.SelectedText = "";
			this.tbInputTeacherPhone.Size = new System.Drawing.Size(307, 21);
			this.tbInputTeacherPhone.TabIndex = 5;
			// 
			// tbInputTeacherEmail
			// 
			this.tbInputTeacherEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputTeacherEmail.DefaultText = "";
			this.tbInputTeacherEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputTeacherEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputTeacherEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputTeacherEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherEmail.Location = new System.Drawing.Point(279, 180);
			this.tbInputTeacherEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputTeacherEmail.Name = "tbInputTeacherEmail";
			this.tbInputTeacherEmail.PasswordChar = '\0';
			this.tbInputTeacherEmail.PlaceholderText = "";
			this.tbInputTeacherEmail.SelectedText = "";
			this.tbInputTeacherEmail.Size = new System.Drawing.Size(307, 21);
			this.tbInputTeacherEmail.TabIndex = 4;
			// 
			// tbInputTeacherCountry
			// 
			this.tbInputTeacherCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputTeacherCountry.DefaultText = "";
			this.tbInputTeacherCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputTeacherCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputTeacherCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputTeacherCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherCountry.Location = new System.Drawing.Point(279, 144);
			this.tbInputTeacherCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputTeacherCountry.Name = "tbInputTeacherCountry";
			this.tbInputTeacherCountry.PasswordChar = '\0';
			this.tbInputTeacherCountry.PlaceholderText = "";
			this.tbInputTeacherCountry.SelectedText = "";
			this.tbInputTeacherCountry.Size = new System.Drawing.Size(307, 21);
			this.tbInputTeacherCountry.TabIndex = 3;
			// 
			// tbInputTeacherName
			// 
			this.tbInputTeacherName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputTeacherName.DefaultText = "";
			this.tbInputTeacherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputTeacherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputTeacherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputTeacherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherName.Location = new System.Drawing.Point(279, 58);
			this.tbInputTeacherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputTeacherName.Name = "tbInputTeacherName";
			this.tbInputTeacherName.PasswordChar = '\0';
			this.tbInputTeacherName.PlaceholderText = "";
			this.tbInputTeacherName.SelectedText = "";
			this.tbInputTeacherName.Size = new System.Drawing.Size(307, 21);
			this.tbInputTeacherName.TabIndex = 1;
			// 
			// guna2HtmlLabel7
			// 
			this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel7.Location = new System.Drawing.Point(67, 220);
			this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
			this.guna2HtmlLabel7.Size = new System.Drawing.Size(102, 21);
			this.guna2HtmlLabel7.TabIndex = 1;
			this.guna2HtmlLabel7.Text = "Số điện thoại : ";
			// 
			// guna2HtmlLabel6
			// 
			this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel6.Location = new System.Drawing.Point(67, 180);
			this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
			this.guna2HtmlLabel6.Size = new System.Drawing.Size(52, 21);
			this.guna2HtmlLabel6.TabIndex = 1;
			this.guna2HtmlLabel6.Text = "Email : ";
			// 
			// guna2HtmlLabel5
			// 
			this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel5.Location = new System.Drawing.Point(67, 144);
			this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
			this.guna2HtmlLabel5.Size = new System.Drawing.Size(75, 21);
			this.guna2HtmlLabel5.TabIndex = 1;
			this.guna2HtmlLabel5.Text = "Quê quán : ";
			// 
			// guna2HtmlLabel4
			// 
			this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel4.Location = new System.Drawing.Point(67, 101);
			this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
			this.guna2HtmlLabel4.Size = new System.Drawing.Size(79, 21);
			this.guna2HtmlLabel4.TabIndex = 1;
			this.guna2HtmlLabel4.Text = "Ngày sinh : ";
			// 
			// guna2HtmlLabel3
			// 
			this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel3.Location = new System.Drawing.Point(67, 58);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(102, 21);
			this.guna2HtmlLabel3.TabIndex = 1;
			this.guna2HtmlLabel3.Text = "Tên giáo viên : ";
			// 
			// btnSubmitAddTeachers
			// 
			this.btnSubmitAddTeachers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitAddTeachers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitAddTeachers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSubmitAddTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSubmitAddTeachers.FillColor = System.Drawing.Color.Lime;
			this.btnSubmitAddTeachers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitAddTeachers.ForeColor = System.Drawing.Color.Black;
			this.btnSubmitAddTeachers.Location = new System.Drawing.Point(31, 446);
			this.btnSubmitAddTeachers.Name = "btnSubmitAddTeachers";
			this.btnSubmitAddTeachers.Size = new System.Drawing.Size(129, 45);
			this.btnSubmitAddTeachers.TabIndex = 8;
			this.btnSubmitAddTeachers.Text = "Xác nhận";
			this.btnSubmitAddTeachers.Click += new System.EventHandler(this.btnSubmitAddTeachers_Click);
			// 
			// btnSubmitRefreshTeachers
			// 
			this.btnSubmitRefreshTeachers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitRefreshTeachers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitRefreshTeachers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSubmitRefreshTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSubmitRefreshTeachers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitRefreshTeachers.ForeColor = System.Drawing.Color.White;
			this.btnSubmitRefreshTeachers.Location = new System.Drawing.Point(208, 446);
			this.btnSubmitRefreshTeachers.Name = "btnSubmitRefreshTeachers";
			this.btnSubmitRefreshTeachers.Size = new System.Drawing.Size(129, 45);
			this.btnSubmitRefreshTeachers.TabIndex = 9;
			this.btnSubmitRefreshTeachers.Text = "Làm mới";
			this.btnSubmitRefreshTeachers.Click += new System.EventHandler(this.btnSubmitRefreshTeachers_Click);
			// 
			// tbInputTeacherID
			// 
			this.tbInputTeacherID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputTeacherID.DefaultText = "";
			this.tbInputTeacherID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputTeacherID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputTeacherID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputTeacherID.Enabled = false;
			this.tbInputTeacherID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputTeacherID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputTeacherID.Location = new System.Drawing.Point(279, 17);
			this.tbInputTeacherID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputTeacherID.Name = "tbInputTeacherID";
			this.tbInputTeacherID.PasswordChar = '\0';
			this.tbInputTeacherID.PlaceholderText = "";
			this.tbInputTeacherID.ReadOnly = true;
			this.tbInputTeacherID.SelectedText = "";
			this.tbInputTeacherID.Size = new System.Drawing.Size(307, 21);
			this.tbInputTeacherID.TabIndex = 0;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// FormAddTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 503);
			this.Controls.Add(this.btnSubmitRefreshTeachers);
			this.Controls.Add(this.btnSubmitAddTeachers);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Name = "FormAddTeacher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddTeacher";
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.gbSexteachers.ResumeLayout(false);
			this.gbSexteachers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2GroupBox gbSexteachers;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtInputTeacherBrithDay;
		private Guna.UI2.WinForms.Guna2TextBox tbInputTeacherPhone;
		private Guna.UI2.WinForms.Guna2TextBox tbInputTeacherEmail;
		private Guna.UI2.WinForms.Guna2TextBox tbInputTeacherCountry;
		private Guna.UI2.WinForms.Guna2TextBox tbInputTeacherName;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
		private Guna.UI2.WinForms.Guna2Button btnSubmitAddTeachers;
		private System.Windows.Forms.RadioButton rbTeacherFeMale;
		private System.Windows.Forms.RadioButton rbTeacherMale;
		private Guna.UI2.WinForms.Guna2Button btnSubmitRefreshTeachers;
		private Guna.UI2.WinForms.Guna2TextBox tbInputTeacherID;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}