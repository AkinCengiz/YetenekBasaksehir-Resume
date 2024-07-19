using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class AwardAndCertificateManager : IAwardAndCertificateService
{
	private readonly IAwardAndCertificateDal _awardAndCertificateDal;

	public AwardAndCertificateManager(IAwardAndCertificateDal awardAndCertificateDal)
	{
		_awardAndCertificateDal = awardAndCertificateDal;
	}

	public void Add(AwardAndCertificate entity)
	{
		_awardAndCertificateDal.Add(entity);
	}

	public void Update(AwardAndCertificate entity)
	{
		var updatedEntity = _awardAndCertificateDal.Get(a => a.Id == entity.Id);
		if (updatedEntity != null)
		{
			_awardAndCertificateDal.Update(entity);
		}
	}

	public void Delete(AwardAndCertificate entity)
	{
		_awardAndCertificateDal.Delete(entity);
	}

	public List<AwardAndCertificate> GetAll()
	{
		return _awardAndCertificateDal.GetAll(a => a.IsDeleted == false && a.IsActive== true);
	}

	public AwardAndCertificate GetById(string id)
	{
		return _awardAndCertificateDal.Get(a => a.Id.ToString() == id);
	}

	public IQueryable<AwardAndCertificate> GetAllQueryable()
	{
		return _awardAndCertificateDal.GetAllQueryable(a => a.IsDeleted == false && a.IsActive == true);
	}
}
