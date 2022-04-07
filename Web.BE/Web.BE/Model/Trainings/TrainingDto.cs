namespace Web.BE.Model.Trainings
{
    public class TrainingDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Issuer { get; set; }
        public string Description { get; set; }
        public DateTime IssuedDate { get; set; }
    }
}
