using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public static class MegrendelesManager
    {
        public static List<Megrendeles> Search(string nev, DateTime fromDate, DateTime toDate)
        {
            using (CRMEntities oc = new CRMEntities())
            {
                return (from m in oc.Megrendeles.Include("Statusz").Include("Telephely.Vevo")
                        where m.Telephely.Vevo.Nev.Contains(nev)
                              && m.Datum >= fromDate
                              && m.Datum <= toDate
                        orderby m.Telephely.Vevo.Nev
                        select m).ToList();

            }
        }

        public static List<MegrendelesTetel> ListTetel(int megrendelesId)
        {
            using (CRMEntities oc = new CRMEntities())
            {
                return (from m in oc.MegrendelesTetel.Include("Termek").Include("Statusz")
                        where m.MegrendelesID == megrendelesId
                        select m).ToList();

            }
        }
        public static List<string> ListVevo(string nev)
        {
            using (CRMEntities oc = new CRMEntities())
            {
                return (from v in oc.Vevo
                        where v.Nev.Contains(nev)
                        select v.Nev).Distinct().ToList();

            }
        }
    }
}
