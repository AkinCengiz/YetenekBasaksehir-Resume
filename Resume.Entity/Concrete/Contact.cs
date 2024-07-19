using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class Contact : BaseEntity
{
	public string Phone1 { get; set; }
	public string Phone2 { get; set; }
	public string Email1 { get; set; }
	public string Email2 { get; set; }
}
