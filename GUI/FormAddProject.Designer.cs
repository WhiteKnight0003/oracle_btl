namespace Oracle.GUI
{
	partial class FormAddProject
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
			this.btnSubmitRefreshProject = new Guna.UI2.WinForms.Guna2Button();
			this.btnSubmitAddProject = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.cbTeachers = new System.Windows.Forms.ComboBox();
			this.cbStudentByClass = new System.Windows.Forms.ComboBox();
			this.dtCreateProject = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.cbTopicName = new System.Windows.Forms.ComboBox();
			this.dtEndProject = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.tbInputProjectName = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbInputProjectID = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnBackProject = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSubmitRefreshProject
			// 
			this.btnSubmitRefreshProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitRefreshProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitRefreshProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSubmitRefreshProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSubmitRefreshProject.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitRefreshProject.ForeColor = System.Drawing.Color.White;
			this.btnSubmitRefreshProject.Location = new System.Drawing.Point(301, 409);
			this.btnSubmitRefreshProject.Name = "btnSubmitRefreshProject";
			this.btnSubmitRefreshProject.Size = new System.Drawing.Size(129, 45);
			this.btnSubmitRefreshProject.TabIndex = 11;
			this.btnSubmitRefreshProject.Text = "Làm mới";
			this.btnSubmitRefreshProject.Click += new System.EventHandler(this.btnSubmitRefreshProject_Click);
			// 
			// btnSubmitAddProject
			// 
			this.btnSubmitAddProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitAddProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSubmitAddProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSubmitAddProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSubmitAddProject.FillColor = System.Drawing.Color.Lime;
			this.btnSubmitAddProject.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmitAddProject.ForeColor = System.Drawing.Color.Black;
			this.btnSubmitAddProject.Location = new System.Drawing.Point(89, 409);
			this.btnSubmitAddProject.Name = "btnSubmitAddProject";
			this.btnSubmitAddProject.Size = new System.Drawing.Size(129, 45);
			this.btnSubmitAddProject.TabIndex = 12;
			this.btnSubmitAddProject.Text = "Xác nhận";
			this.btnSubmitAddProject.Click += new System.EventHandler(this.btnSubmitAddProject_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.cbTeachers);
			this.guna2Panel1.Controls.Add(this.cbStudentByClass);
			this.guna2Panel1.Controls.Add(this.dtCreateProject);
			this.guna2Panel1.Controls.Add(this.cbTopicName);
			this.guna2Panel1.Controls.Add(this.dtEndProject);
			this.guna2Panel1.Controls.Add(this.tbInputProjectName);
			this.guna2Panel1.Controls.Add(this.tbInputProjectID);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
			this.guna2Panel1.Location = new System.Drawing.Point(25, 62);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(701, 341);
			this.guna2Panel1.TabIndex = 10;
			// 
			// cbTeachers
			// 
			this.cbTeachers.FormattingEnabled = true;
			this.cbTeachers.Location = new System.Drawing.Point(279, 165);
			this.cbTeachers.Name = "cbTeachers";
			this.cbTeachers.Size = new System.Drawing.Size(229, 24);
			this.cbTeachers.TabIndex = 7;
			// 
			// cbStudentByClass
			// 
			this.cbStudentByClass.FormattingEnabled = true;
			this.cbStudentByClass.Location = new System.Drawing.Point(279, 125);
			this.cbStudentByClass.Name = "cbStudentByClass";
			this.cbStudentByClass.Size = new System.Drawing.Size(229, 24);
			this.cbStudentByClass.TabIndex = 6;
			// 
			// dtCreateProject
			// 
			this.dtCreateProject.Checked = true;
			this.dtCreateProject.FillColor = System.Drawing.Color.White;
			this.dtCreateProject.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtCreateProject.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtCreateProject.Location = new System.Drawing.Point(279, 210);
			this.dtCreateProject.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtCreateProject.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtCreateProject.Name = "dtCreateProject";
			this.dtCreateProject.Size = new System.Drawing.Size(229, 21);
			this.dtCreateProject.TabIndex = 5;
			this.dtCreateProject.Value = new System.DateTime(2024, 11, 26, 23, 47, 46, 59);
			// 
			// cbTopicName
			// 
			this.cbTopicName.FormattingEnabled = true;
			this.cbTopicName.Location = new System.Drawing.Point(279, 89);
			this.cbTopicName.Name = "cbTopicName";
			this.cbTopicName.Size = new System.Drawing.Size(229, 24);
			this.cbTopicName.TabIndex = 4;
			// 
			// dtEndProject
			// 
			this.dtEndProject.Checked = true;
			this.dtEndProject.FillColor = System.Drawing.Color.White;
			this.dtEndProject.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtEndProject.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtEndProject.Location = new System.Drawing.Point(279, 251);
			this.dtEndProject.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtEndProject.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtEndProject.Name = "dtEndProject";
			this.dtEndProject.Size = new System.Drawing.Size(229, 21);
			this.dtEndProject.TabIndex = 3;
			this.dtEndProject.Value = new System.DateTime(2024, 11, 26, 23, 25, 7, 54);
			// 
			// tbInputProjectName
			// 
			this.tbInputProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputProjectName.DefaultText = "";
			this.tbInputProjectName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputProjectName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputProjectName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputProjectName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputProjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputProjectName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputProjectName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputProjectName.Location = new System.Drawing.Point(279, 58);
			this.tbInputProjectName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputProjectName.Name = "tbInputProjectName";
			this.tbInputProjectName.PasswordChar = '\0';
			this.tbInputProjectName.PlaceholderText = "";
			this.tbInputProjectName.SelectedText = "";
			this.tbInputProjectName.Size = new System.Drawing.Size(307, 21);
			this.tbInputProjectName.TabIndex = 2;
			// 
			// tbInputProjectID
			// 
			this.tbInputProjectID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInputProjectID.DefaultText = "";
			this.tbInputProjectID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInputProjectID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInputProjectID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputProjectID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInputProjectID.Enabled = false;
			this.tbInputProjectID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputProjectID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbInputProjectID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInputProjectID.Location = new System.Drawing.Point(279, 17);
			this.tbInputProjectID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbInputProjectID.Name = "tbInputProjectID";
			this.tbInputProjectID.PasswordChar = '\0';
			this.tbInputProjectID.PlaceholderText = "";
			this.tbInputProjectID.ReadOnly = true;
			this.tbInputProjectID.SelectedText = "";
			this.tbInputProjectID.Size = new System.Drawing.Size(307, 21);
			this.tbInputProjectID.TabIndex = 2;
			// 
			// guna2HtmlLabel6
			// 
			this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel6.Location = new System.Drawing.Point(67, 168);
			this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
			this.guna2HtmlLabel6.Size = new System.Drawing.Size(99, 21);
			this.guna2HtmlLabel6.TabIndex = 1;
			this.guna2HtmlLabel6.Text = "Mã giáo viên : ";
			// 
			// guna2HtmlLabel5
			// 
			this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel5.Location = new System.Drawing.Point(67, 128);
			this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
			this.guna2HtmlLabel5.Size = new System.Drawing.Size(98, 21);
			this.guna2HtmlLabel5.TabIndex = 1;
			this.guna2HtmlLabel5.Text = "Mã sinh viên : ";
			// 
			// guna2HtmlLabel8
			// 
			this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel8.Location = new System.Drawing.Point(67, 92);
			this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
			this.guna2HtmlLabel8.Size = new System.Drawing.Size(86, 21);
			this.guna2HtmlLabel8.TabIndex = 1;
			this.guna2HtmlLabel8.Text = "Tên chủ đề : ";
			// 
			// guna2HtmlLabel7
			// 
			this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel7.Location = new System.Drawing.Point(67, 251);
			this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
			this.guna2HtmlLabel7.Size = new System.Drawing.Size(99, 21);
			this.guna2HtmlLabel7.TabIndex = 1;
			this.guna2HtmlLabel7.Text = "Ngày hết hạn : ";
			// 
			// guna2HtmlLabel4
			// 
			this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel4.Location = new System.Drawing.Point(67, 210);
			this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
			this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 21);
			this.guna2HtmlLabel4.TabIndex = 1;
			this.guna2HtmlLabel4.Text = "Ngày tạo : ";
			// 
			// guna2HtmlLabel3
			// 
			this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel3.Location = new System.Drawing.Point(67, 58);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new System.Drawing.Size(78, 21);
			this.guna2HtmlLabel3.TabIndex = 1;
			this.guna2HtmlLabel3.Text = "Tên đồ án : ";
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(67, 17);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(75, 21);
			this.guna2HtmlLabel2.TabIndex = 1;
			this.guna2HtmlLabel2.Text = "Mã đồ án  : ";
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(89, 26);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(104, 25);
			this.guna2HtmlLabel1.TabIndex = 9;
			this.guna2HtmlLabel1.Text = "Thêm Đồ án";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// btnBackProject
			// 
			this.btnBackProject.BackgroundImage = global::Oracle.Properties.Resources.icons8_left_100;
			this.btnBackProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBackProject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnBackProject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnBackProject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnBackProject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnBackProject.FillColor = System.Drawing.Color.Transparent;
			this.btnBackProject.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnBackProject.ForeColor = System.Drawing.Color.White;
			this.btnBackProject.Location = new System.Drawing.Point(25, 15);
			this.btnBackProject.Name = "btnBackProject";
			this.btnBackProject.Size = new System.Drawing.Size(51, 36);
			this.btnBackProject.TabIndex = 13;
			this.btnBackProject.Click += new System.EventHandler(this.btnBackProject_Click);
			// 
			// FormAddProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 503);
			this.Controls.Add(this.btnBackProject);
			this.Controls.Add(this.btnSubmitRefreshProject);
			this.Controls.Add(this.btnSubmitAddProject);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2HtmlLabel1);
			this.Name = "FormAddProject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAddProject";
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btnSubmitRefreshProject;
		private Guna.UI2.WinForms.Guna2Button btnSubmitAddProject;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.ComboBox cbTopicName;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtEndProject;
		private Guna.UI2.WinForms.Guna2TextBox tbInputProjectName;
		private Guna.UI2.WinForms.Guna2TextBox tbInputProjectID;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtCreateProject;
		private System.Windows.Forms.ComboBox cbTeachers;
		private System.Windows.Forms.ComboBox cbStudentByClass;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private Guna.UI2.WinForms.Guna2Button btnBackProject;
	}
}