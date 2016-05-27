using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Gyakorlat.Models
{
    public class TermekSearchModel
    {
        [Required]
        [Display(Name = "Termék név")]
        public string TermekNev { get; set; }

        [Required]
        [Display(Name = "Min ár")]
        public int MinAr { get; set; }
    }

    public class TermekSearchResultModel
    {
        public int Id { get; set; }

        [Display(Name = "Termék név")]
        public string TermekNev { get; set; }

        [Display(Name = "Nettó ár")]
        public double NettoAr { get; set; }

        [Display(Name = "Raktárkészlet")]
        public int Rakatrkeszlet { get; set; }

        [Display(Name = "Kategória")]
        public string Kategoria { get; set; }

        public static IEnumerable<TermekSearchResultModel> EnumerateTermek(IEnumerable<Termek> list)
        {
            foreach (var item in list)
            {
                TermekSearchResultModel retVal = new TermekSearchResultModel
                {
                    Id = item.ID,
                    TermekNev = item.Nev,
                    NettoAr = item.NettoAr.Value,
                    Rakatrkeszlet = item.Raktarkeszlet.Value,
                    Kategoria = item.Kategoria.Nev
                };
                yield return retVal;
            }
        }
    }
    public class TermekEditModel
    {
        public int Id { get; set; }

        [Display(Name = "Termék név")]
        [Required]
        public string TermekNev { get; set; }

        [Display(Name = "Nettó ár")]
        [Required]
        [Range(0, Double.MaxValue)]
        public double NettoAr { get; set; }

        [Display(Name = "Raktárkészlet")]
        [Required]
        [Range(0, Int32.MaxValue)]
        public int Raktarkeszlet { get; set; }

        public string Verzio { get; set; }

        public static TermekEditModel CreateFromTermek(Termek t)
        {
            TermekEditModel retVal = new TermekEditModel
            {
                Id = t.ID,
                TermekNev = t.Nev,
                NettoAr = t.NettoAr.Value,
                Raktarkeszlet = t.Raktarkeszlet.Value,
                Verzio = Convert.ToBase64String(t.verzio)
            };

            return retVal;
        }
        //public Termek CreateTermek()
        //{
        //    Termek retVal = TermekManager.GetTermekById(this.Id);
        //    retVal.Nev = this.TermekNev;
        //    retVal.NettoAr = this.NettoAr;
        //    retVal.Raktarkeszlet = this.Raktarkeszlet;
        //    retVal.verzio = Convert.FromBase64String(this.Verzio);
        //    return retVal;
        //}
    }
}