using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class SocialAccount : BaseEntity
{
	public string WebUrl { get; set; }
	public string UserName { get; set; }
	public string Icon { get; set; }
}
