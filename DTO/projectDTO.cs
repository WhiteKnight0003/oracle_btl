using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle.DTO
{
	public class projectDTO
	{
		private string id;
		private string name;
		private string id_topic;
		private string id_student;
		private string id_teacher;
		private DateTime create_at;
		private DateTime endtime;

		public projectDTO() { }
		public projectDTO(string id, string name, string id_topic, string id_student, string id_teacher, DateTime create_at, DateTime endtime)
		{
			this.Id = id;
			this.Name = name;
			this.Id_topic = id_topic;
			this.Id_student = id_student;
			this.Id_teacher = id_teacher;
			this.Create_at = create_at;
			this.Endtime = endtime;
		}

		public string Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Id_topic { get => id_topic; set => id_topic = value; }
		public string Id_student { get => id_student; set => id_student = value; }
		public string Id_teacher { get => id_teacher; set => id_teacher = value; }
		public DateTime Create_at { get => create_at; set => create_at = value; }
		public DateTime Endtime { get => endtime; set => endtime = value; }

		public projectDTO(DataRow row)
		{
			this.id = row["id"].ToString();
			this.name = row["name"].ToString();
			this.id_topic = row["id_topic"].ToString();
			this.id_student = row["id_student"].ToString();
			this.id_teacher = row["id_teacher"].ToString();
			this.create_at = DateTime.Parse( row["create_at"].ToString());
			this.endtime =  DateTime.Parse(row["endtime"].ToString());
		}
	}
}
