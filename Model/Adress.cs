using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
	public class Adress
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string latitude { get; set; }
		public string longtitude { get; set; }

		public Adress()
		{

		}
		public Adress(string id, string name, string latitude, string longtitude)
		{
			this.Id = id;
			this.Name = name;
			this.latitude = latitude;
			this.longtitude = longtitude;
		}
	}
}
 