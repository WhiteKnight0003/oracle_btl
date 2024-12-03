using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DTO;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Oracle.DAO
{
	internal class TopicDAO
	{
		private static TopicDAO instance;

		internal static TopicDAO Instance
		{
			get { if (instance == null) instance = new TopicDAO(); return TopicDAO.instance; }

			private set => TopicDAO.instance = value;
		}

		public TopicDAO() { }

		private string connectionStr = "Data Source=(DESCRIPTION= " +
			"(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
			"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
			"User Id=nhom01_oracle;Password=abc123;";

		public DataTable GetTopicData()
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Tạo command với câu truy vấn SQL
					using (OracleCommand cmd = new OracleCommand("SELECT * FROM Nhom01_Oracle.topic", connection))
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

		public DataTable GetTopicName(string Name)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.topic WHERE name = :Name";
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

		public DataTable GetTopicID(string Id)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.topic WHERE id = :Id";
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
