using Indexe_Exception_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexe_Exception_Practice.Services.İnterfaces
{
    internal interface IPersonService
    {
        Person GetById(int? id);
    }
}
