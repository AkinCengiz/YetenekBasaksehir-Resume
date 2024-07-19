using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class Education : BaseEntity
{
	public string SchoolName { get; set; }
	public string FacultyName { get; set; }
	public string Department { get; set; }
	public decimal GNO { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
}
