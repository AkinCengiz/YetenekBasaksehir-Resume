using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.DataAccess.Concrete.EntityFramework;
public class EfWorkflowDal : EfGenericRepositoryDal<Workflow>, IWorkflowDal
{
	public EfWorkflowDal(ResumeDbContext context) : base(context)
	{
	}
}
