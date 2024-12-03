
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
	internal class ClassDAO
	{
		private static ClassDAO instance;

		internal static ClassDAO Instance
		{
			get { if (instance == null) instance = new ClassDAO(); return ClassDAO.instance; }

			private set => ClassDAO.instance = value;
		}

		public ClassDAO() { }

		private string connectionStr = "Data Source=(DESCRIPTION= " +
			"(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
			"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
			"User Id=nhom01_oracle;Password=abc123;";

		public DataTable GetClassessData()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Tạo command với câu truy vấn SQL
					using (OracleCommand cmd = new OracleCommand("SELECT * FROM Nhom01_Oracle.classes", connection))
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

		public DataTable GetClass(string Name)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.classes WHERE name = :Name";
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

		public DataTable GetClassID(string Id)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.classes WHERE id = :Id";
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
	}
}
