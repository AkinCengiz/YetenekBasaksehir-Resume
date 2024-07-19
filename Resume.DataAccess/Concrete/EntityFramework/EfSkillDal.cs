using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.DataAccess.Concrete.EntityFramework;
public class EfSkillDal : EfGenericRepositoryDal<Skill>, ISkillDal
{
	public EfSkillDal(ResumeDbContext context) : base(context)
	{
	}
}
