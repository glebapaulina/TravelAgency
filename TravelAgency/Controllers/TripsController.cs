using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelAgency.BusinessLayer.Country;
using TravelAgency.BusinessLayer.Trip;

namespace TravelAgency.Controllers.Api
{ 
    [RoutePrefix("api/countries")]
    
    public class TripsController : ApiController
    {
        private readonly ICountryService _countryService;

        public TripsController()
        {
            
        }
        public TripsController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            return Ok(_countryService.GetAll());
        }
      

        
    }
}
