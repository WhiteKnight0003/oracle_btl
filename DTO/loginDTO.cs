using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	public class loginDTO
	{
		private string id;
		private string username;
		private string password;
		private string name;
		private string powerfull;

		public loginDTO()
		{
		}

		public loginDTO(string id, string username, string password, string name, string powerfull)
		{
			this.Id = id;
			this.Username = username;
			this.Password = password;
			this.Name = name;
			this.Powerfull = powerfull;
		}

		public string Id { get => id; set => id = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Name { get => name; set => name = value; }
		public string Powerfull { get => powerfull; set => powerfull = value; }

		public loginDTO(DataRow row)
		{
			this.Id = row["ID"].ToString();
			this.Username = row["UserName"].ToString();
			this.Password = row["password"].ToString();
			this.Name = row["Name"].ToString();
			this.Powerfull = row["Powerful"].ToString();
		}
	}


}
