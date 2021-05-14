namespace WebAPI.Models
{
    public class Hotel
    {
        public int HotelId {get;set;}
        public string Name {get;set;}
        public string Website {get;set;}

        public string City {get;set;}

        public int Rating {get;set;}

        public string ImageURL {get;set;}

        public Hotel(int id,string name, string website, string city, int rating, string imgU){
            HotelId = id;
            Name = name;
            Website = website;
            City = city;
            Rating = rating;
            ImageURL = imgU;


        }

        public Hotel(){}

    }
}