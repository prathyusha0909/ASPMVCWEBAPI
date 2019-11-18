using MVCWithWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MVCWithWebApi.Controllers
{
    public class CategoryProductController : ApiController
    {
        private NorthwindEntities2 db = new NorthwindEntities2();
        public IQueryable<Category> GetCategories()
        {
            return db.Categories;
        }
        //[ResponseType(typeof(Product))]
        //public IHttpActionResult GetCategories(int id)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Category.Add(Categories);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = Categories.ProductID }, Categories);
        //    //return Ok();
        //}
        [ResponseType(typeof(Category))]
        public IHttpActionResult GetProductsByCategory(int id)
        {



            if (id < 0 || id > 8)
            {
                return BadRequest();
            }
            NorthwindEntities entities = new NorthwindEntities();
            var query = from c in entities.Products
                        where c.CategoryID == id
                        select c;
            return Ok(query);
            //fill in the code to retrive products on category id



        }

        //Model:Category (create new),Product (existing in EF)

    }
}
