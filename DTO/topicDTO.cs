using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	public class topicDTO
	{
		private string id;
		private string name;

		public topicDTO() { }
		public topicDTO(string id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }

		public topicDTO(DataRow row)
		{
			this.Id = row["Id"].ToString();
			this.Name = row["Name"].ToString();
		}
	}
}
