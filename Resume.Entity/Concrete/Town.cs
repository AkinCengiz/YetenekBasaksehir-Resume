using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class Town : BaseEntity
{
	public string Name { get; set; }
	public Guid CityId { get; set; }
	public City City { get; set; }
	public List<Address> Addresses { get; set; }
}
