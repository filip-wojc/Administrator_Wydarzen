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

        public void Clear()
        {
            _repositoryList.Clear();
        }

        public void Serialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Wydarzenie>));

            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, _repositoryList);
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

        public IEnumerable<Wydarzenie> SortByType(string type)
        {
          
            if (type == "Po typie")
            {
                return _repositoryList.OrderBy(wydarzenie => wydarzenie.Type).ToList();
            }
            else if (type == "Po priorytecie")
            {
                return _repositoryList.OrderBy(wydarzenie => wydarzenie.Priority).ToList();
            }
            else
            {
                return _repositoryList.OrderBy(wydarzenie => wydarzenie.Date).ToList();
            }
        }


        //public IEnumerable<Wydarzenie> FiltrByType(IEnumerable<Wydarzenie> wydarzenia, string type) { }

    }
}
