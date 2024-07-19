using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class ContactManager : IContactService
{
	private readonly IContactDal _contactDal;

	public ContactManager(IContactDal contactDal)
	{
		_contactDal = contactDal;
	}

	public void Add(Contact entity)
	{
		_contactDal.Add(entity);
	}

	public void Update(Contact entity)
	{
		_contactDal.Update(entity);
	}

	public void Delete(Contact entity)
	{
		_contactDal.Delete(entity);
	}

	public List<Contact> GetAll()
	{
		return _contactDal.GetAll(x => x.IsDeleted == false);
	}

	public Contact GetById(string id)
	{
		return _contactDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Contact> GetAllQueryable()
	{
		return _contactDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
