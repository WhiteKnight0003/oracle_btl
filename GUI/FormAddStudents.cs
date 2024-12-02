using Oracle.DAO;
using Oracle.DTO;
using Oracle.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle.GUI
{
	public partial class FormAddStudents : Form
	{
		private studentDTO student;
		private ValidateData validate;
		private studentDTO student_dto;
		public FormAddStudents(studentDTO student_dto)
		{
			InitializeComponent();
			this.student_dto = student_dto;
			LoadInputId();
			validate = new ValidateData();
			
		}
		#region methods
		private void LoadInputId()
		{
			DataTable dt = DAO.ClassDAO.Instance.GetClassessData();
			List<string> ClassList = dt.AsEnumerable()
						  .Select(row => row.Field<string>("name"))
						  .ToList();
			foreach (string Class in ClassList)
				cbClassID.Items.Add(Class);

			if (student_dto.Id == null)
			{
				DataTable data = DAO.StudentsDAO.Instance.GetStudentData();
				studentDTO studentLast = new studentDTO(data.Rows[data.Rows.Count - 1]);
				int teaId = int.Parse(studentLast.Id.Substring(1)) + 1;

				tbInputStudentID.Text = "S" + teaId.ToString();
				RefreshStu();
			}
			else
			{
				tbInputStudentID.Text = student_dto.Id;
				tbInputStudentName.Text = student_dto.Name;
				tbInputStudentPhone.Text = student_dto.Phone;
				tbInputStudentCountry.Text = student_dto.Address;
				tbInputStudentEmail.Text = student_dto.Email;
				dtInputStudentBrithDay.Value = student_dto.Birthday;

				string Id_class = student_dto.Id_class;
				DataTable dataClass = DAO.ClassDAO.Instance.GetClassID(Id_class);
				ClassDTO classdto = new ClassDTO(dataClass.Rows[0]);
				cbClassID.Text = classdto.Name;

				if (student_dto.Sex == "Nam")
				{
					rbStudentFeMale.Checked = false;
					rbStudentMale.Checked = true;
				}
				else if (student_dto.Sex == "Nữ")
				{
					rbStudentFeMale.Checked = true;
					rbStudentMale.Checked = false;
				}
			}
			

			
		}

		private void checkError()
		{
			if (tbInputStudentName.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputStudentName, "Tên đăng nhập không được để trống !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}

			if (tbInputStudentCountry.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputStudentCountry, "Quê quán không được để trống !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}

			if (tbInputStudentPhone.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputStudentPhone, "Số diện thoại không được để trống !");
				return;
			}
			else
			{
				if (!validate.validatePhone(tbInputStudentPhone.Text))
				{
					errorProvider.SetError(tbInputStudentPhone, "Số diện thoại không hợp lệ ! - một số điện thoại hợp lệ chỉ có 10 số ");
				}
				else
				{
					errorProvider.Clear();
				}

			}

			//  đối với email thì  nên xác minh cả trạng thái 
			if (tbInputStudentEmail.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputStudentEmail, "Email không được để trống !");
				return;
			}
			else
			{
				if (!validate.validateEmail(tbInputStudentEmail.Text))
				{
					errorProvider.SetError(tbInputStudentEmail, "Email này đang bị sai định dạng !");
				}
				else
				{
					DataTable data = DAO.StudentsDAO.Instance.CheckStudentEmail(tbInputStudentEmail.Text.Trim());
					if (data.Rows.Count == 0)
					{
						errorProvider.Clear();
					}
					else
					{
						studentDTO stu = new studentDTO(data.Rows[0]);
						if (stu.Isactive == 0)
						{
							errorProvider.Clear();
						}
						else
						{
							errorProvider.SetError(tbInputStudentEmail, "Email này đã được sử dụng !");
						}
					}
				}

			}

			if (!rbStudentFeMale.Checked && !rbStudentMale.Checked)
			{
				errorProvider.SetError(gbSexStudents, "Bạn chưa chọn giới tính !");
			}
			else
			{
				errorProvider.Clear();
			}
		}
		private void InsertStudent(studentDTO student)
		{
			if (DAO.StudentsDAO.Instance.InsertStudent(student))
			{
				MessageBox.Show("Thêm giáo viên có mã : " + student.Id + "  và tên :" + student.Name + "  thành công !");
			}
			else
			{
				MessageBox.Show("Thêm giáo viên có mã : " + student.Id + " thất bại !");
			}
		}

		#endregion

		#region events
		private void btnSubmitAddStudent_Click(object sender, EventArgs e)
		{
		
			student = new studentDTO();
			student.Id = tbInputStudentID.Text.Trim();
			student.Name = tbInputStudentName.Text.Trim();
			student.Birthday = dtInputStudentBrithDay.Value.Date;
			student.Address = tbInputStudentCountry.Text.Trim();
			student.Phone = tbInputStudentPhone.Text.Trim();
			student.Email = tbInputStudentEmail.Text.Trim();
			student.Isactive = 1;
			student.Id_class = cbClassID.Text;

			DataTable dt = DAO.ClassDAO.Instance.GetClass(cbClassID.Text);
			ClassDTO cla = new ClassDTO(dt.Rows[0]);
			student.Id_class = cla.Id;


			if (rbStudentMale.Checked)
			{
				student.Sex = "Nam";
			}
			else if (rbStudentFeMale.Checked)
			{
				student.Sex = "Nữ";
			}

			DataTable Stud = DAO.StudentsDAO.Instance.GetStudent(student.Id);
			if(Stud.Rows.Count ==0)
			{
				checkError();
				if (student.Name != "" && student.Address != "" && student.Phone != "" && validate.validatePhone(student.Phone) && validate.validateEmail(student.Email))
				{
					DataTable data = DAO.StudentsDAO.Instance.CheckStudentEmail(tbInputStudentEmail.Text.Trim());
					if (data.Rows.Count == 0)
					{
						InsertStudent(student);
					}
					else
					{
						studentDTO stu = new studentDTO(data.Rows[data.Rows.Count - 1]);
						if (stu.Isactive == 0)
						{
							InsertStudent(student);
						}
						else
						{
							errorProvider.SetError(tbInputStudentEmail, "Email này đã được sử dụng !");
						}
					}
				}
				else if (!validate.validateEmail(tbInputStudentEmail.Text.Trim()))
				{
					errorProvider.SetError(tbInputStudentEmail, "Email này đang bị sai định dạng !");
				}
			}
			else
			{
				if (student.Name != "" && student.Address != "" && student.Phone != "" && validate.validatePhone(student.Phone) && validate.validateEmail(student.Email))
				{
					DataTable data = DAO.StudentsDAO.Instance.CheckStudentEmail(student.Email);	
					if (data.Rows.Count == 0)
					{
						errorProvider.Clear();
						if (DAO.StudentsDAO.Instance.UpdateStudent(student))
						{
							MessageBox.Show("Cập nhật thông tin của sinh viên " + student.Id + "  thành công ! ");
						}
						else
						{
							MessageBox.Show("Cập nhật thông tin của sinh viên " + student.Id + "  thất bại ! ");
						}
					}
					else
					{
						studentDTO stu_data = new studentDTO(data.Rows[data.Rows.Count - 1]);
						if (student_dto.Email == stu_data.Email)
						{
							errorProvider.Clear();
							if (DAO.StudentsDAO.Instance.UpdateStudent(student))
							{
								MessageBox.Show("Cập nhật thông tin của sinh viên " + student.Id + "  thành công ! ");
							}
							else
							{
								MessageBox.Show("Cập nhật thông tin của sinh viên " + student.Id + "  thất bại ! ");
							}
						}
						else
						{
							errorProvider.SetError(tbInputStudentEmail, "Email này đã được sử dụng !");
						}
					}
				}
				else if (!validate.validateEmail(student.Email))
				{
					errorProvider.SetError(tbInputStudentEmail, "Email này đang bị sai định dạng !s");
				}
			}

			
		}
		#endregion

		private void RefreshStu()
		{
			tbInputStudentName.Text = "";
			dtInputStudentBrithDay.Value = DateTime.Now;
			tbInputStudentEmail.Text = "";
			tbInputStudentPhone.Text = "";
			tbInputStudentCountry.Text = "";
			rbStudentFeMale.Checked = false;
			rbStudentMale.Checked = false;
		}
		private void btnSubmitRefreshStudent_Click(object sender, EventArgs e)
		{
			RefreshStu();
		}
	}
}
