using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Concrete;

namespace Resume.Business.Abstract;
public interface ITownService : IGenericService<Town>
{
    List<Town> GetAllByCity(string id);
}
