using Oracle.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types; // Thư viện Oracle Managed Data Access

namespace Oracle.DAO
{
	internal class TeachersDAO
	{
		private static TeachersDAO instance;

		internal static TeachersDAO Instance
		{
			get { if (instance == null) instance = new TeachersDAO(); return TeachersDAO.instance; }

			private set => TeachersDAO.instance = value;
		}

		public TeachersDAO() { }

		private string connectionStr = "Data Source=(DESCRIPTION= " +
			"(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
			"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
			"User Id=system;Password=abc123;";

		public DataTable GetTeachersData()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Tạo command với câu truy vấn SQL
					using (OracleCommand cmd = new OracleCommand("SELECT * FROM Nhom01_Oracle.teachers where isactive =1 ORDER BY ID ASC", connection))
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

		public bool InsertTeacher(teachersDTO teachers)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_InsertTeacher", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = teachers.Id;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = teachers.Name;
						cmd.Parameters.Add("p_birthday", OracleDbType.Date).Value = teachers.Date;
						cmd.Parameters.Add("p_Address", OracleDbType.Varchar2).Value = teachers.Address;
						cmd.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = teachers.Phone;
						cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = teachers.Email;
						cmd.Parameters.Add("p_sex", OracleDbType.Varchar2).Value = teachers.Sex;
						cmd.Parameters.Add("p_isactive", OracleDbType.Int64).Value = 1;

						// Execute the command
						cmd.ExecuteNonQuery();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thêm giáo viên: " + ex.Message);
				return false;
			}
		}

		public bool UpdateTeacher(teachersDTO teachers)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_UpdateTeacher", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = teachers.Id;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = teachers.Name;
						cmd.Parameters.Add("p_birthday", OracleDbType.Date).Value = teachers.Date;
						cmd.Parameters.Add("p_Address", OracleDbType.Varchar2).Value = teachers.Address;
						cmd.Parameters.Add("p_phone", OracleDbType.Varchar2).Value = teachers.Phone;
						cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = teachers.Email;
						cmd.Parameters.Add("p_sex", OracleDbType.Varchar2).Value = teachers.Sex;
						cmd.Parameters.Add("p_isactive", OracleDbType.Int64).Value = teachers.IsActive;


						// Execute the command
						cmd.ExecuteNonQuery();
						return true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi cập nhật giáo viên: " + ex.Message);
				return false;
			}
		}

		public DataTable CheckTeacherEmail(string email)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.teachers WHERE email = :email";
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

		public DataTable GetTeacher(string Id)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.teachers WHERE id = :id";
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

		public DataTable GetTeacherNotLogin()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM nhom01_oracle.teachers WHERE ID NOT IN (SELECT ID FROM nhom01_oracle.login) and isactive =1 ORDER BY ID ASC";
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
	}
	
}
