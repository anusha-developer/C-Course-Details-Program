using Coursedetails.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Coursedetails.Controllers
{
    public class CoursedetailsController : ApiController
    {
        [HttpGet]
        [Route("api/Coursedetails1")]
        public List<Coursedet> GetCoursedetails1()
        {
            List<Coursedet> CS = new List<Coursedet>();
           Coursedet course = new Coursedet();
            SqlConnection con = new SqlConnection("data source=.;database=company1,integrated security=SSPI");
            try
            {
            con.Open();
            string query = "select * from Coursedetails1";
            SqlCommand cm = new SqlCommand(query, con);
            SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    course = new  Coursedet();
                    course.Sno = Convert.ToInt32(dr["Sno"]);
                    course.Coursename = dr["Coursename"].ToString();
                    course.Coursefee= Convert.ToInt32(dr["Coursefee"]);
                    course.Courseduration = dr["Courseduration"].ToString();
                    course.Specialization = dr["Specialization"].ToString();
                    CS.Add(course);
                }

            }
            catch(Exception ex)
            {

            }

            return CS;
        }

        // GET: api/Coursedetails
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Coursedetails/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Coursedetails
        [HttpPost]
        [Route("api/insertCoursedetails1")]

        public string insertCoursedetails1([FromBody] Coursedet obj)

        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =.;database=company1,integrated security=SSPI");
                con.Open();
                SqlCommand cm = new SqlCommand
               ("insert into Coursedetails1 values (" + obj.Sno + ",'" + obj.Coursename + "'," + obj.Coursefee + ",'" + obj.Courseduration + "','" + obj.Specialization + "');", con);
                SqlDataReader dr = cm.ExecuteReader();


            }
            catch (Exception ex)
            {

            }
            return "inserted data successfully";


        }

        // PUT: api/Coursedetails/5
        [HttpPut]
        [Route("api/updateCoursedetails1")]

        public string updateCoursedet(int id, [FromBody] Coursedet csdata)
        {
            SqlConnection con = new SqlConnection("data source=.;database=company1,integrated security=SSPI");
            con.Open();
            SqlCommand cm = new SqlCommand("update csdata set Sno='" + csdata.Sno + "',Coursename = '" + csdata .Coursename + "' where id=2", con);
            cm.ExecuteNonQuery();
            con.Close();
            return "updated";
        }


        // DELETE: api/Coursedetails/5
        public void Delete(int id)
        {

        }
            [HttpDelete]
            [Route("api/Coursedetails1")]
            public string Coursedet(int Sno)
            {

                SqlConnection con = null;
                try
                {
                    con = new SqlConnection("data source=.;database=company1,integrated security=SSPI");
                    con.Open();
                    string query = "delete from Coursedetails1 where Sno=" + Sno + " ";
                    SqlCommand cm = new SqlCommand(query, con);
                    SqlDataReader dr = cm.ExecuteReader();

                }
                catch (Exception ex)
                {
                }
                return "deleted";
            }
        }
    }

