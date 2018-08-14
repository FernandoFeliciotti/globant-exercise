using PresidentsExcercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresidentsExcercise.Repository
{
    public interface IPresidentRepository
    {
        List<President> getPresidents(string name, string orderBy);
    }
}
