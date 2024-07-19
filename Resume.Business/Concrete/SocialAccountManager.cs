using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class SocialAccountManager : ISocialAccountService
{
	private readonly ISocialAccountDal _socialAccountDal;

	public SocialAccountManager(ISocialAccountDal socialAccountDal)
	{
		_socialAccountDal = socialAccountDal;
	}

	public void Add(SocialAccount entity)
	{
		_socialAccountDal.Add(entity);
	}

	public void Update(SocialAccount entity)
	{
		_socialAccountDal.Update(entity);
	}

	public void Delete(SocialAccount entity)
	{
		_socialAccountDal.Delete(entity);
	}

	public List<SocialAccount> GetAll()
	{
		return _socialAccountDal.GetAll(x => x.IsDeleted == false);
	}

	public SocialAccount GetById(string id)
	{
		return _socialAccountDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<SocialAccount> GetAllQueryable()
	{
		return _socialAccountDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
