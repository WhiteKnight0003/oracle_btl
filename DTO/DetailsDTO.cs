using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	public class DetailsDTO
	{
		private string id_project;
		private string id_process;
		private DateTime complete_date;
		private string filename;
		private byte[] content;

		public DetailsDTO() { }

		public DetailsDTO(string id_project, string id_process, DateTime complete_date, string filename, byte[] content)
		{
			this.id_project = id_project;
			this.id_process = id_process;
			this.complete_date = complete_date;
			this.filename = filename;
			this.content = content;
		}

		public string Id_project { get => id_project; set => id_project = value; }
		public string Id_process { get => id_process; set => id_process = value; }
		public DateTime Complete_date { get => complete_date; set => complete_date = value; }
		public string Filename { get => filename; set => filename = value; }
		public byte[] Content { get => content; set => content = value; }

		public DetailsDTO(DataRow row)
		{
			this.Id_project = row["ID_PROJECT"].ToString();
			this.Id_process= row["ID_PROGRESS"].ToString();
			this.Complete_date = DateTime.Parse( row["COMPLETE_DATE"].ToString());
			this.Filename = row["FILE_NAME"].ToString();
			// Chuyển đổi cột CONTENT sang byte[] 
			this.Content = row["CONTENT"] as byte[];
		}
	}
}
