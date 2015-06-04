using System.Collections.Generic;
using System.Web.Http;
using SparkConfDemo.Models;

namespace SparkConfDemo.Controllers
{
    public class CustomersController : ApiController
    {
        // GET api/values
        public IEnumerable<Customer> Get()
        {
            Customer cust1 = new Customer
            {
                FirstName = "Richard",
                LastName = "Taylor",
                Email = "rtaylor@rightincode.com",
                Phone = "704-777-1927"
            };

            Customer cust2 = new Customer
            {
                FirstName = "David",
                LastName = "Taylor",
                Email = "dtaylor@rightincode.com",
                Phone = "704-777-1928"
            };

            List<Customer> customers = new List<Customer> {cust1, cust2};

            return customers;
        }

        //// GET api/values/5
        //public string GetById(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}
