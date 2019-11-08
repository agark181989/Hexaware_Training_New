using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServicesDemo.Models;

namespace ServicesDemo.Services
{
    public class SqlDataManager : IDataManager
    {
        public string GetData()
        {
            return "Hello Rohit";
        }

        public string GetGreeting(string name)
        {
            return "My name is " + name;
        }   
    } 
}