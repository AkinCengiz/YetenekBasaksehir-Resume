using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Business.Abstract;
using Resume.DataAccess.Abstract;
using Resume.Entity.Concrete;

namespace Resume.Business.Concrete;
public class SkillManager : ISkillService
{
	private readonly ISkillDal _skillDal;

	public SkillManager(ISkillDal skillDal)
	{
		_skillDal = skillDal;
	}

	public void Add(Skill entity)
	{
		_skillDal.Add(entity);
	}

	public void Update(Skill entity)
	{
		_skillDal.Update(entity);
	}

	public void Delete(Skill entity)
	{
		_skillDal.Delete(entity);
	}

	public List<Skill> GetAll()
	{
		return _skillDal.GetAll(x => x.IsDeleted == false);
	}

	public Skill GetById(string id)
	{
		return _skillDal.Get(x => x.Id.ToString() == id);
	}

	public IQueryable<Skill> GetAllQueryable()
	{
		return _skillDal.GetAllQueryable(x => x.IsDeleted == false);
	}
}
