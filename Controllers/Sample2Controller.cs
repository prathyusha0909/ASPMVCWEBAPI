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
//    public class Sample2Controller : ApiController
//    {
       
//        //   public HttpResponseMessage Get(int id)
//        //{
//        //    //create a response stream
//        //    var response = Request.CreateResponse();
//        //    //add content to the response stream,content can be String/Object
//        //    response.Content = new StringContent(
//        //        content: "The input was" + id.ToString() + "and response is sent");
//        //    if (id > 10)
//        //        response.StatusCode = HttpStatusCode.OK;
//        //    else
//        //        response.StatusCode = HttpStatusCode.BadRequest;
//        //    response.ReasonPhrase = "The request is processed.";
//        //    return response;
//        //}
//        [HttpGet]
//       // [ActionName("check")]
//        [Route("api/sample2/{id}")]
//        public IHttpActionResult checkInputAndReturnString(/*int id*/)
//        {
//            WebClient client = new WebClient();
//            var countries = client.DownloadString("https://restcountries.eu/rest/v2/region/asia");
//            var reader = new JsonTextReader(new StringReader(countries));
//            JsonSerializer serializer = new JsonSerializer();
//            object obj = serializer.Deserialize(reader);

//            return Ok(obj);
//        //    var id = 10;
//        //    if (id > 10)
//        //    {
//        //        return Ok("This input was" + id.ToString() + "and the response is sent.");

//        //    }
//        //    else
//        //        return BadRequest("Some required data is missing");
//        }
//    }
//}
