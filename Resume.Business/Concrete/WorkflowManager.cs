using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class WorkflowManager : IWorkflowService
{
	private readonly IWorkflowDal _workflowDal;

	public WorkflowManager(IWorkflowDal workflowDal)
	{
		_workflowDal = workflowDal;
	}

	public void Add(Workflow entity)
	{
		_workflowDal.Add(entity);
	}

	public void Update(Workflow entity)
	{
		_workflowDal.Update(entity);
	}

	public void Delete(Workflow entity)
	{
		_workflowDal.Delete(entity);
	}

	public List<Workflow> GetAll()
	{
		return _workflowDal.GetAll(x => x.IsDeleted == false);
	}

	public Workflow GetById(string id)
	{
		return _workflowDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Workflow> GetAllQueryable()
	{
		return _workflowDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
