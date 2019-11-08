using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesDemo.Models;

namespace ServicesDemo.Services
{
    public interface IDataManager
    {
        string GetData();
        string GetGreeting(string name);        
    }
}

