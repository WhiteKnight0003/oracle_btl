namespace Oracle.GUI
{
	partial class FormAddStudents
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
			this.btnSubmitRefreshStudent = new Guna.UI2.WinForms.Guna2Button();
			this.btnSubmitAddStudent = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.cbClassID = new System.Windows.Forms.ComboBox();
			this.dtInputStudentBrithDay = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.gbSexStudents = new Guna.UI2.WinForms.Guna2GroupBox();
			this.rbStudentFeMale = new System.Windows.Forms.RadioButton();
			this.rbStudentMale = new System.Windows.Forms.RadioButton();
			this.tbInputStudentPhone = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputStudentEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputStudentCountry = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputStudentName = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputStudentID = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.guna2Panel1.SuspendLayout();
			this.gbSexStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSubmitRefreshStudent
			// 
			this.btnSubmitRefreshStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitRefreshStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitRefreshStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSubmitRefreshStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSubmitRefreshStudent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitRefreshStudent.ForeColor = System.Drawing.Color.White;
			this.btnSubmitRefreshStudent.Location = new System.Drawing.Point(196, 454);
			this.btnSubmitRefreshStudent.Name = "btnSubmitRefreshStudent";
			this.btnSubmitRefreshStudent.Size = new System.Drawing.Size(129, 45);
			this.btnSubmitRefreshStudent.TabIndex = 7;
			this.btnSubmitRefreshStudent.Text = "Làm mới";
			this.btnSubmitRefreshStudent.Click += new System.EventHandler(this.btnSubmitRefreshStudent_Click);
			// 
			// btnSubmitAddStudent
			// 
			this.btnSubmitAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSubmitAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSubmitAddStudent.FillColor = System.Drawing.Color.Lime;
			this.btnSubmitAddStudent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitAddStudent.ForeColor = System.Drawing.Color.Black;
			this.btnSubmitAddStudent.Location = new System.Drawing.Point(25, 454);
			this.btnSubmitAddStudent.Name = "btnSubmitAddStudent";
			this.btnSubmitAddStudent.Size = new System.Drawing.Size(129, 45);
			this.btnSubmitAddStudent.TabIndex = 8;
			this.btnSubmitAddStudent.Text = "Xác nhận";
			this.btnSubmitAddStudent.Click += new System.EventHandler(this.btnSubmitAddStudent_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.cbClassID);
			this.guna2Panel1.Controls.Add(this.dtInputStudentBrithDay);
			this.guna2Panel1.Controls.Add(this.gbSexStudents);
			this.guna2Panel1.Controls.Add(this.tbInputStudentPhone);
			this.guna2Panel1.Controls.Add(this.tbInputStudentEmail);
			this.guna2Panel1.Controls.Add(this.tbInputStudentCountry);
			this.guna2Panel1.Controls.Add(this.tbInputStudentName);
			this.guna2Panel1.Controls.Add(this.tbInputStudentID);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
			this.guna2Panel1.Location = new System.Drawing.Point(25, 42);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(701, 376);
			this.guna2Panel1.TabIndex = 6;
			// 
			// cbClassID
			// 
			this.cbClassID.FormattingEnabled = true;
			this.cbClassID.Location = new System.Drawing.Point(279, 89);
			this.cbClassID.Name = "cbClassID";
			this.cbClassID.Size = new System.Drawing.Size(229, 24);
			this.cbClassID.TabIndex = 4;
			// 
			// dtInputStudentBrithDay
			// 
			this.dtInputStudentBrithDay.Checked = true;
			this.dtInputStudentBrithDay.FillColor = System.Drawing.Color.White;
			this.dtInputStudentBrithDay.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtInputStudentBrithDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInputStudentBrithDay.Location = new System.Drawing.Point(279, 129);
			this.dtInputStudentBrithDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtInputStudentBrithDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtInputStudentBrithDay.Name = "dtInputStudentBrithDay";
			this.dtInputStudentBrithDay.Size = new System.Drawing.Size(229, 21);
			this.dtInputStudentBrithDay.TabIndex = 3;
			this.dtInputStudentBrithDay.Value = new System.DateTime(2024, 11, 26, 23, 25, 7, 54);
			// 
			// gbSexStudents
			// 
			this.gbSexStudents.Controls.Add(this.rbStudentFeMale);
			this.gbSexStudents.Controls.Add(this.rbStudentMale);
			this.gbSexStudents.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.gbSexStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.gbSexStudents.Location = new System.Drawing.Point(67, 278);
			this.gbSexStudents.Name = "gbSexStudents";
			this.gbSexStudents.Size = new System.Drawing.Size(298, 95);
			this.gbSexStudents.TabIndex = 3;
			this.gbSexStudents.Text = "Giới tính";
			// 
			// rbStudentFeMale
			// 
			this.rbStudentFeMale.AutoSize = true;
			this.rbStudentFeMale.ForeColor = System.Drawing.Color.Black;
			this.rbStudentFeMale.Location = new System.Drawing.Point(212, 53);
			this.rbStudentFeMale.Name = "rbStudentFeMale";
			this.rbStudentFeMale.Size = new System.Drawing.Size(50, 24);
			this.rbStudentFeMale.TabIndex = 1;
			this.rbStudentFeMale.TabStop = true;
			this.rbStudentFeMale.Text = "Nữ";
			this.rbStudentFeMale.UseVisualStyleBackColor = true;
			// 
			// rbStudentMale
			// 
			this.rbStudentMale.AutoSize = true;
			this.rbStudentMale.ForeColor = System.Drawing.Color.Black;
			this.rbStudentMale.Location = new System.Drawing.Point(17, 53);
			this.rbStudentMale.Name = "rbStudentMale";
			this.rbStudentMale.Size = new System.Drawing.Size(62, 24);
			this.rbStudentMale.TabIndex = 0;
			this.rbStudentMale.TabStop = true;
			this.rbStudentMale.Text = "Nam";
			this.rbStudentMale.UseVisualStyleBackColor = true;
			// 
			// tbInputStudentPhone
			// 
			this.tbInputStudentPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputStudentPhone.DefaultText = "";
			this.tbInputStudentPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputStudentPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputStudentPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputStudentPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentPhone.Location = new System.Drawing.Point(279, 239);
			this.tbInputStudentPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputStudentPhone.Name = "tbInputStudentPhone";
			this.tbInputStudentPhone.PasswordChar = '\0';
			this.tbInputStudentPhone.PlaceholderText = "";
			this.tbInputStudentPhone.SelectedText = "";
			this.tbInputStudentPhone.Size = new System.Drawing.Size(307, 21);
			this.tbInputStudentPhone.TabIndex = 2;
			// 
			// tbInputStudentEmail
			// 
			this.tbInputStudentEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputStudentEmail.DefaultText = "";
			this.tbInputStudentEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputStudentEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputStudentEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputStudentEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentEmail.Location = new System.Drawing.Point(279, 201);
			this.tbInputStudentEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputStudentEmail.Name = "tbInputStudentEmail";
			this.tbInputStudentEmail.PasswordChar = '\0';
			this.tbInputStudentEmail.PlaceholderText = "";
			this.tbInputStudentEmail.SelectedText = "";
			this.tbInputStudentEmail.Size = new System.Drawing.Size(307, 21);
			this.tbInputStudentEmail.TabIndex = 2;
			// 
			// tbInputStudentCountry
			// 
			this.tbInputStudentCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputStudentCountry.DefaultText = "";
			this.tbInputStudentCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputStudentCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputStudentCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputStudentCountry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentCountry.Location = new System.Drawing.Point(279, 165);
			this.tbInputStudentCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputStudentCountry.Name = "tbInputStudentCountry";
			this.tbInputStudentCountry.PasswordChar = '\0';
			this.tbInputStudentCountry.PlaceholderText = "";
			this.tbInputStudentCountry.SelectedText = "";
			this.tbInputStudentCountry.Size = new System.Drawing.Size(307, 21);
			this.tbInputStudentCountry.TabIndex = 2;
			// 
			// tbInputStudentName
			// 
			this.tbInputStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputStudentName.DefaultText = "";
			this.tbInputStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentName.Location = new System.Drawing.Point(279, 58);
			this.tbInputStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputStudentName.Name = "tbInputStudentName";
			this.tbInputStudentName.PasswordChar = '\0';
			this.tbInputStudentName.PlaceholderText = "";
			this.tbInputStudentName.SelectedText = "";
			this.tbInputStudentName.Size = new System.Drawing.Size(307, 21);
			this.tbInputStudentName.TabIndex = 2;
			// 
			// tbInputStudentID
			// 
			this.tbInputStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputStudentID.DefaultText = "";
			this.tbInputStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputStudentID.Enabled = false;
			this.tbInputStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputStudentID.Location = new System.Drawing.Point(279, 17);
			this.tbInputStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputStudentID.Name = "tbInputStudentID";
			this.tbInputStudentID.PasswordChar = '\0';
			this.tbInputStudentID.PlaceholderText = "";
			this.tbInputStudentID.ReadOnly = true;
			this.tbInputStudentID.SelectedText = "";
			this.tbInputStudentID.Size = new System.Drawing.Size(307, 21);
			this.tbInputStudentID.TabIndex = 2;
			// 
			// guna2HtmlLabel7
			// 
			this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel7.Location = new System.Drawing.Point(67, 239);
			this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
			this.guna2HtmlLabel7.Size = new System.Drawing.Size(102, 21);
			this.guna2HtmlLabel7.TabIndex = 1;
			this.guna2HtmlLabel7.Text = "Số điện thoại : ";
			// 
			// guna2HtmlLabel6
			// 
			this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel6.Location = new System.Drawing.Point(67, 201);
			this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
			this.guna2HtmlLabel6.Size = new System.Drawing.Size(52, 21);
			this.guna2HtmlLabel6.TabIndex = 1;
			this.guna2HtmlLabel6.Text = "Email : ";
			// 
			// guna2HtmlLabel5
			// 
			this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel5.Location = new System.Drawing.Point(67, 165);
			this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
			this.guna2HtmlLabel5.Size = new System.Drawing.Size(75, 21);
			this.guna2HtmlLabel5.TabIndex = 1;
			this.guna2HtmlLabel5.Text = "Quê quán : ";
			// 
			// guna2HtmlLabel8
			// 
			this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel8.Location = new System.Drawing.Point(67, 92);
			this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
			this.guna2HtmlLabel8.Size = new System.Drawing.Size(63, 21);
			this.guna2HtmlLabel8.TabIndex = 1;
			this.guna2HtmlLabel8.Text = "Tên lớp : ";
			// 
			// guna2HtmlLabel4
			// 
			this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel4.Location = new System.Drawing.Point(67, 129);
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
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(101, 21);
			this.guna2HtmlLabel3.TabIndex = 1;
			this.guna2HtmlLabel3.Text = "Tên sinh viên : ";
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(67, 17);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(98, 21);
			this.guna2HtmlLabel2.TabIndex = 1;
			this.guna2HtmlLabel2.Text = "Mã sinh viên : ";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 12);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(130, 25);
			this.guna2HtmlLabel1.TabIndex = 5;
			this.guna2HtmlLabel1.Text = "Thêm Sinh viên";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// FormAddStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 503);
			this.Controls.Add(this.btnSubmitRefreshStudent);
			this.Controls.Add(this.btnSubmitAddStudent);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Name = "FormAddStudents";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddStudents";
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.gbSexStudents.ResumeLayout(false);
			this.gbSexStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btnSubmitRefreshStudent;
		private Guna.UI2.WinForms.Guna2Button btnSubmitAddStudent;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtInputStudentBrithDay;
		private Guna.UI2.WinForms.Guna2GroupBox gbSexStudents;
		private System.Windows.Forms.RadioButton rbStudentFeMale;
		private System.Windows.Forms.RadioButton rbStudentMale;
		private Guna.UI2.WinForms.Guna2TextBox tbInputStudentPhone;
		private Guna.UI2.WinForms.Guna2TextBox tbInputStudentEmail;
		private Guna.UI2.WinForms.Guna2TextBox tbInputStudentCountry;
		private Guna.UI2.WinForms.Guna2TextBox tbInputStudentName;
		private Guna.UI2.WinForms.Guna2TextBox tbInputStudentID;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
		private System.Windows.Forms.ComboBox cbClassID;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}