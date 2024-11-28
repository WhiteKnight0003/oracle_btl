using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	internal class ClassDTO
	{
		private string id;
		private string name;

		public ClassDTO() { }
		public ClassDTO(string id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }

		public ClassDTO(DataRow row)
		{
			this.Id = row["Id"].ToString();
			this.Name = row["Name"].ToString();
		}
	}
}
