using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DTO;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types; // Thư viện Oracle Managed Data Access
namespace Oracle.DAO
{
	internal class ProjectDAO
	{
		private static ProjectDAO instance;

		internal static ProjectDAO Instance
		{
			get { if (instance == null) instance = new ProjectDAO(); return ProjectDAO.instance; }

			private set => ProjectDAO.instance = value;
		}

		public ProjectDAO() { }

		private string connectionStr = "Data Source=(DESCRIPTION= " +
			"(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
			"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
			"User Id=nhom01_oracle;Password=abc123;";

		public DataTable GetProjectsData()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Tạo command với câu truy vấn SQL
					using (OracleCommand cmd = new OracleCommand("SELECT * FROM Nhom01_Oracle.projects ORDER BY ID ASC", connection))
					{
						cmd.CommandType = CommandType.Text; // Đổi thành CommandType.Text vì đang dùng câu SQL trực tiếp

						// Tạo DataTable để lưu kết quả
						DataTable dt = new DataTable();

						// Sử dụng OracleDataAdapter để đổ dữ liệu vào DataTable
						using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
						{
							adapter.Fill(dt);
						}

						return dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối: " + ex.Message);
				return null;
			}
		}

		public bool InsertProject(projectDTO project)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("NHOM01_ORACLE.SP_InsertProject", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = project.Id;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = project.Name;
						cmd.Parameters.Add("p_Id_topic", OracleDbType.Varchar2).Value = project.Id_topic;
						cmd.Parameters.Add("p_Id_student", OracleDbType.Varchar2).Value = project.Id_student;
						cmd.Parameters.Add("p_Id_teacher", OracleDbType.Varchar2).Value = project.Id_teacher;
						cmd.Parameters.Add("p_createAt", OracleDbType.Date).Value = project.Create_at;
						cmd.Parameters.Add("p_endtime", OracleDbType.Date).Value = project.Endtime;
						// Execute the command
						cmd.ExecuteNonQuery();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thêm đồ án : " + ex.Message);
				return false;
			}
		}

		public bool UpdateProject(projectDTO project)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_UpdateProject", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = project.Id;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = project.Name;
						cmd.Parameters.Add("p_Id_topic", OracleDbType.Varchar2).Value = project.Id_topic;
						cmd.Parameters.Add("p_Id_student", OracleDbType.Varchar2).Value = project.Id_student;
						cmd.Parameters.Add("p_Id_teacher", OracleDbType.Varchar2).Value = project.Id_teacher;
						cmd.Parameters.Add("p_createAt", OracleDbType.Date).Value = project.Create_at;
						cmd.Parameters.Add("p_endtime", OracleDbType.Date).Value = project.Endtime;

						// Execute the command
						cmd.ExecuteNonQuery();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi cập nhật  đồ án : " + ex.Message);
				return false;
			}
		}

		public bool DeleteProject(string id_project)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("DELETE FROM  nhom01_oracle.projects where ID = :id ", connection))
					{
						cmd.CommandType = CommandType.Text;

						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("id", id_project));
						// Execute the command
						cmd.ExecuteNonQuery();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xóa đồ án  : " + ex.Message);
				return false;
			}
		}

		public DataTable GetProjectName(string Name)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.projects WHERE name = :Name";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("Name", Name));

						DataTable dt = new DataTable();
						using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
						{
							adapter.Fill(dt);
						}
						return dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối: " + ex.Message);
				return null;
			}
		}

		public DataTable GetProjectID(string Id)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.projects WHERE id = :Id";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("Id", Id));

						DataTable dt = new DataTable();
						using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
						{
							adapter.Fill(dt);
						}
						return dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối: " + ex.Message);
				return null;
			}
		}

		public DataTable GetProjectByIdStudent(string Id_student)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.projects WHERE ID_STUDENT = :id";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("id", Id_student));

						DataTable dt = new DataTable();
						using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
						{
							adapter.Fill(dt);
						}
						return dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối: " + ex.Message);
				return null;
			}
		}
	}
}
