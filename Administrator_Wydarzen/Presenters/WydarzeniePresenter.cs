﻿using Administrator_Wydarzen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Administrator_Wydarzen.Presenters
{
    public class WydarzeniePresenter
    {
        private Models.IWydarzenieRepository _repository;
        private Views.IWydarzenieView _view;
        private IEnumerable<Wydarzenie> _wydarzenia;

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
            _wydarzenia = new List<Wydarzenie>();
            
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
        
            using (SaveFileDialog fd = new SaveFileDialog())
            {
                DialogResult dialogResult = fd.ShowDialog();
                fd.Filter = "Pliki XML (*.xml)|*.xml";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    
                    if (fd.FileName.EndsWith("xml"))
                    {
                        _repository.Serialize(fd.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Dozwolony format to xml!");
                        return;
                    }

                }
            }
        }

        private void DeserializeWydarzenieList(object sender, EventArgs e)
        {
             using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Pliki XML (*.xml)|*.xml";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;

                DialogResult dialogResult = fd.ShowDialog();
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    _view.DataGridClear();

                    _wydarzenia = _repository.Deserialize(fd.FileName);
                    _repository.Clear();
                    foreach (var w in _wydarzenia)
                    {
                        _repository.Add(w);
                        _view.DataGridUpdate(w);
                    }

                }

            }
        }
    

        private void SortWydarzenieToGrid(object sender, EventArgs e)
        {
            if (_view.SetErrorSortBox())
            {
                _view.DataGridClear();
                _wydarzenia = _repository.SortByType(_view.SortType);
                _repository.Clear();

                foreach (var w in _wydarzenia)
                {
                    _repository.Add(w);
                    _view.DataGridUpdate(w);
                }
            }
        }

    }
}
