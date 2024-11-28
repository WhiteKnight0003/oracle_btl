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
	public partial class FormAddProject : Form
	{
		private projectDTO project_dto;
		private ValidateData validate;
		public FormAddProject(projectDTO projectDTO)
		{
			InitializeComponent();
			this.project_dto = projectDTO;
			LoadInputId();
			validate = new ValidateData();
		}

		private void LoadInputId()
		{
			// lấy tên lớp
			DataTable dttopic = DAO.TopicDAO.Instance.GetTopicData();
			List<string> topicList = dttopic.AsEnumerable()
						  .Select(row => row.Field<string>("name"))
						  .ToList();
			foreach (string topic in topicList)
				cbTopicName.Items.Add(topic);


			DataTable dtStu = DAO.StudentsDAO.Instance.GetStudentData();
			List<string> StuList = dtStu.AsEnumerable()
						  .Select(row => row.Field<string>("ID"))
						  .ToList();
			foreach (string stu in StuList)
				cbStudentByClass.Items.Add(stu);

			DataTable dtTea = DAO.TeachersDAO.Instance.GetTeachersData();
			List<string> TeaList = dtTea.AsEnumerable()
						  .Select(row => row.Field<string>("ID"))
						  .ToList();
			foreach (string tea in TeaList)
				cbTeachers.Items.Add(tea);

			if (project_dto== null)
			{
				DataTable data = DAO.ProjectDAO.Instance.GetProjectsData();
				projectDTO projectLast = new projectDTO(data.Rows[data.Rows.Count - 1]);
				int proId = int.Parse(projectLast.Id.Substring(1)) + 1;

				tbInputProjectID.Text = "P" + proId.ToString();
				RefreshPro();
			}
			else
			{
				tbInputProjectID.Text = project_dto.Id;
				tbInputProjectName.Text = project_dto.Name;

				
			}

		}

		private void btnSubmitAddProject_Click(object sender, EventArgs e)
		{

		}


		private void RefreshPro()
		{
			tbInputProjectName.Text = "";
			cbTopicName.SelectedIndex = 0;
			cbStudentByClass.Text="";
			cbTeachers.SelectedIndex = 0;
			dtCreateProject.Value = DateTime.Now;
			dtEndProject.Value = DateTime.Now;
		}

		private void btnSubmitRefreshProject_Click(object sender, EventArgs e)
		{
			RefreshPro();
		}
	}
}
