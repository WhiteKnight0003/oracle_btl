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
	internal class StudentsDAO
	{
		private static StudentsDAO instance;

		internal static StudentsDAO Instance
		{
			get { if (instance == null) instance = new StudentsDAO(); return StudentsDAO.instance; }

			private set => StudentsDAO.instance = value;
		}

		public StudentsDAO() { }


		private string connectionStr = "Data Source=(DESCRIPTION= " +
										"(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
										"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
										"User Id=nhom01_oracle;Password=abc123;";
		public DataTable GetStudentData()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Tạo command với câu truy vấn SQL
					using (OracleCommand cmd = new OracleCommand("SELECT * FROM Nhom01_Oracle.students where isactive =1 ORDER BY ID ASC", connection))
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


		public bool InsertStudent(studentDTO student)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_InsertStudent", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = student.Id;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = student.Name;
						cmd.Parameters.Add("p_Id_class", OracleDbType.Varchar2).Value = student.Id_class;
						cmd.Parameters.Add("p_birthday", OracleDbType.Date).Value =	student.Birthday;
						cmd.Parameters.Add("p_Address", OracleDbType.Varchar2).Value = student.Address;
						cmd.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = student.Phone;
						cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = student.Email;
						cmd.Parameters.Add("p_sex", OracleDbType.Varchar2).Value = student.Sex;
						cmd.Parameters.Add("p_isactive", OracleDbType.Int64).Value = 1;

						// Execute the command
						cmd.ExecuteNonQuery();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
				return false;
			}
		}

		public bool UpdateStudent(studentDTO student)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_UpdateStudent", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = student.Id;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = student.Name;
						cmd.Parameters.Add("p_Id_class", OracleDbType.Varchar2).Value = student.Id_class;
						cmd.Parameters.Add("p_birthday", OracleDbType.Date).Value = student.Birthday;
						cmd.Parameters.Add("p_Address", OracleDbType.Varchar2).Value = student.Address;
						cmd.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = student.Phone;
						cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = student.Email;
						cmd.Parameters.Add("p_sex", OracleDbType.Varchar2).Value = student.Sex;
						cmd.Parameters.Add("p_isActive", OracleDbType.Int32).Value = student.Isactive;

						cmd.ExecuteNonQuery();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message);
				return false;
			}
		}
		public DataTable CheckStudentEmail(string email)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.students WHERE email = :email";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("email", email));

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

		public DataTable GetStudent(string Id)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.students WHERE id = :id";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("id", Id));

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


		public DataTable GetStudentByClass(string classId)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.students WHERE ID_Class =  :id";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("id", classId));

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

		public DataTable GetStudentNotLogin()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM nhom01_oracle.students WHERE ID NOT IN (SELECT ID FROM nhom01_oracle.login)  and isactive =1 ORDER BY ID ASC";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;

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

		public DataTable GetStudentByTeacherID(string TeaId)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "select s.* from nhom01_oracle.students s join nhom01_oracle.projects p on s.id = p.id_student  where p.id_teacher =  :id";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("id", TeaId));

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
