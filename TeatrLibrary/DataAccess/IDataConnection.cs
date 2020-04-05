using System;
using System.Collections.Generic;
using System.Text;
using TeatrLibrary.Models;

namespace TeatrLibrary.DataAccess
{
   public interface IDataConnection
    {
        PersonModel AddPerson(PersonModel person, string photoPath);
        List<Position> GetPositions();
    }
}
