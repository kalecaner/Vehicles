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
        public IActionResult GetCarbyColor(string color)
        {

            return Ok(CarService.GetCarbyColor(color));
        }

        [HttpGet("GetBusByColor")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<string>))]
        public IActionResult GetBusbyColor(string color)
        {

            return Ok(BusService.GetBusbyColor(color));
        }
        [HttpGet("GetBoatByColor")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<string>))]
        public IActionResult GetBoatbyColor(string color)
        {

            return Ok(BoatService.GetBoatbyColor(color));
        }
        [HttpPost("On/OffHeadLights")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
         [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        public IActionResult OnOff ( string NumberPlate )
        {
           if (CarService.TurnHeadLightofVehicle(NumberPlate) == "on")
            {
                return Ok($"{NumberPlate} plakalı aracınızın  farları açılmıştır.");
            }
            else if (CarService.TurnHeadLightofVehicle(NumberPlate) == "off")
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
            if (CarService.IsThereCar(Brand))
            {
                if (CarService.Delete(Brand) > 0)
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
