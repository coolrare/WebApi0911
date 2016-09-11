using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi0911.Controllers
{
    public class Person
    {
        public string name { get; set; }
        public string age { get; set; }
    }
    public class TestController : ApiController
    {
        // GET http://localhost:2581/simple3?name=Will&age=18
        [Route("simple1")]
        public IHttpActionResult GetSimple1(string name, string age)
        {
            return Ok(name + "-" + age);
        }

        // POST http://localhost:2581/simple3?name=Will
        // Content-Type: application/json
        // "18"
        [Route("simple2")]
        public IHttpActionResult PostSimple2(string name, [FromBody]string age)
        {
            return Ok(name + "-" + age);
        }

        // POST http://localhost:2581/simple3
        // Content-Type: application/x-www-form-urlencoded
        // age=18&name=Will

        // POST http://localhost:2581/simple3
        // Content-Type: application/json
        // { "age": 18, "name": Will }

        [Route("simple3")]
        public IHttpActionResult PostSimple3(Person person)
        {
            return Ok(person.name + "-" + person.age);
        }

        // POST http://localhost:2581/simple4?age=18&name=Will
        [Route("simple4")]
        public IHttpActionResult PostSimple4([FromUri]Person person)
        {
            return Ok(person.name + "-" + person.age);
        }

        [Route("jsm")]
        public IHttpActionResult GetSupportedMediaTypes()
        {
            return Ok(GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes);
        }
    }
}
