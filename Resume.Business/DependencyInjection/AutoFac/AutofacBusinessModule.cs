using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Resume.Business.Abstract;
using Resume.Business.Concrete;
using Resume.DataAccess.Abstract;
using Resume.DataAccess.Concrete.AdoNet;
using Resume.DataAccess.Concrete.EntityFramework;
using Resume.Entity.Concrete;

namespace Resume.Business.DependencyInjection.AutoFac;
public class AutofacBusinessModule : Module
{
	protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ResumeDbContext>().AsSelf().SingleInstance();
		builder.RegisterType<AddressManager>().As<IAddressService>();
		builder.RegisterType<EfAddressDal>().As<IAddressDal>();
		builder.RegisterType<CityManager>().As<ICityService>();
		builder.RegisterType<EfCityDal>().As<ICityDal>();
        builder.RegisterType<TownManager>().As<ITownService>();
        builder.RegisterType<EfTownDal>().As<ITownDal>();
        builder.RegisterType<AddressManager>().As<IAddressService>();
        builder.RegisterType<EfAddressDal>().As<IAddressDal>();
    }
}
