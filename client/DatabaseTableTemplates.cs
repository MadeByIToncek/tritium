using SQLite;

namespace Tritium
{
    [Table("tritium_clients")]
    public class Klient
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public required int Id { get; set; }
        [Column("name")]
        public required string Name { get; set; }
        [Column("birthdate")]
        public DateTime Birthdate { get; set; }
        [Column("telephone")]
        public string Telephone { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("initial_meeting")]
        public DateTime InitialMeeting { get; set; }
        [Column("kardiostimulator")]

        //Detailed stuff

        public bool Kardiostimulator { get; set; }
        [Column("aktualni_tehotenství")]
        public bool AktualniTehotenstvi { get; set; }
        [Column("onkologicke_onemocneni")]
        public bool OnkologickeOnemocneni { get; set; }
        [Column("epilepsie")]
        public bool Epilepsie { get; set; }
        [Column("autoimunitni_onemocneni")]
        public bool AutoimunitniOnemocneni { get; set; }
        [Column("leky")]
        public bool Leky { get; set; }
        [Column("dlouhodobe_potize")]
        public bool DlouhodobePotize { get; set; }
        [Column("krevni_tlak")]
        public bool KrevniTlak { get; set; }
        [Column("predchazejici_nemoci")]
        public bool PredchazejiciNemoci { get; set; }
        [Column("homeo")]
        public bool Homeo { get; set; }
        [Column("rodinna_anamneza")]
        public bool RodinnaAnamneza { get; set; }
        [Column("strava")]
        public bool Strava { get; set; }
        [Column("traveni")]
        public bool Traveni { get; set; }
        [Column("situace_prace")]
        public bool SituacePrace { get; set; }
        [Column("situace_rodina")]
        public bool SituaceRodina { get; set; }
        [Column("situace_ostatni")]
        public bool SituaceOstatni { get; set; }
        [Column("rozpolozeni_klienta")]
        public bool Rozpolozeni { get; set; }
    }

    [Table("tritium_visits")]
    public class Navsteva
    {
        [PrimaryKey,AutoIncrement,Unique,NotNull]
        [Column("id")]
        public required int Id { get; set; }
        [Column("client"),NotNull]
        public required int Client { get; set; }
        [Column("date"),NotNull]
        public required DateTime Date { get; set; }
    }
}
