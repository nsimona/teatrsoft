using System;
using System.Collections.Generic;
using System.Text;
using TeatrLibrary.Models;

namespace TeatrLibrary.DataAccess
{
   public interface IDataConnection
    {
        PersonModel AddMember(PersonModel person);
        void UpdateMember(PersonModel person);
        List<Position> GetPositions();
        List<PersonModel> GetAllMembers(string sort = null);
        PersonModel GetMember(int id);
        List<PersonModel> GetMembersByCategory(string category);
        List<SceneModel> GetScenes();
    }
}
