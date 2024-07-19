using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.DataAccess.Concrete.AdoNet;
public class AdoCityDal :ICityDal
{
	public void Add(City entity)
	{
		throw new NotImplementedException();
	}

	public void Update(City entity)
	{
		throw new NotImplementedException();
	}

	public void Delete(City entity)
	{
		throw new NotImplementedException();
	}

	public List<City> GetAll(Expression<Func<City, bool>> filter = null)
	{
		throw new NotImplementedException();
	}

	public City Get(Expression<Func<City, bool>> filter)
	{
		throw new NotImplementedException();
	}

	public IQueryable<City> GetAllQueryable(Expression<Func<City, bool>> filter = null)
	{
		throw new NotImplementedException();
	}
}
