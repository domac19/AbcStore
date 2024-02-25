namespace AbcStore.Models
{
    public class Persons
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public long OIB { get; set; }
        public int KorisnikId { get; set; }

    }
}