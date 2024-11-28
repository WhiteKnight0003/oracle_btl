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
			"User Id=system;Password=abc123;";

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
	}
}
