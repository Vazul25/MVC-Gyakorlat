using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class TermekManager
    {
        public static List<Termek> Search(string nev , int minAr )
        {
            using(var ctx=new CRMEntities())
            {
                return (from t in ctx.Termek.Include("Kategoria")
                        where t.Nev.Contains(nev) && t.NettoAr >= minAr
                        select t).ToList();

            }
        }
    }
}
