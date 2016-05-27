using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BLL;

namespace MVC_Gyakorlat.Models
{
    public class MegrendelesSearchModel
    {
        [Required]
        [Display(Name = "Vevő név")]
        public string VevoNev { get; set; }

        [Display(Name = "Kezdő Dátun")]
        public DateTime FromDate { get; set; }

        [Display(Name = "Befejező Dátun")]
        public DateTime ToDate { get; set; }

    }

    public class MegrendlesSearchResultModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Vevő név")]
        public string VevoNev { get; set; }

        [Display(Name = "Státusz")]
        public string Statusz { get; set; }

        [Display(Name = "Megrendelés dátuma")]
        public DateTime MegrendelesDatum { get; set; }

        public static IEnumerable<MegrendlesSearchResultModel> Enumerate(IEnumerable<Megrendeles> list)
        {
            foreach (var item in list)
            {
                yield return new MegrendlesSearchResultModel
                {
                    ID = item.ID,
                    VevoNev = item.Telephely.Vevo.Nev,
                    Statusz = item.Statusz.Nev,
                    MegrendelesDatum = item.Datum.GetValueOrDefault(DateTime.MinValue)
                };
            }
        }
    }
    public class MegrendlesTetelModel
    {
        public int TermekId { get; set; }

        [Required]
        [Display(Name = "Termék név")]
        public string TermekNev { get; set; }

        [Required]
        [Display(Name = "Termék ár")]
        public double Ar { get; set; }

        [Required]
        [Display(Name = "Mennyiseg")]
        public int Mennyiseg { get; set; }

        [Display(Name = "Státusz")]
        public string Statusz { get; set; }

        public static IEnumerable<MegrendlesTetelModel> Enumerate(IEnumerable<MegrendelesTetel> list)
        {
            foreach (var item in list)
            {
                yield return new MegrendlesTetelModel
                {
                    TermekId = item.ID,
                    TermekNev = item.Termek.Nev,
                    Mennyiseg = item.Mennyiseg.GetValueOrDefault(0),
                    Ar = item.NettoAr.GetValueOrDefault(0),
                    Statusz = item.Statusz.Nev
                };
            }
        }
    }
}