using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class AwardAndCertificate : BaseEntity
{
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime ReceivedDate { get; set; }
}
