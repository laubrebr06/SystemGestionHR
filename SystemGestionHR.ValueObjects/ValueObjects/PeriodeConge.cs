namespace SystemGestionHR.ValueObjects
{
    public class PeriodeConge
    {
        public DateTime DateDebut { get; }
        public DateTime DateFin { get; }

        public PeriodeConge(DateTime dateDebut, DateTime dateFin)
        {
            if (dateFin < DateTime.UtcNow || dateDebut < DateTime.UtcNow)
                throw new ArgumentException("La date de fin et date de début doivent être supérieures à aujourd'hui.");

            if (dateFin < dateDebut)
                throw new ArgumentException("La date de fin ne peut pas être antérieure à la date de début.");

            DateDebut = dateDebut;
            DateFin = dateFin;
        }

        public int DureeEnJours()
        {
            return (DateFin - DateDebut).Days + 1;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not PeriodeConge autre) return false;
            return DateDebut == autre.DateDebut && DateFin == autre.DateFin;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DateDebut, DateFin);
        }
    }
}
