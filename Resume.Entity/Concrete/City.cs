using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class City : BaseEntity
{
	public string Name { get; set; }
	public List<Town> Towns { get; set; } = new();
	public List<Address> Addresses { get; set; } = new();
}
