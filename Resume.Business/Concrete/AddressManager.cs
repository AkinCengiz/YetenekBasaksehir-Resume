using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.DataAccess.Concrete.EntityFramework;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class AddressManager : IAddressService
{
	private readonly IAddressDal _addressDal;

	public AddressManager(IAddressDal addressDal)
	{
		_addressDal = addressDal;
	}

	public void Add(Address entity)
	{
		_addressDal.Add(entity);
	}

	public void Update(Address entity)
	{
		_addressDal.Update(entity);
	}

	public void Delete(Address entity)
	{
		_addressDal.Delete(entity);
	}

	public List<Address> GetAll()
	{
		return _addressDal.GetAll();
	}

	public Address GetById(string id)
	{
		return _addressDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Address> GetAllQueryable()
	{
		return _addressDal.GetAllQueryable(x => x.IsActive == true)
			.Include(x => x.City)
			.Include(x => x.Town).OrderBy(x => x.City.Name).OrderBy(x => x.Town.Name);
	}
}
