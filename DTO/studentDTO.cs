using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	public class studentDTO
	{
		private string id;
		private string name;
		private string id_class;
		private DateTime birthday;
		private string sex;
		private string address;
		private string phone;
		private string email;
		private int isactive;

		public studentDTO()
		{
		}

		public studentDTO(string id, string name, string id_class, DateTime birthday, string sex, string address, string phone, string email, int isactive)
		{
			this.id = id;
			this.name = name;
			this.id_class = id_class;
			this.birthday = birthday;
			this.sex = sex;
			this.address = address;
			this.phone = phone;
			this.email = email;
			this.Isactive = isactive;
		}

		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Id_class { get => id_class; set => id_class = value; }
		public DateTime Birthday { get => birthday; set => birthday = value; }
		public string Sex { get => sex; set => sex = value; }
		public string Address { get => address; set => address = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Email { get => email; set => email = value; }
		public int Isactive { get => isactive; set => isactive = value; }

		public studentDTO(DataRow row)
		{
			this.Id = row["ID"].ToString();
			this.Name = row["Name"].ToString();
			this.Id_class = row["Id_class"].ToString();
			this.Birthday = DateTime.Parse(row["Birthday"].ToString());
			this.Sex = row["Sex"].ToString();
			this.Address = row["Address"].ToString();
			this.Phone = row["Phone"].ToString();
			this.Email = row["Email"].ToString();
			this.Isactive =int .Parse( row["isactive"].ToString());
		}
	}
}
