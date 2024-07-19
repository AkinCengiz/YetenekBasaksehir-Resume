using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.DataAccess.Concrete.AdoNet;
using Resume.DataAccess.Concrete.EntityFramework;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class CityManager : ICityService
{
	private readonly ICityDal _cityDal;

	public CityManager(ICityDal cityDal)
	{
		_cityDal = cityDal;
	}

	public void Add(City entity)
	{
		_cityDal.Add(entity);
	}

	public void Update(City entity)
	{
		_cityDal.Update(entity);
	}

	public void Delete(City entity)
	{
		_cityDal.Delete(entity);
	}

	public List<City> GetAll()
	{
		return _cityDal.GetAll(x => x.IsDeleted == false);
	}

	public List<City> GetByIsDeleted()
	{
		return _cityDal.GetAll(x => x.IsDeleted == true);
	}

	public City GetById(string id)
	{
		return _cityDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<City> GetAllQueryable()
	{
		return _cityDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
