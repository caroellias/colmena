using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST.Controllers
{
    public class ValuesController : ApiController
    {
        //método ejecutado al realizar una peticion GET al servidor http://localhost:21526/values
        public IEnumerable<string> Get()
        {
            return new string[] { "apple", "orange", "pear" };
        }

        ////método ejecutado al realizar una peticion GET con parametro al servidor http://localhost:21526/values/parametro
        public string Get(int id)
        {
            return "banana";
        }

        //método ejecutado al realizar una peticion POST al servidor http://localhost:21526/values desde el apartado BODY 
        public void Post([FromBody]string value)
        {

        }

        //método ejecutado al realizar una peticion PUT al servidor http://localhost:21526/values en el apartado BODY
        //Nota: se puede configurar este metodo para que el parametro pueda ser enviado desde una Uri, es decir haciendo referencia a un
        //recurso desde la URL. --->   //public string Put([FromUri]string value)
                                       //{
                                            //return "Put returning: " + value;
                                        //}
        public string Put([FromBody]string value)
        {
            return "Put returning: " + value;
        }

        //método ejecutado al realizar una peticion DELETE al servidor http://localhost:21526/values
        public void Delete(int id)
        {
        }
    }
}
