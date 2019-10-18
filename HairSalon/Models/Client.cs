namespace HairSalon.Models
{
    public class Client
    {
        public int ClientID{get;set;}
        public int StylistId {get;set;}
        public int ClientName {get;set;}
        public virtual Stylist OneStylist {get;set;}
    }
}