namespace caseStudy.RoomBooking.Infrastrcucture.Persistence.Entites
{

    public abstract class BaseEntity{

        public string Id {get; set;}

        public DateTime Created {get; set;} = DateTime.Now;

        public DateTime Modified {get; set;} = DateTime.Now;
    }     
}