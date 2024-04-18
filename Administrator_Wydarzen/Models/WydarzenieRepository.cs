using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        public void Serialize(IEnumerable<Wydarzenie> wydarzenia, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Wydarzenie>));

            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, wydarzenia);
            }
        }

        public IEnumerable<Wydarzenie> Deserialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Wydarzenie>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (List<Wydarzenie>)serializer.Deserialize(fs);
            }
        }

        public IEnumerable<Wydarzenie> SortByType(IEnumerable<Wydarzenie> wydarzenia, string type)
        {
            var lista = GetAll();
            if (type == "Po typie")
            {
                return lista.OrderBy(wydarzenie => wydarzenie.Type);
            }
            else if (type == "Po priorytecie")
            {
                return lista.OrderBy(wydarzenie => wydarzenie.Priority);
            }
            else
            {
                return lista.OrderBy(wydarzenie => wydarzenie.Date);
            }
        }

        //public IEnumerable<Wydarzenie> FiltrByType(IEnumerable<Wydarzenie> wydarzenia, string type) { }
         
    }
}
