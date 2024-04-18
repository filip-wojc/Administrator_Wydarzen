using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_Wydarzen.Presenters
{
    public class WydarzeniePresenter
    {
        private Models.IWydarzenieRepository _repository;
        private Views.IWydarzenieView _view;
        private IEnumerable<Models.Wydarzenie> _wydarzenieList;

        public WydarzeniePresenter(Views.IWydarzenieView view, Models.IWydarzenieRepository model)
        {
            _view = view;
            _repository = model;

            _view.AddWydarzenie += AddWydarzenieToGrid;
            _view.DeleteWydarzenie += DeleteWydarzenieFromGrid;
            _view.SerializeWydarzenie += SerializeWydarzenieList;
            _view.DeserializeWydarzenie += DeserializeWydarzenieList;
            _view.SortWydarzenie += SortWydarzenieToGrid;
            //_view.FiltrWydarzenie += FiltrWydarzenieToGrid;

            _wydarzenieList = _repository.GetAll();
        }

        private void AddWydarzenieToGrid(object sender, EventArgs e)
        {
            if (_view.SetErrorTitleBox() && _view.SetErrorDescrBox() &&
                _view.SetErrorTypeBox() && _view.SetErrorPriorityBox())
            {
                var wydarzenie = new Models.Wydarzenie(_view.Title, _view.Description, _view.Date, _view.Type, _view.Priority);
                _repository.Add(wydarzenie);

                _view.DataGridUpdate(wydarzenie);
                _view.Title = "";
                _view.Description = "";
                _view.Date = DateTime.Now;
               
            }
        }

        private void DeleteWydarzenieFromGrid(object sender, EventArgs e)
        {
            var indeksy = _view.DataGridDeleteRows();
            if (indeksy.Count > 0)
            {
                foreach (int i in indeksy)
                {
                    _repository.Delete(i);
                }
            }
        }

        private void SerializeWydarzenieList(object sender, EventArgs e)
        {
            
        }

        private void DeserializeWydarzenieList(object sender, EventArgs e)
        {

        }

        private void SortWydarzenieToGrid(object sender, EventArgs e)
        {

        }

    }
}
