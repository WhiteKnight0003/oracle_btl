using Guna.UI2.WinForms;
using Oracle.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle.GUI
{
	public partial class FormMain : Form
	{
		private FormAddProject faProject;
		private FormAddStudents faStudent;
		private FormAddTeacher faTeacher;

		private loginDTO logindto;
		private int currentPageTeachers = 1; // Trang hiện tại
		private int recordsPerPage = 5; // Số bản ghi trên mỗi trang
		private int totalRecordsTeachers = 0; // Tổng số bản ghi
		private int totalPageTeachers = 0;

		private int currentPageStudents = 1; // Trang hiện tại
		private int totalRecordsStudents = 0; // Tổng số bản ghi
		private int totalPageStudents = 0;

		private int currentPageProject = 1; // Trang hiện tại
		private int totalRecordsProject = 0; // Tổng số bản ghi
		private int totalPageProject = 0;

		public FormMain(loginDTO loginDTO)
		{
			InitializeComponent();
			this.logindto = loginDTO;
			Decentralization();
			pageListTeachersData();
			pageListStudentsData();
			pageListProjectData();
			PageListAccountData();
		}

		private void Decentralization()
		{
			MessageBox.Show(logindto.Powerfull);
			if(logindto.Powerfull == "Trưởng khoa")
			{
				tcMenu.TabPages.Remove(PageRemind);
				tcMenu.TabPages.Remove(PageListStudentGuildByTeachers);
				tcMenu.TabPages.Remove(PageProjectByStudents);
			}
			else if(logindto.Powerfull == "Giáo viên")
			{
				tcMenu.TabPages.Remove(PageListTeachers);
				tcMenu.TabPages.Remove(PageProcessReport);
				tcMenu.TabPages.Remove(PageProjectByStudents);
				tcMenu.TabPages.Remove(PageListAccount);
			}
			else if (logindto.Powerfull == "Sinh viên")
			{
				tcMenu.TabPages.Remove(PageListTeachers);
				tcMenu.TabPages.Remove(PageListStudents);
				tcMenu.TabPages.Remove(PageProcessReport);
				tcMenu.TabPages.Remove(PageProjectByStudents);
				tcMenu.TabPages.Remove(PageListAccount);
			}

			lbUserLogin.Text = "Xin Chào  " + logindto.Name + "  ! ";
		}

		// danh sách giáo viên 
		private void pageListTeachersData()
		{
			TabPage PageListTeachers = tcMenu.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Name == "PageListTeachers");
			if (PageListTeachers != null)
			{
				// view Info table
				DataTable data = DAO.TeachersDAO.Instance.GetTeachersData();
				if(data.Rows.Count >0)
				{
					totalRecordsTeachers = data.Rows.Count;

					// Lấy dữ liệu cho trang hiện tại
					var pageData = data.AsEnumerable()
									 .Skip((currentPageTeachers - 1) * recordsPerPage)
									 .Take(recordsPerPage)
									 .CopyToDataTable();

					// Gán dữ liệu vào DataGridView
					DatagvListTeachers.DataSource = pageData;
					DatagvListTeachers.Columns[0].HeaderText = "Mã giáo viên";
					DatagvListTeachers.Columns[1].HeaderText = "Họ và tên";
					DatagvListTeachers.Columns[2].HeaderText = "Ngày sinh";
					DatagvListTeachers.Columns[3].HeaderText = "Quê quán";
					DatagvListTeachers.Columns[4].HeaderText = "Số điện thoại";
					DatagvListTeachers.Columns[5].HeaderText = "Email";
					DatagvListTeachers.Columns[6].HeaderText = "Giới tính";
					DatagvListTeachers.Columns[7].Visible = false;
					DatagvListTeachers.ColumnHeadersHeight = 30;
					DatagvListTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


					totalPageTeachers = totalRecordsTeachers / recordsPerPage;
					if (totalRecordsTeachers % recordsPerPage != 0)
					{
						totalPageTeachers += 1;
					}
					lbViewTotalPageTea.Text = totalPageTeachers.ToString();
					lbViewCurrentPageTea.Text = currentPageTeachers.ToString();
					btnPageCurrentTea.Text = currentPageTeachers.ToString();

					if (currentPageTeachers == 1)
					{
						btnPageBeforeTea.Visible = false;
						btnPageAfterTea.Visible = true;
					}
					else if (currentPageTeachers == totalPageTeachers)
					{
						btnPageBeforeTea.Visible = true;
						btnPageAfterTea.Visible = false;
					}
					else
					{
						btnPageBeforeTea.Visible = true;
						btnPageAfterTea.Visible = true;
					}
				}
			}
		}

		private void btnPageBeforeTea_Click(object sender, EventArgs e)
		{
			if (currentPageTeachers > 1)
			{
				currentPageTeachers--;
				pageListTeachersData(); // Tải dữ liệu cho trang tiếp theo
			}
		}

		private void btnPageAfterTea_Click(object sender, EventArgs e)
		{
			if (currentPageTeachers * recordsPerPage < totalRecordsTeachers)
			{
				currentPageTeachers++;
				pageListTeachersData(); // Tải dữ liệu cho trang tiếp theo
			}
		}

		// danh sách sinh viên 
		private void pageListStudentsData()
		{
			TabPage PageListStudents = tcMenu.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Name == "PageListStudents");
			if (PageListStudents != null)
			{
				// view Info table
				DataTable data = DAO.StudentsDAO.Instance.GetStudentData();
				if(data.Rows.Count > 0)
				{
					totalRecordsStudents = data.Rows.Count;

					// Lấy dữ liệu cho trang hiện tại
					var pageDataStu = data.AsEnumerable()
									 .Skip((currentPageStudents - 1) * recordsPerPage)
									 .Take(recordsPerPage)
									 .CopyToDataTable();

					// Gán dữ liệu vào DataGridView
					DatagvListStudents.DataSource = pageDataStu;
					DatagvListStudents.Columns[0].HeaderText = "Mã sinh viên";
					DatagvListStudents.Columns[1].HeaderText = "Họ và tên";
					DatagvListStudents.Columns[2].HeaderText = "Mã lớp";
					DatagvListStudents.Columns[3].HeaderText = "Ngày sinh";
					DatagvListStudents.Columns[4].HeaderText = "Quê quán";
					DatagvListStudents.Columns[5].HeaderText = "Số điện thoại";
					DatagvListStudents.Columns[6].HeaderText = "Email";
					DatagvListStudents.Columns[7].HeaderText = "Giới tính";
					DatagvListStudents.Columns[8].Visible = false;
					DatagvListStudents.ColumnHeadersHeight = 30;
					DatagvListStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


					totalPageStudents = totalRecordsStudents / recordsPerPage;
					if (totalRecordsStudents % recordsPerPage != 0)
					{
						totalPageStudents += 1;
					}
					lbViewTotalPageStu.Text = totalPageStudents.ToString();
					lbViewCurrentPageStu.Text = currentPageStudents.ToString();
					btnPageCurrentStu.Text = currentPageStudents.ToString();

					if (currentPageStudents == 1)
					{
						btnPageBeforeStu.Visible = false;
						btnPageAfterStu.Visible = true;
					}
					else if (currentPageStudents == totalPageStudents)
					{
						btnPageBeforeStu.Visible = true;
						btnPageAfterStu.Visible = false;
					}
					else
					{
						btnPageBeforeStu.Visible = true;
						btnPageAfterStu.Visible = true;

					}
				}
			}
		}

		

		private void btnPageBeforeStu_Click(object sender, EventArgs e)
		{
			if (currentPageStudents > 1)
			{
				currentPageStudents--;
				pageListStudentsData(); // Tải dữ liệu cho trang trước
			}
		}

		private void btnPageAfterStu_Click(object sender, EventArgs e)
		{
			if (currentPageStudents * recordsPerPage < totalRecordsStudents)
			{
				currentPageStudents++;
				pageListStudentsData(); // Tải dữ liệu cho trang tiếp theo
			}
		}


		// danh sách đồ án

		private void pageListProjectData()
		{
			TabPage PageListProjects = tcMenu.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Name == "PageListProjects");
			if (PageListProjects != null)
			{
				// view Info table
				DataTable data = DAO.ProjectDAO.Instance.GetProjectsData();
				if(data.Rows.Count > 0)
				{
					totalRecordsProject = data.Rows.Count;

					// Lấy dữ liệu cho trang hiện tại
					var pageData = data.AsEnumerable()
									 .Skip((currentPageProject - 1) * recordsPerPage)
									 .Take(recordsPerPage)
									 .CopyToDataTable();

					// Gán dữ liệu vào DataGridView
					DatagvListProjects.DataSource = pageData;
					DatagvListProjects.Columns[0].HeaderText = "Mã đồ án";
					DatagvListProjects.Columns[1].HeaderText = "Họ và tên";
					DatagvListProjects.Columns[2].HeaderText = "Mã chủ đề";
					DatagvListProjects.Columns[3].HeaderText = "Mã sinh viên";
					DatagvListProjects.Columns[4].HeaderText = "Mã giáo viên";
					DatagvListProjects.Columns[5].HeaderText = "Ngày tạo";
					DatagvListProjects.Columns[6].HeaderText = "Hạn nộp";
					DatagvListProjects.ColumnHeadersHeight = 30;
					DatagvListProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


					totalPageProject = totalRecordsProject / recordsPerPage;
					if (totalRecordsProject % recordsPerPage != 0)
					{
						totalPageProject += 1;
					}
					lbViewTotalPagePro.Text = totalPageProject.ToString();
					lbViewCurrentPagePro.Text = currentPageProject.ToString();
					btnPageCurrentPro.Text = currentPageProject.ToString();

					if (currentPageProject == 1)
					{
						btnPageBeforePro.Visible = false;
						btnPageAfterPro.Visible = true;
					}
					else if (currentPageProject == totalPageProject)
					{
						btnPageBeforePro.Visible = true;
						btnPageAfterPro.Visible = false;
					}
					else
					{
						btnPageBeforePro.Visible = true;
						btnPageAfterPro.Visible = true;
					}
				}
				
			}
		}
		private void btnPageAfterPro_Click(object sender, EventArgs e)
		{
			if (currentPageProject * recordsPerPage < totalRecordsProject)
			{
				currentPageProject++;
				pageListProjectData(); // Tải dữ liệu cho trang tiếp theo
			}
		}

		private void btnPageBeforePro_Click(object sender, EventArgs e)
		{
			if (currentPageProject > 1)
			{
				currentPageProject--;
				pageListProjectData(); // Tải dữ liệu cho trang trước
			}
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Diagnostics.Process.GetCurrentProcess().Kill();
			Application.Exit();
		}

		private void btnAddTeachers_Click(object sender, EventArgs e)
		{
			teachersDTO tea = new teachersDTO();
			faTeacher = new FormAddTeacher(tea);
			this.Hide();
			faTeacher.ShowDialog();
		}

		private void btnAddStudents_Click(object sender, EventArgs e)
		{
			studentDTO stu = new studentDTO();
			faStudent  = new FormAddStudents(stu);
			this.Hide();
			faStudent.ShowDialog();
		}

		private void btnAddProject_Click(object sender, EventArgs e)
		{
			projectDTO pro = new projectDTO();
			faProject = new FormAddProject(pro);
			this.Hide();
			faProject.ShowDialog();
		}

		private void btnDeleteTeachers_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				int index = DatagvListTeachers.CurrentCell.RowIndex;
				int res_ind = (currentPageTeachers- 1) * recordsPerPage + index;
				teachersDTO tea = new teachersDTO(DAO.TeachersDAO.Instance.GetTeachersData().Rows[res_ind]);
				tea.IsActive = 0;
				if (DAO.TeachersDAO.Instance.UpdateTeacher(tea))
				{
					MessageBox.Show("Xóa giáo viên có mã :  " + tea.Id + "  thành công !");
					pageListTeachersData();
				}
				else
				{
					MessageBox.Show("Xóa thất bại !");
				}
			}
		}

		private void btnDeleteStudents_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
			{
				int index = DatagvListStudents.CurrentCell.RowIndex;

				int res_ind = (currentPageStudents-1) * recordsPerPage + index ;
				studentDTO stu = new studentDTO(DAO.StudentsDAO.Instance.GetStudentData().Rows[res_ind]);
				stu.Isactive = 0;
				if (DAO.StudentsDAO.Instance.UpdateStudent(stu))
				{
					MessageBox.Show("Xóa sinh viên có mã :  " + stu.Id + "  thành công !");
					pageListStudentsData();

				}
				else
				{
					MessageBox.Show("Xóa thất bại !");
				}
			}
		}

		private void btnModifyStudents_Click(object sender, EventArgs e)
		{
			int index = DatagvListStudents.CurrentCell.RowIndex;
			int res_ind = (currentPageStudents - 1) * recordsPerPage + index;
			studentDTO stu = new studentDTO(DAO.StudentsDAO.Instance.GetStudentData().Rows[res_ind]);

			faStudent = new FormAddStudents(stu);
			this.Hide();
			faStudent.ShowDialog();
		}

		private void btnModifyTeachers_Click(object sender, EventArgs e)
		{
			int index = DatagvListTeachers.CurrentCell.RowIndex;
			int res_ind = (currentPageTeachers - 1) * recordsPerPage + index;
			teachersDTO tea = new teachersDTO(DAO.TeachersDAO.Instance.GetTeachersData().Rows[res_ind]);
			
			faTeacher = new FormAddTeacher(tea);
			this.Hide();
			faTeacher.ShowDialog();

		}

		private void btnModifyProject_Click(object sender, EventArgs e)
		{
			int index = DatagvListProjects.CurrentCell.RowIndex;
			int res_ind = (currentPageProject - 1) * recordsPerPage + index;
			projectDTO pro = new projectDTO(DAO.ProjectDAO.Instance.GetProjectsData().Rows[res_ind]);

			faProject = new FormAddProject(pro);
			this.Hide();
			faProject.ShowDialog();
		}

		private void btnDeleteProject_Click(object sender, EventArgs e)
		{

		}

		private void btnViewProject_Click(object sender, EventArgs e)
		{
			int index = DatagvListProjects.CurrentCell.RowIndex;
			int res_ind = (currentPageProject - 1) * recordsPerPage + index;
			projectDTO pro = new projectDTO(DAO.ProjectDAO.Instance.GetProjectsData().Rows[res_ind]);

			//faProject = new FormAddProject(pro);
			//this.Hide();
			//faProject.ShowDialog();
		}


		private void setupCbViewAccTea()
		{
			cbViewAcc.Items.Clear();
			DataTable dttea = DAO.TeachersDAO.Instance.GetTeacherNotLogin();
			if (dttea.Rows.Count > 0)
			{
				List<string> TeaList = dttea.AsEnumerable()
					  .Select(row => row.Field<string>("ID"))
					  .ToList();
				foreach (string tea in TeaList)
					cbViewAcc.Items.Add(tea);
			}
		}

		private void setupCbViewAccStu()
		{
			cbViewAcc.Items.Clear();
			DataTable dttea = DAO.StudentsDAO.Instance.GetStudentNotLogin();
			if (dttea.Rows.Count > 0)
			{
				List<string> StuList = dttea.AsEnumerable()
					  .Select(row => row.Field<string>("ID"))
					  .ToList();
				foreach (string stu in StuList)
					cbViewAcc.Items.Add(stu);
			}
		}
		private void setupPageAcc()
		{
			cbTypeAccount.Items.Clear();
			cbTypeAccount.Items.Add("Giáo viên");
			cbTypeAccount.Items.Add("Sinh viên");

			datagvListAccount.DataSource = DAO.UserDAO.Instance.GetAccountDataWhile();

			datagvListAccount.Columns[0].HeaderText = "Mã tài khoản";
			datagvListAccount.Columns[1].HeaderText = "Tên đăng nhập";
			datagvListAccount.Columns[2].HeaderText = "Mật khẩu";
			datagvListAccount.Columns[3].HeaderText = "Tên đầy đủ";
			datagvListAccount.Columns[4].HeaderText = "Chức vụ";
			datagvListAccount.ColumnHeadersHeight = 30;
			datagvListAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			cbFitterAcc.Items.Clear();
			cbFitterAcc.Items.Add("Giáo viên");
			cbFitterAcc.Items.Add("Sinh viên");
		}
		private void PageListAccountData()
		{
			TabPage PageListAccount = tcMenu.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Name == "PageListAccount");
			if(PageListAccount != null)
			{
				setupPageAcc();
				setupCbViewAccTea();
			}
			
		}

		private void cbTypeAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbTypeAccount.Text == "Giáo viên")
			{				
				setupCbViewAccTea();
				cbTypeAccount.Text = "Giáo viên";
				label1.Text = "Mã giáo viên";
			}
			else
			{
				setupCbViewAccStu();
				cbTypeAccount.Text = "Sinh viên";
				label1.Text = "Mã sinh viên";
			}
		}

		private void btnAddAcc_Click(object sender, EventArgs e)
		{
			tbNameAcc.Text = "";
			tbPasswordAcc.Text = "";
			cbTypeAccount.Enabled = true;
			cbViewAcc.Enabled = true;
			tbNameAcc.Enabled = true;
			tbPasswordAcc.Enabled = true;
		}

		private void btnModifyAcc_Click(object sender, EventArgs e)
		{
			tbNameAcc.Text = "";
			tbPasswordAcc.Text = "";
			tbNameAcc.Enabled = true;
			tbPasswordAcc.Enabled = true;

			int index = datagvListAccount.CurrentCell.RowIndex;
			loginDTO log = new loginDTO(DAO.UserDAO.Instance.GetAccountDataWhile().Rows[index]);
			cbTypeAccount.Text = log.Powerfull;
			cbViewAcc.Text = log.Id;
			tbNameAcc.Text = log.Username;
			tbPasswordAcc.Text = log.Password;
		}

		private void btnDeleteAcc_Click(object sender, EventArgs e)
		{
			int index = datagvListAccount.CurrentCell.RowIndex;
			loginDTO log = new loginDTO(DAO.UserDAO.Instance.GetAccountDataWhile().Rows[index]);
			if (DAO.UserDAO.Instance.DropAcc(log.Id))
			{
				MessageBox.Show("Xóa tài khoản có mã " + log.Id + "  thành công !");
			}
			else
			{
				MessageBox.Show("Xóa tài khoản thất bại !");
			}
			setupPageAcc();
		}

		private void btnSaveAcc_Click(object sender, EventArgs e)
		{
			loginDTO login = new loginDTO();
			login.Username = tbNameAcc.Text;
			login.Password = tbPasswordAcc.Text;

			if (cbTypeAccount.Text== "Giáo viên")
			{
				DataTable dtTea = DAO.TeachersDAO.Instance.GetTeacher(cbViewAcc.Text);
				teachersDTO tea = new teachersDTO(dtTea.Rows[dtTea.Rows.Count - 1]);

				login.Id = tea.Id;
				login.Name = tea.Name;
				login.Powerfull = cbTypeAccount.Text;
				DataTable dtUser = DAO.UserDAO.Instance.GetAccID(login.Id);

				if (dtUser.Rows.Count == 0)
				{					
					if (DAO.UserDAO.Instance.InsertAcc(login))
					{
						MessageBox.Show("Thêm tài khoản cho giáo viên có mã  " + tea.Id + "  Thành công !");
					}
					else
					{
						MessageBox.Show("Thêm tài khoản giáo viên thất bại !");
					}
					setupCbViewAccTea();
				}
				else
				{
					if (DAO.UserDAO.Instance.UpdateAcc(login))
					{
						MessageBox.Show("Cập nhật tài khoản cho giáo viên có mã  " + tea.Id + "  Thành công !");
					}
					else
					{
						MessageBox.Show("Cập nhật tài khoản giáo viên thất bại !");
					}
				}
				
			}
			else
			{
				DataTable dtStu = DAO.StudentsDAO.Instance.GetStudent(cbViewAcc.Text);
				studentDTO stu = new studentDTO(dtStu.Rows[dtStu.Rows.Count - 1]);

				login.Id = stu.Id;
				login.Name = stu.Name;
				login.Powerfull = cbTypeAccount.Text;

				DataTable dtUser = DAO.UserDAO.Instance.GetAccID(login.Id);
				if (dtUser.Rows.Count == 0)
				{
					if (DAO.UserDAO.Instance.InsertAcc(login))
					{
						MessageBox.Show("Thêm tài khoản cho sinh viên có mã  " + stu.Id + "  Thành công !");
					}
					else
					{
						MessageBox.Show("Thêm tài khoản giáo viên thất bại !");
					}
					setupCbViewAccStu();
				}
				else
				{
					if (DAO.UserDAO.Instance.UpdateAcc(login))
					{
						MessageBox.Show("Cập nhật tài khoản cho giáo viên có mã  " + stu.Id + "  Thành công !");
					}
					else
					{
						MessageBox.Show("Cập nhật tài khoản giáo viên thất bại !");
					}
				}

			}
			setupPageAcc();
		}
	}
}
