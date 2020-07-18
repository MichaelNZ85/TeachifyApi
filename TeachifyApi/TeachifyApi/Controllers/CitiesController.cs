using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using TeachifyApi.Models;

namespace TeachifyApi.Controllers
{
    public class CitiesController : ApiController
    {

        private readonly List<City> _cities = new List<City>()
        {
            new City() {Name = "Auckland"},
            new City() {Name = "Tauranga"},
            new City() {Name = "Wellington"},
            new City() {Name = "Napier"},
            new City() {Name = "Dunedin"},
            new City() {Name = "Invercargill"},
            new City() {Name = "Christchurch"},
            new City() {Name = "Ashburton"},
            new City() {Name = "New Plymouth"},
            new City() {Name = "Palmerston North"},
            new City() {Name = "Masterton"},
            new City() {Name = "Greymouth"},
            new City() {Name = "Hamilton"},
            new City() {Name = "Wanganui"},
        };

        // GET: api/Cities
        public IQueryable<City> GetCities()
        {
            return _cities.AsQueryable();
        }

    }
}