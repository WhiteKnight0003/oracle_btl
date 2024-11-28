using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Oracle.DTO;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types; // Thư viện Oracle Managed Data Access

namespace Oracle.DAO
{
	internal class UserDAO
	{
		private static UserDAO instance;
		private loginDTO logindto;

		internal static UserDAO Instance
		{
			get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }

			private set => UserDAO.instance = value;
		}

		public UserDAO() { }

		private string connectionStr = "Data Source=(DESCRIPTION= " + 
			"(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" + 
			"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));"+
			"User Id=system;Password=abc123;";


		public bool checkLogin(string userName, string passWord)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					// Tạo command để gọi stored procedure
					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_Login", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Thêm các tham số
						cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = userName;
						cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = passWord;

						// Tham số OUT để nhận kết quả
						OracleParameter resultParam = new OracleParameter("p_result", OracleDbType.Int32);
						resultParam.Direction = ParameterDirection.Output;
						cmd.Parameters.Add(resultParam);

						// Thực thi stored procedure
						cmd.ExecuteNonQuery();

						// Lấy kết quả
                OracleDecimal resultDecimal = (OracleDecimal)resultParam.Value;  // Lấy giá trị OracleDecimal

                // Chuyển đổi OracleDecimal thành decimal
                decimal result = resultDecimal.IsNull ? 0 : resultDecimal.Value;

						// Kiểm tra kết quả
						return result == 1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối: " + ex.Message);
				return false;
			}
		}

		public loginDTO info_account_login(string userName, string passWord)
		{
			logindto = new loginDTO();
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					// Tạo command để gọi stored procedure
					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_GetPowerfulAndID", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Thêm các tham số
						cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = userName;
						cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = passWord;

						// Tham số OUT để nhận kết quả
						OracleParameter resultParamID = new OracleParameter("p_id", OracleDbType.Varchar2,100);
						resultParamID.Direction = ParameterDirection.Output;
						cmd.Parameters.Add(resultParamID);

						
						OracleParameter resultParamPowerful = new OracleParameter("p_powerful", OracleDbType.Varchar2,100);
						resultParamPowerful.Direction = ParameterDirection.Output;
						cmd.Parameters.Add(resultParamPowerful);

						OracleParameter resultParamName = new OracleParameter("p_name", OracleDbType.Varchar2, 100);
						resultParamName.Direction = ParameterDirection.Output;
						cmd.Parameters.Add(resultParamName);


						// Thực thi stored procedure
						cmd.ExecuteNonQuery();
						// Lấy kết quả
						logindto.Powerfull = resultParamPowerful.Value.ToString();
						logindto.Id = resultParamID.Value.ToString();
						logindto.Username = userName;
						logindto.Password = passWord;
						logindto.Name = resultParamName.Value.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi kết nối: " + ex.Message);
				Console.WriteLine(ex.ToString()); // or log to a file
			}

			return logindto;
		}

		public DataTable GetAccountData()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Tạo command với câu truy vấn SQL
					using (OracleCommand cmd = new OracleCommand("SELECT * FROM Nhom01_Oracle.login", connection))
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

		public DataTable GetAccountDataWhile()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Tạo command với câu truy vấn SQL
					using (OracleCommand cmd = new OracleCommand("SELECT * FROM Nhom01_Oracle.login where powerful != 'Trưởng khoa'", connection))
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

		public bool InsertAcc(loginDTO login)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_InsertAcc", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = login.Id;
						cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = login.Name;
						cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = login.Password;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = login.Name;
						cmd.Parameters.Add("p_powerful", OracleDbType.Varchar2).Value = login.Powerfull;

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

		public bool UpdateAcc(loginDTO login)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_UpdateAcc", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_id", OracleDbType.Varchar2).Value = login.Id;
						cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = login.Username;
						cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = login.Password;
						cmd.Parameters.Add("p_name", OracleDbType.Varchar2).Value = login.Name;
						cmd.Parameters.Add("p_powerful", OracleDbType.Varchar2).Value = login.Powerfull;
			
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

		public DataTable GetAccID(string Id)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.login WHERE id = :id";
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

		public bool DropAcc(string id)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					string query = "DELETE FROM nhom01_oracle.login WHERE id = :id";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;

						// Add parameters
						cmd.Parameters.Add(new OracleParameter("id", id));

						// Execute the command
						cmd.ExecuteNonQuery();

						// Explicitly commit the transaction
						connection.BeginTransaction().Commit();
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
	}

}
