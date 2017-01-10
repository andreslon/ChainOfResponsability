using RouteAnalysis.Worker.Entities;
using RouteAnalysis.Worker.Repositories.Interfaces;
using RouteAnalysis.Worker.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Repositories
{
    public class ItineraryRepository : IRepository<Itinerary>
    {

        CtConnection ctConnection;

        public ItineraryRepository()
        {

        }

        public IEnumerable<Itinerary> List
        {
            get
            { 
                string queryString = "SELECT * from dbo.Itinerary";
                using (CtConnection connection = new CtConnection())
                { 
                    SqlCommand command = new SqlCommand(queryString, connection.cnn);
                    try
                    {
                        List<Itinerary> itinerary = new List<Itinerary>();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                itinerary.Add(new Itinerary
                                {
                                    Id = reader["Id"].ToString(),
                                    Plaque = reader["Plaque"].ToString(),
                                });
                            }
                            return itinerary;
                            reader.Close();
                        } 
                    }
                    catch (Exception ex)
                    {
                    }
                    finally
                    {
                        connection.Dispose();
                    }
                }
                return null;
            }
        }

        public void Add(Itinerary entity)
        {

        }

        public void Delete(Itinerary entity)
        {

        }

        public void Update(Itinerary entity)
        {


        } 
        public Itinerary FindById(int Id)
        {
            return null;
        }
    }
}
