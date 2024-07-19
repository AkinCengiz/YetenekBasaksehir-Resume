using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.DataAccess.Concrete.EntityFramework;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class PersonManager : IPersonService
{
	private readonly IPersonDal _personDal;

	public PersonManager(IPersonDal personDal)
	{
		_personDal = personDal;
	}


	public void Add(Person entity)
	{
		_personDal.Add(entity);
	}

	public void Update(Person entity)
	{
		_personDal.Update(entity);
	}

	public void Delete(Person entity)
	{
		_personDal.Delete(entity);
	}

	public List<Person> GetAll()
	{
		return _personDal.GetAll(x => x.IsDeleted == false);
	}

	public Person GetById(string id)
	{
		return _personDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Person> GetAllQueryable()
	{
		return _personDal.GetAllQueryable(x => x.IsDeleted == false);
	}

	public Person GetPersonByIdentityNumber(string identityNumber)
	{
		return _personDal.Get(x => x.IdentityNumber == identityNumber);
	}
}
