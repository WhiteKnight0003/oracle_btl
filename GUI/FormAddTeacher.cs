using Oracle.DTO;
using Oracle.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Oracle.GUI
{
	public partial class FormAddTeacher : Form
	{
		private teachersDTO teachers;
		private ValidateData validate;
		private teachersDTO teacher_dto;

		public FormAddTeacher(teachersDTO teachers)
		{
			InitializeComponent();
			this.teacher_dto = teachers;
			LoadInputId();		
			validate = new ValidateData();
		}

		#region methods
		private void LoadInputId()
		{
			if(teacher_dto == null)
			{
				DataTable data = DAO.TeachersDAO.Instance.GetTeachersData();
				teachersDTO teacherLast = new teachersDTO(data.Rows[data.Rows.Count - 1]);
				int teaId = int.Parse(teacherLast.Id.Substring(1)) + 1;

				tbInputTeacherID.Text = "T" + teaId.ToString();
				RefreshTea();
			}
			else
			{
				tbInputTeacherID.Text = teacher_dto.Id;
				tbInputTeacherName.Text = teacher_dto.Name;
				tbInputTeacherPhone.Text = teacher_dto.Phone;
				tbInputTeacherCountry.Text = teacher_dto.Address;
				tbInputTeacherEmail.Text = teacher_dto.Email;
				dtInputTeacherBrithDay.Value = teacher_dto.Date;
				if(teacher_dto.Sex == "Nam")
				{
					rbTeacherFeMale.Checked = false;
					rbTeacherMale.Checked = true; 
				}
				else if (teacher_dto.Sex == "Nữ")
				{
					rbTeacherFeMale.Checked = true;
					rbTeacherMale.Checked = false;
				}
			}
		}

		private void checkError()
		{
			if (tbInputTeacherName.Text.Trim() =="")
			{
				errorProvider.SetError(tbInputTeacherName, "Tên đăng nhập không được để trống !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}

			if (tbInputTeacherCountry.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputTeacherCountry, "Quê quán không được để trống !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}

			if (tbInputTeacherPhone.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputTeacherPhone, "Số diện thoại không được để trống !");
				return;
			}
			else
			{
				if (!validate.validatePhone(tbInputTeacherPhone.Text))
				{
					errorProvider.SetError(tbInputTeacherPhone, "Số diện thoại không hợp lệ ! - một số điện thoại hợp lệ chỉ có 10 số ");
				}
				else
				{
					errorProvider.Clear();
				}
				
			}

			//  đối với email thì  nên xác minh cả trạng thái 
			if (tbInputTeacherEmail.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputTeacherEmail, "Email không được để trống !");
				return;
			}
			else
			{
				if (!validate.validateEmail(tbInputTeacherEmail.Text))
				{
					errorProvider.SetError(tbInputTeacherEmail, "Email này đang bị sai định dạng !");
				}
				else 
				{
					DataTable data = DAO.TeachersDAO.Instance.CheckTeacherEmail(tbInputTeacherEmail.Text.Trim());
					if(data.Rows.Count == 0) {
						errorProvider.Clear();
					}
					else
					{
						teachersDTO tea = new teachersDTO(data.Rows[0]);
						if(tea.IsActive == 0)
						{
							errorProvider.Clear();
						}
						else
						{
							errorProvider.SetError(tbInputTeacherEmail, "Email này đã được sử dụng !");
						}
					}
				}

			}

			if (!rbTeacherFeMale.Checked && !rbTeacherMale.Checked)
			{
				errorProvider.SetError(gbSexteachers, "Bạn chưa chọn giới tính !");
			}
			else
			{
				errorProvider.Clear();
			}
		}
		private void InsertTeachers(teachersDTO teachers)
		{
			if (DAO.TeachersDAO.Instance.InsertTeacher(teachers))
			{
				MessageBox.Show("Thêm giáo viên có mã : " + teachers.Id + "  và tên :" + teachers.Name + "  thành công !");
			}
			else
			{
				MessageBox.Show("Thêm giáo viên có mã : " + teachers.Id + " thất bại !");
			}
		}

		#endregion

		#region events
		private void btnSubmitAddTeachers_Click(object sender, EventArgs e)
		{
					
			teachers = new teachersDTO();
			teachers.Id = tbInputTeacherID.Text.Trim();
			teachers.Name = tbInputTeacherName.Text.Trim();
			teachers.Date = dtInputTeacherBrithDay.Value.Date;
			teachers.Address = tbInputTeacherCountry.Text.Trim();
			teachers.Phone = tbInputTeacherPhone.Text.Trim();
			teachers.Email = tbInputTeacherEmail.Text.Trim();
			teachers.IsActive = 1;

			DataTable dataClass = DAO.TeachersDAO.Instance.GetTeacher(teachers.Id);
			if (rbTeacherMale.Checked)
			{
				teachers.Sex = "Nam";
			}
			else if (rbTeacherFeMale.Checked)
			{
				teachers.Sex = "Nữ";
			}

			if (dataClass.Rows.Count == 0)
			{
				checkError();
				if (teachers.Name != "" && teachers.Address != "" && teachers.Phone != "" && validate.validatePhone(teachers.Phone) && validate.validateEmail(teachers.Email))
				{
					DataTable data = DAO.TeachersDAO.Instance.CheckTeacherEmail(tbInputTeacherEmail.Text.Trim());
					if (data.Rows.Count == 0)
					{
						InsertTeachers(teachers);
					}
					else
					{
						teachersDTO tea = new teachersDTO(data.Rows[data.Rows.Count - 1]);
						if (tea.IsActive == 0)
						{
							InsertTeachers(teachers);
						}
						else
						{
							errorProvider.SetError(tbInputTeacherEmail, "Email này đã được sử dụng !");
						}
					}
				}
			}
			else
			{
				if (teachers.Name != "" && teachers.Address != "" && teachers.Phone != "" && validate.validatePhone(teachers.Phone) && validate.validateEmail(teachers.Email))
				{
					DataTable data = DAO.TeachersDAO.Instance.CheckTeacherEmail(tbInputTeacherEmail.Text.Trim());
					// chưa tồn tại email
					if (data.Rows.Count == 0)
					{
						errorProvider.Clear();
						if (DAO.TeachersDAO.Instance.UpdateTeacher(teachers))
						{
							MessageBox.Show("Cập nhật thông tin của giáo viên " + teachers.Id + "  thành công ! ");
						}
						else
						{
							MessageBox.Show("Cập nhật thông tin của giáo viên " + teachers.Id + "  thất bại ! ");
						}
					}
					// đã tồn tại email
					else
					{
						teachersDTO teachers_data = new teachersDTO(data.Rows[data.Rows.Count - 1]);
						if(teacher_dto.Email == teachers_data.Email)
						{
							errorProvider.Clear();
							if (DAO.TeachersDAO.Instance.UpdateTeacher(teachers))
							{
								MessageBox.Show("Cập nhật thông tin của giáo viên " + teachers.Id + "  thành công ! ");
							}
							else
							{
								MessageBox.Show("Cập nhật thông tin của giáo viên " + teachers.Id + "  thất bại ! ");
							}
						}
						else
						{
							errorProvider.SetError(tbInputTeacherEmail, "Email này đã được sử dụng !");
						}
					}
				}
				else if (!validate.validateEmail(teachers.Email))
				{
					errorProvider.SetError(tbInputTeacherEmail, "Email này đang bị sai định dạng !s");
				}
			}
			
		}
		#endregion

		private void RefreshTea()
		{
			tbInputTeacherName.Text = "";
			tbInputTeacherPhone.Text = "";
			tbInputTeacherCountry.Text = "";
			tbInputTeacherEmail.Text = "";
			dtInputTeacherBrithDay.Value = DateTime.Now;
			rbTeacherFeMale.Checked = false;
			rbTeacherMale.Checked = false;
		}
		private void btnSubmitRefreshTeachers_Click(object sender, EventArgs e)
		{
			RefreshTea();
		}
	}
}
