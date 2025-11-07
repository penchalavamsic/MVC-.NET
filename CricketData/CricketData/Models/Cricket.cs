namespace CricketData.Models
{
    public class Cricket
    {
        //player details
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public int runs { get; set; }
        public DateTime GameDay { get; set; }
    }
}
