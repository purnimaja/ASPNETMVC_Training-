using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using MusicStoreApi.Models;

namespace MusicStoreApi.Controllers
{

    [RoutePrefix("Search")]

        public class DALController : ApiController
        {
            SqlConnection conn = new SqlConnection();

            public DALController()
            {
                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = "server=.;database=MusicStoreDb;integrated security=true";
                    conn.Open();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }

            [Route("GetAllSearch/{artistname}")]
            public HttpResponseMessage GetAllSearchAccordingToName(string artistname)
            {
               try
                {
                    List<Artist> Search = new List<Artist>();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spsearch";
                    SqlParameter p1 = new SqlParameter();

                    p1.ParameterName = "@artistname";
                    p1.Value = artistname;
                    cmd.Parameters.Add(p1);

                    SqlDataReader readdata = cmd.ExecuteReader();

                if (!readdata.Read())
                {
                    readdata.Close();
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Artist name not found.....");
                }
                //while (readdata.Read())
                else
                    {
                        Artist s = new Artist
                        {
                            artistname = readdata["artistname"].ToString(),
                            albumname = readdata["albumname"].ToString()
                        };
                        Search.Add(s);
                    }
                    readdata.Close();
                    //conn.Close();
                   return Request.CreateResponse(HttpStatusCode.OK, Search);
                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
                }

             }

        }
    }

