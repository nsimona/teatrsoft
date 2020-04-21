using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;

namespace TeatrLibrary.DataAccess
{
   public interface IDataConnection
    {
        //staff
        PersonModel AddMember(PersonModel person);
        void UpdateMember(PersonModel person);
        List<PersonModel> GetAllMembers(string sort = null);
        List<PersonModel> GetMembersByCategory(string category);
        PersonModel GetMember(int id);
        //production
        ProductionModel AddProduction(ProductionModel production);
        ProductionModel InsertProduction(IDbConnection connection, ProductionModel model);
        List<PersonModel> AddActorsToProduction(IDbConnection connection, ProductionModel model);
        List<ProductionEventModel> AddDatesToProduction(IDbConnection connection, ProductionModel model);
        List<ProductionModel> GetAllProductions();
        //other
        List<Position> GetPositions();
        List<SceneModel> GetScenes();
    }
}
