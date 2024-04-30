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
        string Type { get; }
        string Priority { get;}
        string SortType { get; }
        string FiltrType { get; set; }
        string FiltrPrior { get; set; }
        string FiltrDate { get; set; }
        

        event EventHandler AddWydarzenie;
        event EventHandler DeleteWydarzenie;
        event EventHandler SerializeWydarzenie;
        event EventHandler DeserializeWydarzenie;
        event EventHandler SortWydarzenie;
        event EventHandler FiltrWydarzenieByType;
        event EventHandler FiltrWydarzenieByPrior;
        event EventHandler FiltrWydarzenieByDate;

        bool SetErrorTitleBox();
        bool SetErrorDescrBox();
        bool SetErrorTypeBox();
        bool SetErrorPriorityBox();

        bool SetErrorSortBox();

        void DataGridUpdate(Wydarzenie wydarzenie);
        void DataGridClear();
        List<int> DataGridDeleteRows();
    }
}
