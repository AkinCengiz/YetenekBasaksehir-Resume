using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Resume.DataAccess.Abstract;
using Resume.Entity.Abstract;

namespace Resume.DataAccess.Concrete.EntityFramework;
public class EfGenericRepositoryDal<T> : IRepositoryDal<T> where T : BaseEntity, new()
{
	private readonly ResumeDbContext _context;
	private readonly DbSet<T> _dbSet;

	public EfGenericRepositoryDal(ResumeDbContext context)
	{
		_context = context;
		_dbSet = _context.Set<T>();
	}

	public void Add(T entity)
	{
		entity.CreateAt = DateTime.Now;
		entity.IsDeleted = false;
		entity.IsActive = true;
		_dbSet.Add(entity);
		_context.SaveChanges();
	}

	public void Update(T entity)
	{
		entity.UpdateAt = DateTime.Now;
		_dbSet.Update(entity);
		_context.SaveChanges();
	}

	public void Delete(T entity)
	{
		entity.IsDeleted = true;
		entity.IsActive = false;
		_dbSet.Update(entity);
		_context.SaveChanges();
	}

	public List<T> GetAll(Expression<Func<T, bool>> filter = null)
	{
		return filter == null ? _dbSet.ToList() : _dbSet.Where(filter).ToList();
	}

	public T Get(Expression<Func<T, bool>> filter)
	{
		return _dbSet.FirstOrDefault(filter);
	}

	public IQueryable<T> GetAllQueryable(Expression<Func<T, bool>> filter = null)
	{
		return filter == null ? _dbSet : _dbSet.Where(filter);
	}
}
