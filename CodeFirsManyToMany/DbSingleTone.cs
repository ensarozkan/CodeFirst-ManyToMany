using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_codeFirsManyToMany
{
    public class DbSingleTone
    {
        private static Universite db;
        public static Universite GetUniversite()
        {
            if (db==null)
            {
                db = new Universite();
            }
            return db;
        }
    }
}
