using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")] //defines routes for requests  
    public class HotelController:ControllerBase
    {
         List<Hotel> lsHotels = HotelListUtil.lsHotels;
        public HotelController(){

            if(lsHotels.Count == 0){
                Hotel h1 = new Hotel(1,"Endless Horizons Boutique Hotel","https://endlesshorizons.co.za/","Durban",5,"https://www.google.com/imgres?imgurl=https%3A%2F%2Fcf.bstatic.com%2Fimages%2Fhotel%2Fmax1024x768%2F118%2F118379468.jpg&imgrefurl=https%3A%2F%2Fwww.booking.com%2Fhotel%2Fza%2Fendless-horizons-boutique.html&tbnid=-v6UjreOQbGZTM&vet=12ahUKEwiL07qZqIzwAhUI7xoKHVGJD2wQMygAegUIARCXAQ..i&docid=_N4hIGI_Qvz8PM&w=1024&h=683&q=Endless%20Horizons%20Boutique%20Hotel&ved=2ahUKEwiL07qZqIzwAhUI7xoKHVGJD2wQMygAegUIARCXAQ");
                Hotel h2 = new Hotel(2,"Waldorf Astoria","https://waldorfastoria3.hilton.com/","Beijing",5,"https://www.hilton.com/im/en/BJSWAWA/10748545/brasserie-1893-serves-innovative-french-cuisine.jpg?impolicy=crop&cw=4595&ch=2112&gravity=NorthWest&xposition=0&yposition=443&rw=1240&rh=570");
                Hotel h3 = new Hotel(3,"Burj Al Arab","https://www.jumeirah.com/","Dubai",5,"https://scontent.cdninstagram.com/v/t51.2885-15/sh0.08/e35/s640x640/157648915_1607014439485577_5490161647745448996_n.jpg?tp=1&_nc_ht=scontent.cdninstagram.com&_nc_cat=105&_nc_ohc=AoOSPHDUmfYAX-InPOP&edm=AMO9-JQAAAAA&ccb=7-4&oh=a6c2590aa307f470a274344addb233fb&oe=608D3E79&_nc_sid=b9f2ee");
                lsHotels.Add(h1);
                lsHotels.Add(h2);
                lsHotels.Add(h3);

            }
            
        }

        [HttpGet]
        public List<Hotel> GetHotels(){
          
            return lsHotels;
        }

        [HttpGet]
        //[Route("{s:string}")]  //?s=Parameter
        public Hotel GetHotel(string s){
          
            return lsHotels.Where(x=> x.Name.Contains(s)).FirstOrDefault();
        }

        [HttpPost]
        //[Route("{s:string}")]  //?s=Parameter
        public void AddHotel(Hotel h){
          
            lsHotels.Add(h);
        }



    }
}