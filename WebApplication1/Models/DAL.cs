using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WebApplication1.Models;


namespace WebApplication1.Models
{
    public class DAL
    {
        //SqlConnection conn = null;
        //List<Artist> artists = new List<Artist>();
        ////private static object genereame;

        //public DAL()
        //{

            //try
            //{
            //    conn = new SqlConnection();
            //    conn.ConnectionString = "server=.;database=MusicStoreDb;integrated security=true";
            //    conn.Open();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }



        //public List<Genere> GetAllGenere()
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "select * from Genere";
        //        SqlDataReader rdr = comm.ExecuteReader();
        //        List<Genere> g = new List<Models.Genere>();
        //        while (rdr.Read())
        //        {
        //            Genere gn = new Genere
        //            {
        //                genereid = int.Parse(rdr["genereid"].ToString()),
        //                generename = rdr["generename"].ToString()
        //            };
        //            g.Add(gn);

        //        }

        //        rdr.Close();
        //        return g;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        

        //public List<Album> GetAlbums(int genereid)
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "select * from Album";
        //        SqlDataReader rdr = comm.ExecuteReader();
        //        List<Album> albums = new List<Models.Album>();

        //        while (rdr.Read())
        //        {
        //            Album a = new Album
        //            {
        //                albumid = int.Parse(rdr["albumid"].ToString()),
        //                albumname = rdr["albumname"].ToString(),
        //                generedetails = null,
        //                artistdetails = null
        //            };

        //            albums.Add(a);

        //        }
        //        rdr.Close();
        //        return albums;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}



        //public void InsertGenere(Genere g)
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;

        //        comm.CommandType = System.Data.CommandType.StoredProcedure;
        //        comm.CommandText = "InsertGenere";

        //        SqlParameter p1 = new SqlParameter();
        //        p1.ParameterName = "@genereid";
        //        p1.Value = g.genereid;

        //        SqlParameter p2 = new SqlParameter();
        //        p2.ParameterName = "@generename";
        //        p2.Value = g.generename;


        //        comm.Parameters.Add(p1);
        //        comm.Parameters.Add(p2);

        //        comm.ExecuteNonQuery();

        //        Console.WriteLine("Records Are inserted");



        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}


        //public void UpdateGenere(int genereid, string generename)
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;

        //        comm.CommandType = System.Data.CommandType.StoredProcedure;

        //        comm.CommandText = "UpdateGenere";

        //        SqlParameter p1 = new SqlParameter();
        //        p1.ParameterName = "@genereid";
        //        p1.Value = genereid;

        //        SqlParameter p2 = new SqlParameter();
        //        p2.ParameterName = "@newgenerename";
        //        p2.Value = generename;


        //        comm.Parameters.Add(p1);
        //        comm.Parameters.Add(p2);

        //        comm.ExecuteNonQuery();

        //        Console.WriteLine("Records Are updated");

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}


        //public void DalGenere(int genereid)
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;

        //        comm.CommandType = System.Data.CommandType.StoredProcedure;

        //        comm.CommandText = "DeleteGenere";

        //        SqlParameter p1 = new SqlParameter();
        //        p1.ParameterName = "@genereid";
        //        p1.Value = genereid;
        //        comm.Parameters.Add(p1);
        //        comm.ExecuteNonQuery();
        //        Console.WriteLine("Records Are deleted");

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}



        //public Artist GetArtist(int albumid)
        //{
        //    Artist a = null;
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "select artistname from Artist where artistid =(select artistid from Album where albumid = " + albumid + ")";
        //        SqlDataReader rdr = comm.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            a = new Artist
        //            {
        //                artistname = rdr["artistname"].ToString()

        //            };


        //        }
        //        rdr.Close();



        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //    return a;

        //}

        //public Genere GetGenere(int genereid)
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "select * from genere where genereid=" + genereid;
        //        SqlDataReader dr = comm.ExecuteReader();
        //        Genere g = new Genere();
        //        while (dr.Read())
        //        {
        //            g.genereid = int.Parse(dr["genereid"].ToString());
        //            g.generename = dr["generename"].ToString();
        //        }
        //        dr.Close();
        //        return g;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


        //public List<Users> GetAllUser()
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "select * from users";
        //        SqlDataReader rdr = comm.ExecuteReader();
        //        List<Users> u = new List<Models.Users>();

        //        while (rdr.Read())
        //        {
        //            Users usr = new Users
        //            {
                       
        //                username = rdr["username"].ToString(),
        //                password = rdr["password"].ToString(),

        //            };

        //            u.Add(usr);

        //        }
        //        rdr.Close();
        //        return u;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}




        //public void AddUser(Users u)
        //{
        //    try
        //    {
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;

        //        comm.CommandType = System.Data.CommandType.StoredProcedure;
        //        comm.CommandText = "InsertUser";

        //        SqlParameter p1 = new SqlParameter();
        //        p1.ParameterName = "@username";
        //        p1.Value = u.username;

        //        SqlParameter p2 = new SqlParameter();
        //        p2.ParameterName = "@password";
        //        p2.Value = u.password;


        //        comm.Parameters.Add(p1);
        //        comm.Parameters.Add(p2);

        //        comm.ExecuteNonQuery();

        //        Console.WriteLine("Records Are inserted");
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}







    }
