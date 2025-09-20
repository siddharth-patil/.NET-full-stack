using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CitiesManager.Web.DatabaseContext;
using CitiesManager.Web.Models;
using Asp.Versioning;

namespace CitiesManager.Web.Controllers.v1
{
    [ApiVersion("1.0")]
    
    public class CitiesController : CustomControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        /// <summary>
        /// To get list of cities (including city ID and city name from 'cities' table)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<City>>> GetCities()
        {
            var cities = await _context.Cities.OrderBy(temp=>temp.CityName).ToListAsync();

            return cities;
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(Guid id)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(temp=>temp.CityID == id);

            if (city == null)
            {
                return NotFound();
            }

            return city;
        }

        // PUT: api/Cities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{cityId}")]
        public async Task<IActionResult> PutCity(Guid cityId, [Bind(nameof(City.CityID),
            nameof(City.CityName))] City city)
        {
            if (cityId != city.CityID)
            {
                return BadRequest(); //HTTP 400
            }

            var existingCity = await _context.Cities.FindAsync(cityId);
            if (existingCity == null)
            {
                return NotFound(); //HTTP 404
            }

            existingCity.CityName = city.CityName;

            //_context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(cityId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<City>> PostCity([Bind(nameof(City.CityID), 
            nameof(City.CityName))]City city)
        {
            //if(ModelState.IsValid == false)
            //{
            //    return ValidationProblem(ModelState);
            //}

            if (_context.Cities == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cities'  is null.");
            }
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCity", new { id = city.CityID }, city);
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(Guid id)
        {
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CityExists(Guid id)
        {
            return _context.Cities.Any(e => e.CityID == id);
        }
    }
}
