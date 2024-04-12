using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_Wydarzen.Models
{
    public class WydarzenieRepository : IWydarzenieRepository
    {
        private List<Wydarzenie> _repositoryList;
        public WydarzenieRepository()
        {
            _repositoryList = new List<Wydarzenie>();
        }

        public void Add(Wydarzenie wydarzenie)
        {
            _repositoryList.Add(wydarzenie);
        }

        public void Delete(int index)
        {
            _repositoryList.RemoveAt(index);
        }

        public IEnumerable<Wydarzenie> GetAll()
        {
            List<Wydarzenie> lista = new List<Wydarzenie>();
            foreach (var w in _repositoryList)
            {
                lista.Add(w);
            }
            return lista;
        }
    }
}
