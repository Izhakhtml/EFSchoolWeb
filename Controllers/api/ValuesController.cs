using EFSchoolWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EFSchoolWeb.Controllers.api
{
    public class ValuesController : ApiController
    {
        static string connectionString = "Data Source=LAPTOP-K0H6TSU4;Initial Catalog=SchoolDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        static DataClassesDataContext context = new DataClassesDataContext(connectionString);
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            try
            {
            List<School1> schoolsList = new List<School1>();
            foreach(var item in context.Schools)
            {
                School1 school1 = new School1();
                school1.Id = item.Id;
                school1.NameOfSchool = item.NameOfSchool;
                school1.Street = item.Street;
                school1.IfState = item.IfState;
                school1.NumberOfStudents = item.NumberOfStudents;
                schoolsList.Add(school1);
            }
                return Ok(schoolsList);
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
         
;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(context.Schools.First(item=>item.Id==id));
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
            
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] School value)
        {

            try
            {
                context.Schools.InsertOnSubmit(value);
                context.SubmitChanges();
                return Ok("Add user successfully");
            }
            catch(SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody] School value)
        {
            try
            {
                School school = context.Schools.First(item=>item.Id==id);
                school.NameOfSchool = value.NameOfSchool;
                school.Street = value.Street;
                school.IfState = value.IfState;
                school.NumberOfStudents = value.NumberOfStudents;
                context.SubmitChanges();
                return Ok("The changes were made successfully");
            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                School school = context.Schools.First(item => item.Id == id);
                context.Schools.DeleteOnSubmit(school);
                context.SubmitChanges();
                return Ok("User removed successfully");

            }
            catch (SqlException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}