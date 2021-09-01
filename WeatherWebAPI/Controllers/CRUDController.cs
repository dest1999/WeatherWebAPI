using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        private WeatherForecastCollection _collection;

        public CRUDController(WeatherForecastCollection collection)
        {
            _collection = collection;
        }

        [HttpPost("create")]
        public IActionResult Create([FromQuery]DateTime dateTime, [FromQuery] int temp)
        {
            _collection.Create(dateTime, temp);
            return Ok();
        }

        [HttpGet("read")]
        public IActionResult Read()
        {
            return Ok(_collection.Read());
        }

        [HttpGet("readbyperiod")]
        public IActionResult Read([FromQuery]DateTime from, [FromQuery]DateTime to)
        {
            return Ok(_collection.Read(from, to));
        }

        [HttpPut("update")]
        public IActionResult Update([FromQuery]DateTime dateTime, [FromQuery]int temp)
        {
            _collection.Update(dateTime, temp);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery]DateTime date)
        {
            _collection.Delete(date);
            return Ok();
        }

        [HttpDelete("deleteperiod")]
        public IActionResult Delete([FromQuery]DateTime from, [FromQuery]DateTime to)
        {
            _collection.Delete(from, to);
            return Ok();
        }

    }
}
