using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class InterestManager : IInterestService
{
	private readonly IInterestDal _interestDal;

	public InterestManager(IInterestDal interestDal)
	{
		_interestDal = interestDal;
	}

	public void Add(Interest entity)
	{
		_interestDal.Add(entity);
	}

	public void Update(Interest entity)
	{
		_interestDal.Update(entity);
	}

	public void Delete(Interest entity)
	{
		_interestDal.Delete(entity);
	}

	public List<Interest> GetAll()
	{
		return _interestDal.GetAll(x => x.IsDeleted == false);
	}

	public Interest GetById(string id)
	{
		return _interestDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Interest> GetAllQueryable()
	{
		return _interestDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
