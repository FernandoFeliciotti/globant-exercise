using PresidentsExcercise.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq;

namespace PresidentsExcercise.Repository
{
    public class PresidentRepository : IPresidentRepository, IDisposable
    {
        private Context db;

        public PresidentRepository(Context _db)
        {
            db = _db;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<President> getPresidents(string name, string orderBy)
        {
            try
            {
                IQueryable<President> presidents = db.Presidents;
                if (!string.IsNullOrEmpty(name))
                {
                    presidents = presidents.Where(e => e.Fullname == name).
                        Select(i => new President { Fullname = i.Fullname, Birthplace = i.Birthplace, Birthday = i.Birthday, Deathday = i.Deathday, Deathplace = i.Deathplace });
                }

                if(!string.IsNullOrEmpty(orderBy))
                { 
                    if(orderBy.ToLower().Contains("deathday"))
                    {
                        var alivePresidents = presidents.Where(it => it.Deathday == null);
                        presidents = presidents.Where(it => it.Deathday != null).OrderBy(orderBy).Union(alivePresidents);
                    }
                    else
                    {
                        presidents = presidents.OrderBy(orderBy);
                    } 
                }

                return presidents.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
