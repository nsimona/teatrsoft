using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeatrLibrary.Models;
using Dapper;
using System.Linq;

namespace TeatrLibrary.DataAccess
{
    class SQLConnector : IDataConnection
    {
        public PersonModel AddMember(PersonModel person)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
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

        public List<PersonModel> GetMembersByCategory(string category)
        {
            List<PersonModel> actors = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
            {
                var queryActors = connection.Query("select * from StaffMember where active = 1 and position_id = (select id from Position where name = '" + category + "')" ).ToList();
                foreach(var actor in queryActors)
                {
                    actors.Add(new PersonModel(actor.name, position: actor.position_id, id: actor.id, phone: actor.phone, mail: actor.mail, photo: actor.photo));
                }
            }
            return actors;
        }

        public List<PersonModel> GetAllMembers(string sort = null) 
        {
            List<PersonModel> staffMembers = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
            {
                var queryMembers = new List<dynamic>();
                if (sort == null)
                    queryMembers = connection.Query("select * from StaffMember").ToList();
                else
                    queryMembers = connection.Query("select * from StaffMember order by name " + sort).ToList();

                foreach (var member in queryMembers)
                {
                    staffMembers.Add(new PersonModel(member.name, position: member.position_id, id: member.id, phone: member.phone, mail: member.mail, photo: member.photo, active: member.active));
                }

            }
            return staffMembers;
        }

        public PersonModel GetMember(int id)
        {
            PersonModel person = new PersonModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
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

        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
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
            throw new NotImplementedException();
        }

        public void UpdateMember(PersonModel person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("teatrsoft")))
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
    }
}
