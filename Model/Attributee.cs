using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Model
{

	public	class Attributee
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }

		public Attributee()
		{

		}
		public Attributee(long id, string name, string type)
		{
			this.Id = id;
			this.Name = name;
			this.Type = type;
 
		}
	}
}
