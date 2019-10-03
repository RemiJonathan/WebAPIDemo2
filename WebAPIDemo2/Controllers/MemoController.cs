using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo2.Models;

namespace WebAPIDemo2.Controllers
{
    public class MemoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Memo> Get()
        {
            //return new string[] { "value1", "value2" };

            return new Memo[] { new Memo() { Id = "1", Priority = 4, Text = "Text1" }, new Memo() { Id = "2", Priority = 2, Text = "Text2" } };
        }

        // GET api/<controller>/5
        public Memo Get(int id)
        {
            return new Memo() {Id = "1", Priority = 4, Text = "Text1" };
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}