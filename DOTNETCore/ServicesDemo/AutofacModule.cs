using Autofac;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesDemo.Models;
using ServicesDemo.Services;

namespace ServicesDemo.Services
{
    public class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)  
        {
            builder.RegisterType<SqlDataManager>().As<IDataManager>().SingleInstance();
        }
    } 
}