namespace Amusement_park
{
    public class Facilitie
    {
        static int id=0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumVisitorsForDay { get; set; }

        public int MinimalAge { get; set; }

        public int NumofWorkers { get; set; }

        public bool Status { get; set;}

        public int RoundDuration { get; set; }

        public Facilitie()
        {
            
        }
        public Facilitie(Facilitie f)
        {
            Id = id;
            id++;
            Name = f.Name;
            Description = f.Description;
            NumVisitorsForDay = f.NumVisitorsForDay;
            MinimalAge = f.MinimalAge;
            NumofWorkers = f.NumofWorkers;
            Status = f.Status;
            RoundDuration = f.RoundDuration;
        }

        public Facilitie(int idFromBody,Facilitie f)
        {
           
            Id = idFromBody;
            Name =f.Name;
            Description = f.Description;
            NumVisitorsForDay = f.NumVisitorsForDay;
            MinimalAge = f.MinimalAge;
            NumofWorkers =f.NumofWorkers;
            Status = f.Status;
            RoundDuration = f.RoundDuration;
        }
    }
}
