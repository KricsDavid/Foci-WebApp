using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Orai.Models;

namespace Orai.Pages.Shared
{
    public class TabellaModel : PageModel
    {
        private readonly FociDbContext _context;


        public TabellaModel(FociDbContext context)
        {
            _context = context;
        }

        public List<Meccs> meccsek;
        public List<Eredmeny> Eredmenyek;
        public void OnGet()
        {
            meccsek = _context.Meccsek.ToList();
            Eredmenyek = new List<Eredmeny>();

            foreach (var cs in meccsek.Select(x => x.HazaiCsapat.Distinct()))
            {
                Eredmeny ujCsapat = new Eredmeny();
                ujCsapat.CsapatNev = (string)cs;
                Eredmenyek.Add(ujCsapat);
            }
            foreach (var cs in Eredmenyek)
            {
                cs.GyozelmekSzama = meccsek.Where(x => x.GyoztesCsapatNeve() == cs.CsapatNev).Count();
                cs.VeresegekSzama = meccsek.Where(x => x.HazaiCsapat == cs.CsapatNev || x.VendegCsapat == cs.CsapatNev
                && x.GyoztesCsapatNeve()!= cs.CsapatNev && x.GyoztesCsapatNeve() != "").Count();

            }

        }
    }
}
