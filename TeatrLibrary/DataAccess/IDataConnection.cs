using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;
using static TeatrLibrary.Enums;

namespace TeatrLibrary.DataAccess
{
   public interface IDataConnection
    {
        //staff
        PersonModel AddMember(PersonModel person);
        void UpdateMember(PersonModel person);
        List<PersonModel> GetAllMembers(string sort = null);
        List<PersonModel> GetMembersByCategory(string category);
        List<PersonModel> GetAvailableActors (Nullable<int> productionId = null);
        PersonModel GetMember(int id);
        //production
        ProductionModel AddProduction(ProductionModel production);
        void UpdateProduction(ProductionModel model);
        List<ProductionModel> GetAllProductions();
        //other
        List<Position> GetPositions();
        List<SceneModel> GetScenes();
        SceneModel GetScene(int scene_id);
    }
}
