using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{
	public class Labele
	{

		public string Id;

		public string name;
		public string category;
		public string color;

		public Labele(string id, string name, string category, string color)
		{
			this.Id = id;
			this.name = name;
			this.category = category;
			this.color = color;
		}
		public Labele()
		{

		}


	}
}
