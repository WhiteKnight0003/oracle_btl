using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	internal class processDTO
	{
		private string id;
		private string status;

		public processDTO() { }
		public processDTO(string id, string status)
		{
			this.Id = id;
			this.Status = status;
		}

		public string Id { get => id; set => id = value; }
		public string Status { get => status; set => status = value; }

		public processDTO(DataRow row)
		{
			this.Id = row["Id"].ToString();
			this.Status = row["Status"].ToString();
		}
	}
}
