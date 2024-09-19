namespace Orai
{
    public class Meccs
    {
        public int Id { get; set; }
        public int Fordulo { get; set; }
        public int HazaiGol { get; set; }
        public int VendegGol { get; set; }
        public int HazaiFelidogol { get; set; }
        public int VendegFelidogol { get; set; }
        public string HazaiCsapat { get; set; }
        public string VendegCsapat { get; set; }

        public string GyoztesCsapatNeve()
        {
            if (HazaiGol > VendegGol) return HazaiCsapat;
            else if (HazaiGol < VendegGol) return VendegCsapat;
            else return "";
        }

    }



}
