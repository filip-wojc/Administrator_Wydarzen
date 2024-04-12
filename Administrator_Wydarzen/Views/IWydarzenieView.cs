using Administrator_Wydarzen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_Wydarzen.Views
{
    public interface IWydarzenieView
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
        string Typ { get; set; }
        string Priority { get;}

        event EventHandler AddWydarzenie;
        event EventHandler DeleteWydarzenie;
        event EventHandler SerializeWydarzenie;
        event EventHandler DeserializeWydarzenie;
        event EventHandler SortWydarzenie;
        event EventHandler FiltrWydarzenie;

        bool SetErrorTextBox();
        bool SetErrorTypeBox();
        bool SetErrorPriorityBox();

        bool SetErrorSortBox();
        bool SetErrorFiltrBox();

        void DataGridUpdate(Wydarzenie wydarzenie);
    }
}
