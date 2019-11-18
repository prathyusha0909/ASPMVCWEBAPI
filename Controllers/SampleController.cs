using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//namespace MVCWithWebApi.Controllers
//{
//   // [RoutePrefix("api/sample")]
//    public class SampleController : ApiController
//    {
//        //Get:api/samplecontroller
//      //  [Route("")]
//        public string Get()
//        {
//            return DateTime.Now.ToString();
//        }

//        //Get:api/samplecontroller/1
//       // [Route("{id}")]
//        public string Get(int id)
//        {
//            return DateTime.Now.AddDays(id).ToString();
//        }
//        //Get:api/samplecontroller/Canarys
//       // [Route("{id}/{name}")]
//        public string Get(int id, string name)  //same number of arguments are passed so it will not work
//        {
//            return "Hi" + name;
//        }
//        //[HttpPost]
//       // [Route("")] //URL: api/sample
//        public string Post(int id=0, string name="")
//        {
//            var obj = new { Id = id, Name = name };
//            JsonSerializer serializer = new JsonSerializer();
//            StringWriter writer = new StringWriter();
//            serializer.Serialize(writer, obj);
//            writer.Flush();
//            var outputString = writer.ToString();
//            return outputString;
//        }
//    }
//}
