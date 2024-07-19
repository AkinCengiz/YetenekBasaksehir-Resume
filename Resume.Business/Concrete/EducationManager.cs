using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class EducationManager : IEducationService
{
	private readonly IEducationDal _educationDal;

	public EducationManager(IEducationDal educationDal)
	{
		_educationDal = educationDal;
	}

	public void Add(Education entity)
	{
		_educationDal.Add(entity);
	}

	public void Update(Education entity)
	{
		_educationDal.Update(entity);
	}

	public void Delete(Education entity)
	{
		_educationDal.Delete(entity);
	}

	public List<Education> GetAll()
	{
		return _educationDal.GetAll(x => x.IsDeleted == false);
	}

	public Education GetById(string id)
	{
		return	_educationDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Education> GetAllQueryable()
	{
		return _educationDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
