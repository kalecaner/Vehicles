using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

using Vehicles.BLL.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vehicles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        ICarService CarService;
        IBusService BusService;
        IBoatService BoatService;
        public VehicleController(ICarService _CarService, IBusService _BusService, IBoatService _BoatService)
        {
            CarService = _CarService;
            BusService = _BusService;
            BoatService = _BoatService; 
        }
        
        [HttpGet("GetCarsByColor")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<string>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        public IActionResult GetCarbyColor(string color)
        {
            List<string> CarList = CarService.GetCarbyColor(color);
                if(CarList == null)
            {
                return BadRequest($"{color} renkte araba bulunmamaktadır.");
            }
                else
            {
            return Ok(CarList);

            }

        }

        [HttpGet("GetBusByColor")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<string>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        public IActionResult GetBusbyColor(string color)
        {
           
            List<string> BusList = BusService.GetBusbyColor(color);
            if (BusList == null)
            {
                return BadRequest($"{color} renkte araba bulunmamaktadır.");
            }
            else
            {
                return Ok(BusList);

            }
            
        }
        [HttpGet("GetBoatByColor")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<string>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        public IActionResult GetBoatbyColor(string color)
        {
            List<string> BoatList = BoatService.GetBoatbyColor(color);

            if (BoatList == null)
            {
                return BadRequest($"{color} renkte araba bulunmamaktadır.");
            }
            else
            {
                return Ok(BoatList);

            }
            return Ok();
        }
        [HttpPost("On/OffHeadLights")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
         [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        public IActionResult OnOff ( string NumberPlate )
        {
            string Result = CarService.TurnHeadLightofVehicle(NumberPlate);
           if (Result == "on")
            {
                return Ok($"{NumberPlate} plakalı aracınızın  farları açılmıştır.");
            }
            else if (Result == "off")
            {
                return Ok($"{NumberPlate} plakalı aracınızın  farları kapatılmıştır.");
            }
           else
            {
                return  BadRequest("Bir yerlerde kısa devre var en yakın elektrilçiye uğra..");
            }
        }
        [HttpDelete("RemoveCar")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        public IActionResult RemoveCar(string Brand)
        {
            if (CarService.IsThereCar(Brand.ToLower().Trim()))
            {
                if (CarService.Delete(Brand.ToLower().Trim()) > 0)
                {
                    return Ok($"{Brand} marka araç başarı ile silinmiştir.");
                }
                else
                {
                    return BadRequest("Silme işlemi tamamlanamadı");
                }

            }
            else
            {
                return BadRequest("Böyle bir araba bulunmamaktadır.");
            }


        }


    }
}
