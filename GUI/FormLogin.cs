using Oracle.DAO;
using Oracle.DTO;
using Oracle.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle
{
	public partial class FormLogin : Form
	{
		private FormMain fm;
		private loginDTO logindto;
		public FormLogin()
		{
			InitializeComponent();
		}
		#region Events
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txbL_username.Text;
			string password = txbL_password.Text;
			if (DAO.UserDAO.Instance.checkLogin(userName, password))
			{
				logindto = DAO.UserDAO.Instance.info_account_login(userName, password);
				if(logindto.Powerfull== "Giáo viên")
				{
					DataTable data = DAO.TeachersDAO.Instance.GetTeacher(logindto.Id);
					teachersDTO teachers = new teachersDTO(data.Rows[data.Rows.Count-1]);
					if(teachers.IsActive == 0)
					{
						MessageBox.Show("Đăng nhập thất bại - Tài khoản này không được phép truy cập !");
					}
					else
					{
						fm = new FormMain(logindto);
						MessageBox.Show("Đăng nhập thành công !");
						this.Hide();
						fm.ShowDialog();
					}
				}

				else if(logindto.Powerfull == "Sinh viên")
 				{
					DataTable data = DAO.StudentsDAO.Instance.GetStudent(logindto.Id);
					studentDTO student = new studentDTO(data.Rows[data.Rows.Count - 1]);
					if (student.Isactive == 0)
					{
						MessageBox.Show("Đăng nhập thất bại - Tài khoản này không được phép truy cập !");
					}
					else
					{
						fm = new FormMain(logindto);
						MessageBox.Show("Đăng nhập thành công !");
						this.Hide();
						fm.ShowDialog();
					}
				}
				else
				{
					fm = new FormMain(logindto);
					MessageBox.Show("Đăng nhập thành công !");
					this.Hide();
					fm.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại - Hãy thử lại !");
			}
		}
		#endregion

		private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Diagnostics.Process.GetCurrentProcess().Kill();
			Application.Exit();
		}
	}
}
