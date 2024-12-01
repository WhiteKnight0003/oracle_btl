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
	public class DetailDAO
	{
		private static DetailDAO instance;

		internal static DetailDAO Instance
		{
			get { if (instance == null) instance = new DetailDAO(); return DetailDAO.instance; }

			private set => DetailDAO.instance = value;
		}

		public DetailDAO() { }

		private string connectionStr = "Data Source=(DESCRIPTION= " +
			"(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
			"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));" +
			"User Id=system;Password=abc123;";

		public DataTable GetProjectDetailsByIdProject(string Id_project)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();
					// Sử dụng parameter để tránh SQL injection
					string query = "SELECT * FROM Nhom01_Oracle.details WHERE id_project = :Id";
					using (OracleCommand cmd = new OracleCommand(query, connection))
					{
						cmd.CommandType = CommandType.Text;
						// Thêm parameter
						cmd.Parameters.Add(new OracleParameter("Id", Id_project));

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


		public bool InsertDetailsProject(DetailsDTO details)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_InsertProjectDetails", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_idProject", OracleDbType.Varchar2).Value = details.Id_project;
						cmd.Parameters.Add("p_idProcess", OracleDbType.Varchar2).Value = details.Id_process;
						cmd.Parameters.Add("p_completeDate", OracleDbType.Date).Value = details.Complete_date;
						cmd.Parameters.Add("p_fileName", OracleDbType.Varchar2).Value = details.Filename;
						cmd.Parameters.Add("p_Content", OracleDbType.Blob).Value = details.Content;

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

		public bool UpdateDetailsProject(DetailsDTO details)
		{
			try
			{
				using (OracleConnection connection = new OracleConnection(connectionStr))
				{
					connection.Open();

					using (OracleCommand cmd = new OracleCommand("nhom01_oracle.SP_UpDateProjectDetails", connection))
					{
						cmd.CommandType = CommandType.StoredProcedure;

						// Add parameters
						cmd.Parameters.Add("p_idProject", OracleDbType.Varchar2).Value = details.Id_project;
						cmd.Parameters.Add("p_idProcess", OracleDbType.Varchar2).Value = details.Id_process;
						cmd.Parameters.Add("p_completeDate", OracleDbType.Date).Value = details.Complete_date;
						cmd.Parameters.Add("p_fileName", OracleDbType.Varchar2).Value = details.Filename;
						cmd.Parameters.Add("p_Content", OracleDbType.Blob).Value = details.Content;


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
	}
}
