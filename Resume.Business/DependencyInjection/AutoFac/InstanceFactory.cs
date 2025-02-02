﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Resume.Business.DependencyInjection.AutoFac;
public class InstanceFactory
{
    public static T GetInstance<T>()
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule(new AutofacBusinessModule());
        IContainer container = builder.Build();
        using (var scope = container.BeginLifetimeScope())
        {
            return scope.Resolve<T>();
        }
    }
}
