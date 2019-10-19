namespace HairSalon.Models
{
    public class Client
    {
        public int ClientID{get;set;}
        public int StylistId {get;set;}
        public string ClientName {get;set;}
        public int PhoneNumber{get;set;}
        public string StyleType{get;set;} 
        public virtual Stylist OneStylist {get;set;}
    }
}