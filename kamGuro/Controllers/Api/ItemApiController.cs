using kamGuro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace kamGuro.Controllers.Api
{
    public class ItemApiController : ApiController
    {
        private KamguroContext db = new KamguroContext();
        public List<Producto> GetItems()
        {
            return db.Productos.ToList();
        }

        public HttpResponseMessage AddItem([FromBody]Producto data)
        {
            data.UserID = 1;

            db.Productos.Add(data);

            db.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
} 