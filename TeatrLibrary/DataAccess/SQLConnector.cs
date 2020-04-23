using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;
using Dapper;
using System.Linq;
using static TeatrLibrary.Enums;

namespace TeatrLibrary.DataAccess
{
    class SQLConnector : IDataConnection
    {
        readonly string db = "teatrsoft";
        public PersonModel AddMember(PersonModel person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", "insert");
                parameter.Add("@name", person.Name);
                parameter.Add("@phone", person.Phone);
                parameter.Add("@mail", person.Mail);
                parameter.Add("@position", person.Position);
                parameter.Add("@photo", person.Photo);
                parameter.Add("@createdId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUpsertStaffMember", parameter, commandType: CommandType.StoredProcedure);

                person.Id = parameter.Get<int>("@createdId");

                return person;
            }
        }
        public void UpdateMember(PersonModel person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@statementType", "update");
                parameter.Add("@id", person.Id);
                parameter.Add("@name", person.Name);
                parameter.Add("@phone", person.Phone);
                parameter.Add("@mail", person.Mail);
                parameter.Add("@position", person.Position);
                parameter.Add("@photo", person.Photo);
                parameter.Add("@active", person.Active);

                connection.Execute("dbo.spUpsertStaffMember", parameter, commandType: CommandType.StoredProcedure);
            }
        }
        public List<PersonModel> GetAllMembers(string sort = null)
        {
            List<PersonModel> staffMembers = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryMembers = new List<dynamic>();
                if (sort == null)
                    queryMembers = connection.Query("select * from StaffMember").ToList();
                else
                    queryMembers = connection.Query("select * from StaffMember order by name " + sort).ToList();

                foreach (var member in queryMembers)
                {
                    staffMembers.Add(new PersonModel(
                        member.name,
                        position: member.position_id,
                        id: member.id,
                        phone: member.phone,
                        mail: member.mail,
                        photo: member.photo,
                        active: member.active)
                    );
                }

            }
            return staffMembers;
        }
        public List<PersonModel> GetMembersByCategory(string category)
        {
            List<PersonModel> actors = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryActors = connection.Query("select * from StaffMember where active = 1 and position_id = " +
                    "(select id from Position where name = N'" + category + "')").ToList();
                foreach (var actor in queryActors)
                {
                    actors.Add(new PersonModel(
                        actor.name,
                        position: actor.position_id,
                        id: actor.id,
                        phone: actor.phone,
                        mail: actor.mail,
                        photo: actor.photo)
                    );
                }
            }
            return actors;
        }
        public List<PersonModel> GetAvailableActors(Nullable<int> productionId = null)
        {
            List<PersonModel> actors = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@production_id", productionId);
                var queryActors = connection.Query("dbo.spGetAvailableActorsForProduction", parameter, commandType: CommandType.StoredProcedure).ToList();
                foreach (var actor in queryActors)
                {
                    actors.Add(new PersonModel(
                        actor.name,
                        position: actor.position_id,
                        id: actor.id,
                        phone: actor.phone,
                        mail: actor.mail,
                        photo: actor.photo,
                        active: actor.active)
                    );
                }
            }
            return actors;
        }

        public PersonModel GetMember(int id)
        {
            PersonModel person = new PersonModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryMember = connection.Query("select * from StaffMember where active = 1 and id =" + id).ToList();
                foreach (var member in queryMember)
                {
                    person.Name = member.name;
                    person.Phone = member.phone;
                    person.Mail = member.mail;
                    person.Position = member.position_id;
                    person.Photo = member.photo;
                    person.Id = member.id;
                }
                
            }
            return person;
        }
        public ProductionModel AddProduction(ProductionModel production)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                UpsertProduction(connection, production, CrudAction.create);
                return production;
            }
            
        }
        public ProductionModel UpsertProduction(IDbConnection connection, ProductionModel model, CrudAction action)
        {
            if (action == CrudAction.update)
            {
                connection.Query($"delete from ProductionActor where production_id = {model.Id}");
                connection.Query($"delete from EventDate where production_id = {model.Id}");
            }
            DynamicParameters parameter = new DynamicParameters();
            string statementType = action.ToString();
            parameter.Add("@statementType", statementType);
            parameter.Add("@name", model.Name);
            parameter.Add("@premiere", model.Premiere);
            parameter.Add("@author", model.Author);
            parameter.Add("@director_id", model.Director);
            parameter.Add("@description", model.Description);
            parameter.Add("@duration", model.Duration);
            parameter.Add("@poster", model.PosterFileName);
            parameter.Add("@active", model.Active);
            parameter.Add("@id", model.Id);
            parameter.Add("@createdId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spUpsertProduction", parameter, commandType: CommandType.StoredProcedure);
            if (action == CrudAction.create) model.Id = parameter.Get<int>("@createdId");

            foreach (PersonModel actor in model.Actors)
            {
                DynamicParameters actorsParameters = new DynamicParameters();
                actorsParameters.Add("@production_id", model.Id);
                actorsParameters.Add("@actor_id", actor.Id);
                connection.Execute("dbo.spUpsertProductionActor", actorsParameters, commandType: CommandType.StoredProcedure);
            }

            foreach (ProductionEventModel addedEvent in model.Dates)
            {
                DynamicParameters datesParameter = new DynamicParameters();
                datesParameter.Add("@production_id", model.Id);
                datesParameter.Add("@scene_id", addedEvent.Scene);
                datesParameter.Add("@date", addedEvent.Date);
                datesParameter.Add("@time", addedEvent.Time);
                connection.Execute("dbo.spUpsertEventDate", datesParameter, commandType: CommandType.StoredProcedure);
            }
            return model;
        }  
        public void UpdateProduction(ProductionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                UpsertProduction(connection, model, CrudAction.update);
            }
        }
        public List<ProductionModel> GetAllProductions()
        {
            List<ProductionModel> productions = new List<ProductionModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryProductions = connection.Query("dbo.spGetAllProductions", null, commandType: CommandType.StoredProcedure).ToList();
                foreach (var production in queryProductions)
                {
                    productions.Add(new ProductionModel(
                        production.id,
                        production.name,
                        production.premiere,
                        production.author,
                        production.director_id,
                        production.description,
                        production.poster,
                        GetProductionActors(connection, production.id),
                        GetProductionDates(connection, production.id),
                        (short)production.duration,
                        directorName: production.directorName,
                        active: production.active
                    ));
                }

            }
            return productions;
        }
        private List<ProductionEventModel> GetProductionDates(IDbConnection connection, int production_id)
        {
            List<ProductionEventModel> events = new List<ProductionEventModel>();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@production_id", production_id);

            var queryEvents = connection.Query("dbo.spGetAllDatesForProduction", parameters, commandType: CommandType.StoredProcedure).ToList();
            foreach(var e in queryEvents)
            {
                events.Add(new ProductionEventModel(
                    e.id, 
                    (DateTime)e.date, 
                    (TimeSpan)e.time, 
                    e.scene_id,
                    e.sceneName, 
                    e.sold_tickets
                ));
            }
            return events;
    }
        private List<PersonModel> GetProductionActors(IDbConnection connection, int production_id)
        {
            List<PersonModel> actors = new List<PersonModel>();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@production_id", production_id);

            var queryActors = connection.Query("dbo.spGetAllActorsForProduction", parameters, commandType: CommandType.StoredProcedure).ToList();
            
            foreach (var actor in queryActors)
                actors.Add(new PersonModel(actor.actorName, id: actor.actorId));
            return actors;
        }
        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var queryPositions = connection.Query("select * from Position").ToList();
                foreach (var position in queryPositions)
                {
                    positions.Add(new Position(position.id, position.name));
                }

            }
            return positions;
        }

        public List<SceneModel> GetScenes()
        {
            List<SceneModel> scenes = new List<SceneModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                
                var queryScenes = connection.Query("select * from Scene").ToList();

                foreach (var scene in queryScenes)
                {
                    scenes.Add(
                        new SceneModel(
                            scene.id,
                            scene.name,
                            scene.address,
                            scene.price,
                            scene.seats_count,
                            scene.rows,
                            scene.cols
                       )
                    );
                }
            }
            return scenes;
        }

        public SceneModel GetScene(int scene_id)
        {
            SceneModel scene = new SceneModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var queryScene = connection.Query($"select * from Scene where id={scene_id}").ToList();
                foreach (var s in queryScene)
                {
                    scene.Id = s.id;
                    scene.Name = s.name;
                    scene.Schema = s.model;
                    scene.SeatsCount = s.seats_count;
                    scene.Address = s.address;
                    scene.TicketPrice = s.price;
                    scene.Rows = s.rows;
                    scene.Cols = s.cols;
                    scene.SetModel();
                }

                return scene;
            }
        }
    }
}
