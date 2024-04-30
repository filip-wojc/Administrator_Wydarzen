﻿using System;
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

        void Serialize(string path);
        void Clear();
        IEnumerable<Wydarzenie> GetAll();
        IEnumerable<Wydarzenie> Deserialize(string path);
        IEnumerable<Wydarzenie> SortByType(string type);
        IEnumerable<Wydarzenie> FiltrByType(string filtrText);
        IEnumerable<Wydarzenie> FiltrByPrior(string filtrText);
        IEnumerable<Wydarzenie> FiltrByDate(string filtrText);
    }
}
