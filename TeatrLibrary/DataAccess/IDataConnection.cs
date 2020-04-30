using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;
using static TeatrLibrary.Enums;
using static TeatrLibrary.Structs;

namespace TeatrLibrary.DataAccess
{
   public interface IDataConnection
    {
        //staff
        PersonModel UpsertMember(PersonModel person, CrudAction action);
        List<PersonModel> GetAllMembers();
        List<PersonModel> GetMembersByCategory(string category);
        List<PersonModel> GetAvailableActors (Nullable<int> productionId = null);
        //production
        ProductionModel UpsertProduction(ProductionModel production, CrudAction action);
        List<ProductionModel> GetAllProductions();
        //tickets
        // TODO - return id
        void ReserveTickets(ProductionEventModel model, List<Seat> seats);
        //other
        List<Position> GetPositions();
        List<SceneModel> GetScenes();
        SceneModel GetScene(int scene_id);
    }
}
