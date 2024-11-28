using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DAO
{
	internal class DataProvider
	{
		private static DataProvider instance;

		internal static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }

			private set => DataProvider.instance = value;
		}

		public DataProvider() { }
		private String connectionStr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=system;Password=abc123;";
		public DataTable ExecuteQuery(string query, object[] parameter = null)
		{
			// đổ data ra table
			DataTable data = new DataTable();

			// gọi hàm và nó tự giải phóng bộ nhớ 
			using (OracleConnection connection = new OracleConnection(connectionStr))
			{
				connection.Open(); // mở kết nối ra

				// truy vấn
				OracleCommand command = new OracleCommand(query, connection);

				// câu lệnh sql có nhiều trường
				if (parameter != null)
				{
					string[] listPara = query.Split(' '); // cắt hết các đối tượng ra theo khoảng trắng
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains(':')) // kiểm tra xem có chứa dấu @ không => nếu có thì có chứa parameter
						{
							command.Parameters.Add(item, parameter[i]);
							i++;
						}
					}
				}

				//trung gian để lấy data
				OracleDataAdapter adapter = new OracleDataAdapter(command);

				// đổ dữ liệu lấy ra vào table
				adapter.Fill(data);

				// đóng kết nối
				connection.Close();
			}

			return data;
		}

		public int ExecuteNonQuery(string query, object[] parameter = null) // kết quả khi bn insert, delete, update thì nó sẽ trả ra số dòng thành công
		{

			int data = 0;

			using (OracleConnection connection = new OracleConnection(connectionStr))
			{
				connection.Open();

				OracleCommand command = new OracleCommand(query, connection);

				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains(':')) // tìm từ cáo dấu @
						{
							command.Parameters.Add(item, parameter[i]); // tìm thành công , gán 1 parameter được truyền vào cho nó
							i++;
						}
					}
				}

				data = command.ExecuteNonQuery(); // trả về số dòng thành công

				connection.Close();
			}
			return data;
		}

		public object ExecuteScalar(string query, object[] parameter = null) //  trả về một giá trị đơn - chẳng hạn như số lượng bản ghi, giá trị tối đa, tổng số, - Sử dụng khi truy vấn SQL chỉ trả về một giá trị duy nhất SELECT COUNT(*), SELECT MAX(column_name) 
		{
			object data = 0;

			using (OracleConnection connection = new OracleConnection(connectionStr))
			{
				connection.Open();

				OracleCommand command = new OracleCommand(query, connection);
				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains(':')) // If the item contains ':', it's a parameter placeholder
						{
							// Remove the ':' from the parameter name when adding to the command
							string paramName = item.TrimStart(':');
							command.Parameters.Add(new OracleParameter(paramName, parameter[i]));
							i++;
						}
					}
				}


				data = command.ExecuteScalar();

				connection.Close(); // đóng kết nối
			}
			return data;
		}

	}
}
