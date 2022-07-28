using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
	public class User
	{

		public string Id { get; set; }
		public string Name { get; set; }
		public string LasteName { get; set; }
		public string Roles { get; set; }
		public string Password { get; set; }
		 
		public User()
		{

		}
		public User( string name,string lastname,string roles,string password, string id)
		{
			this.Id = id;
			this.Name = name;
			this.LasteName = lastname;
			this.Roles = roles;
			this.Password = password;
		}

	}
}
