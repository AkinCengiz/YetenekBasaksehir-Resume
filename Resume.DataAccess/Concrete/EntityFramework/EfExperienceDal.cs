using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.DataAccess.Concrete.EntityFramework;

public class EfExperienceDal : EfGenericRepositoryDal<Experience>, IExperienceDal
{
	public EfExperienceDal(ResumeDbContext context) : base(context)
	{
	}
}
