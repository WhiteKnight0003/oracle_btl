using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	public class teachersDTO
	{
		private string id;
		private string name;
		private DateTime date;
		private string address;
		private string phone;
		private string email;
		private string sex;
		private int isActive;
		public teachersDTO()
		{
		}

		public teachersDTO(DataRow row)
		{
			this.Id = row["ID"].ToString();
			this.Name = row["Name"].ToString();
			this.Date = DateTime.Parse(row["Birthday"].ToString());
			this.Address = row["Address"].ToString();
			this.Phone = row["Phone"].ToString();
			this.Email = row["Email"].ToString();
			this.Sex = row["Sex"].ToString();
			this.IsActive = int.Parse(row["isActive"].ToString());
		}

		public teachersDTO(string id, string name, DateTime date, string address, string phone, string email, string sex, int isActive) { 
			this.id = id;
			this.name = name;
			this.date = date;
			this.address = address;
			this.phone = phone;
			this.email = email;
			this.sex = sex;
			this.isActive = isActive;
		}

		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public DateTime Date { get => date; set => date = value; }
		public string Address { get => address; set => address = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Email { get => email; set => email = value; }
		public string Sex { get => sex; set => sex = value; }
		public int IsActive { get => isActive; set => isActive = value; }
	}
}
