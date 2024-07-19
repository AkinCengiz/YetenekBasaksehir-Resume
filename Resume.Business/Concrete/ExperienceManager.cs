using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class ExperienceManager : IExperienceService
{
	private readonly IExperienceDal _experienceDal;

	public ExperienceManager(IExperienceDal experienceDal)
	{
		_experienceDal = experienceDal;
	}

	public void Add(Experience entity)
	{
		_experienceDal.Add(entity);
	}

	public void Update(Experience entity)
	{
		_experienceDal.Update(entity);
	}

	public void Delete(Experience entity)
	{
		_experienceDal.Delete(entity);
	}

	public List<Experience> GetAll()
	{
		return _experienceDal.GetAll(x => x.IsDeleted == false);
	}

	public Experience GetById(string id)
	{
		return _experienceDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Experience> GetAllQueryable()
	{
		return _experienceDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
