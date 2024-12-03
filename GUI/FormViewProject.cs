using Oracle.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Oracle.GUI
{
	public partial class FormViewProject : Form
	{
		private studentDTO student;
		private loginDTO login;
		private FormMain main;
		public FormViewProject(studentDTO student, loginDTO login)
		{
			InitializeComponent();
			this.student = student;
			InfoProjectByStudent();
			this.login = login;
		}

		private void InfoProjectByStudent()
		{
			DataTable dataPro = DAO.ProjectDAO.Instance.GetProjectByIdStudent(student.Id);
			projectDTO proLogin = new projectDTO(dataPro.Rows[dataPro.Rows.Count - 1]);

			DataTable dataClass = DAO.ClassDAO.Instance.GetClassID(student.Id_class);
			ClassDTO classLogin = new ClassDTO(dataClass.Rows[0]);


			DataTable datatea = DAO.TeachersDAO.Instance.GetTeacher(proLogin.Id_teacher);
			teachersDTO teaLogin = new teachersDTO(datatea.Rows[0]);

			DataTable dataDet = DAO.DetailDAO.Instance.GetProjectDetailsByIdProject(proLogin.Id);
			DetailsDTO detailPro = new DetailsDTO(dataDet.Rows[0]);


			lbNameStudent.Text = student.Name;
			lbIDStudent.Text = student.Id;
			lbIDProject.Text = proLogin.Id;
			lbBirthdayStudent.Text = student.Birthday.ToString("dd/MM/yyyy");
			lbClassStudent.Text = classLogin.Name;
			lbCountryStudent.Text = student.Address;
			lbSexStudent.Text = student.Sex;
			lbNameTeacherGuide.Text = teaLogin.Name;
			lbNameProjectByStu.Text = proLogin.Name;

			if (detailPro.Filename == "")
			{
				lbStateByProject.Text = "Chưa hoàn thành ";
				lbStateByProject.ForeColor = Color.Red;
				lbViewFileName.Text = "";
				lbDateCompleteProject.Text = "";
				btnViewFile.Visible = false;
			}
			else
			{
				lbStateByProject.Text = "Đã hoàn thành ";
				lbStateByProject.ForeColor = Color.Green;
				lbViewFileName.Text = detailPro.Filename;
				lbDateCompleteProject.Text = "Ngày nộp : ";
				lbHideDateCompleteProject.Text = detailPro.Complete_date.ToString("dd/MM/yyyy");
				btnViewFile.Visible = true;
			}
		}

		private void btnViewFile_Click(object sender, EventArgs e)
		{
			DataTable dataStu = DAO.StudentsDAO.Instance.GetStudent(student.Id);
			studentDTO stuLogin = new studentDTO(dataStu.Rows[0]);

			DataTable dataPro = DAO.ProjectDAO.Instance.GetProjectByIdStudent(stuLogin.Id);
			projectDTO proLogin = new projectDTO(dataPro.Rows[0]);

			DataTable dataDet = DAO.DetailDAO.Instance.GetProjectDetailsByIdProject(proLogin.Id);
			DetailsDTO detailPro =	 new DetailsDTO(dataDet.Rows[0]);

			byte[] dataWord = detailPro.Content;
			// Tạo file tạm 
			string tempFilePath = Path.GetTempFileName() + ".docx";
			File.WriteAllBytes(tempFilePath, dataWord);

			// Mở file
			System.Diagnostics.Process.Start(tempFilePath);
		}

		private void btnBackViewproject_Click(object sender, EventArgs e)
		{
			this.Hide();
			main = new FormMain(login);
			main.Show();
		}
	}
}
