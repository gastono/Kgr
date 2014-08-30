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
        public List<Item> GetItems()
        {
            return db.Items.ToList();
        }

    }
} 