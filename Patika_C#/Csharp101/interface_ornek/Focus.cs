namespace interface_ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Ford;
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