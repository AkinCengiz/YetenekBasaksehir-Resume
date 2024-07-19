using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class TownManager : ITownService
{
	private readonly ITownDal _townDal;

	public TownManager(ITownDal townDal)
	{
		_townDal = townDal;
	}

	public void Add(Town entity)
	{
		_townDal.Add(entity);
	}

	public void Update(Town entity)
	{
		_townDal.Update(entity);
	}

	public void Delete(Town entity)
	{
		_townDal.Delete(entity);
	}

	public List<Town> GetAll()
	{
		return _townDal.GetAll(x => x.IsDeleted == false);
	}

    public List<Town> GetAllByCity(string id)
    {
        return _townDal.GetAll(x => x.IsDeleted == false && x.CityId.ToString() == id);
    }

	public Town GetById(string id)
	{
		return _townDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Town> GetAllQueryable()
	{
		return _townDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
