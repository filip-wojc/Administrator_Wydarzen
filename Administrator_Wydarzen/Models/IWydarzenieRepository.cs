using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_Wydarzen.Models
{
    public interface IWydarzenieRepository
    {
        void Add(Wydarzenie wydarzenie);
        void Delete(int index);

        void Serialize(IEnumerable<Wydarzenie> wydarzenia, string path);
        IEnumerable<Wydarzenie> Deserialize(string path);
        IEnumerable<Wydarzenie> SortByType(IEnumerable<Wydarzenie> wydarzenia, string type);
        // IEnumerable<Wydarzenie> FiltrByType(IEnumerable<Wydarzenie> wydarzenia, string type);
        IEnumerable<Wydarzenie> GetAll();

    }
}
