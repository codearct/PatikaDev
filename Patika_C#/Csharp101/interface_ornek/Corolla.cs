namespace interface_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}