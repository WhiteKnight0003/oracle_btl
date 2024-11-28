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
		private projectDTO project_needed;
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

			if (project_dto.Id == null)
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

				DataTable dtTopic = DAO.TopicDAO.Instance.GetTopicID(project_dto.Id_topic);
				topicDTO topic_here = new topicDTO(dtTopic.Rows[0]); 
				cbTopicName.Text = topic_here.Name;

				cbStudentByClass.Text = project_dto.Id_student;
				cbTeachers.Text = project_dto.Id_teacher;
				dtCreateProject.Value = project_dto.Create_at;
				dtEndProject.Value = project_dto.Endtime;
			}

		}

		private void checkError()
		{
			if (tbInputProjectName.Text.Trim() == "")
			{
				errorProvider.SetError(tbInputProjectName, "Tên đồ án không được để trống !");
				return;
			}
			else
			{
				errorProvider.Clear();
			}

		}

		private void btnSubmitAddProject_Click(object sender, EventArgs e)
		{
			checkError();
			project_needed = new projectDTO();
			project_needed.Id = tbInputProjectID.Text;
			project_needed.Name = tbInputProjectName.Text;

			DataTable dtTopic = DAO.TopicDAO.Instance.GetTopicName(cbTopicName.Text);
			topicDTO topic = new topicDTO(dtTopic.Rows[0]);
			project_needed.Id_topic = topic.Id;
			
			project_needed.Id_student = cbStudentByClass.Text;
			project_needed.Id_teacher = cbTeachers.Text;

			project_needed.Create_at = dtCreateProject.Value;
			project_needed.Endtime = dtEndProject.Value;

			DataTable dtPro = DAO.ProjectDAO.Instance.GetProjectID(project_needed.Id);
			if(dtPro.Rows.Count ==0)
			{
				if (project_needed.Name != "")
				{
					if (DAO.ProjectDAO.Instance.InsertProject(project_needed))
					{
						MessageBox.Show("Thêm đồ án mã  " + project_needed.Id + "  thành công !");
					}
					else
					{
						MessageBox.Show("Thêm đồ án mã  thất bại !");
					}
				}
				else
				{
					checkError();
				}
			}
			else
			{
				if (project_needed.Name != "")
				{
					if (DAO.ProjectDAO.Instance.UpdateProject(project_needed))
					{
						MessageBox.Show("Cập nhật đồ án mã  " + project_needed.Id + "  thành công !");
					}
					else
					{
						MessageBox.Show("Cập nhật đồ án mã  thất bại !");
					}
				}
				else
				{
					checkError();
				}
			}

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
