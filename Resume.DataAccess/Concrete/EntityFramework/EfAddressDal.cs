using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.DataAccess.Concrete.EntityFramework;
public class EfAddressDal : EfGenericRepositoryDal<Address>, IAddressDal
{
	public EfAddressDal(ResumeDbContext context) : base(context)
	{
	}
}
