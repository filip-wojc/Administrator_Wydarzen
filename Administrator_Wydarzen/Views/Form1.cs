using Administrator_Wydarzen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Administrator_Wydarzen.Views
{
    public partial class Form1 : Form, IWydarzenieView
    {
        public Form1()
        {
            InitializeComponent();
            _associateAndRaiseNewEvents();
        }

        private void _associateAndRaiseNewEvents()
        {

            AddBtn.Click += (sender, e) =>
            {
                AddWydarzenie?.Invoke(this, EventArgs.Empty);
            };
            DeleteBtn.Click += (sender, e) =>
            {
                DeleteWydarzenie?.Invoke(this, EventArgs.Empty);
            };
            SaveBtn.Click += (sender, e) =>
            {
                SerializeWydarzenie?.Invoke(this, EventArgs.Empty);
            };

            LoadBtn.Click += (sender, e) =>
            {
                DeserializeWydarzenie?.Invoke(this, EventArgs.Empty);
            };

            SortBtn.Click += (sender, e) =>
            {
                SortWydarzenie?.Invoke(this, EventArgs.Empty);
            };

            FiltrBtn.Click += (sender, e) =>
            {
                FiltrWydarzenie?.Invoke(this, EventArgs.Empty);
            };
        }

        

        public string Title { get => TitleBox.Text; set => TitleBox.Text = value; }
        public string Description { get => DescriptionBox.Text; set => DescriptionBox.Text = value; }
        public DateTime Date { get => DateBox.Value; set => DateBox.Value = value; }
        public string Type 
        {
            get
            {
                var selectedTypes = ListBox.CheckedItems.Cast<string>().ToList();
                return string.Join(", ", selectedTypes);
            }
        }
        
        public string Priority 
        { 
            get
            {
                if (LowPrioBox.Checked) { return LowPrioBox.Text; }
                if (MidPrioBox.Checked) { return MidPrioBox.Text; }
                if (HighPrioBox.Checked) { return HighPrioBox.Text; }
                return "";
            }
        }

        public string SortType
        {
            get
            {
                if (SortByDateBox.Checked) { return SortByDateBox.Text; }
                else if (SortByPrioBox.Checked) { return SortByPrioBox.Text; }
                else if (SortByTypeBox.Checked) { return SortByTypeBox.Text; }
                return "";
            }
        }

        public string FiltrType
        {
            get
            {
                if (FiltrByDateBox.Checked) { return FiltrByDateBox.Text; }
                if (FiltrByPriorityBox.Checked) { return FiltrByPriorityBox.Text; }
                if (FiltrByTypeBox.Checked) { return FiltrByTypeBox.Text; }
                return "";
            }
        }
        public event EventHandler AddWydarzenie;
        public event EventHandler DeleteWydarzenie;
        public event EventHandler SerializeWydarzenie;
        public event EventHandler DeserializeWydarzenie;
        public event EventHandler SortWydarzenie;
        public event EventHandler FiltrWydarzenie;

        public void DataGridUpdate(Wydarzenie wydarzenie)
        {
            dataGridView1.Rows.Add(wydarzenie.Title, wydarzenie.Description, wydarzenie.Date.ToShortDateString(), wydarzenie.Type, wydarzenie.Priority);

            LowPrioBox.Checked = false;
            MidPrioBox.Checked = false;
            HighPrioBox.Checked = false;

            while (ListBox.CheckedIndices.Count > 0)
            {
                ListBox.SetItemChecked(ListBox.CheckedIndices[0], false);
            }

             
        }

        public void DataGridClear()
        {
            dataGridView1.Rows.Clear();
        }

        public List<int> DataGridDeleteRows()
        {
            var indeksy = new List<int>();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        indeksy.Add(row.Index);
                        dataGridView1.Rows.Remove(row);
                    }
                    
                }
            }
            return indeksy;
        }

        public bool SetErrorPriorityBox()
        {
            var rb = new RadioButton[] { LowPrioBox, MidPrioBox, HighPrioBox };
            if (rb[0].Checked || rb[1].Checked || rb[2].Checked)
            {
                errorProvider1.SetError(rb[1], "");
                return true;
            }
            else
            {
                errorProvider1.SetError(rb[1], "Nic nie zostało wybrane");
                return false;
            }
        }

        public bool SetErrorTitleBox()
        {
            if (TitleBox.Text == "")
            {
                errorProvider1.SetError(TitleBox, "Puste pole");
                return false;
            }
            else
            {
                errorProvider1.SetError(TitleBox, "");
                return true;
            }
        }

        public bool SetErrorDescrBox()
        {
            if (DescriptionBox.Text == "")
            {
                errorProvider1.SetError(DescriptionBox, "Puste pole");
                return false;
            }
            else
            {
                errorProvider1.SetError(DescriptionBox, "");
                return true;
            }
        }

        public bool SetErrorTypeBox()
        {
            if (ListBox.CheckedItems.Count == 0)
            {
                errorProvider1.SetError(ListBox, "Nic nie zostało wybrane");
                return false;
            }
            else
            {
                errorProvider1.SetError(ListBox, "");
                return true;
            }
        }

        public bool SetErrorSortBox()
        {
            var rb = new RadioButton[] { SortByDateBox, SortByPrioBox, SortByTypeBox };
            if (rb[0].Checked || rb[1].Checked || rb[2].Checked)
            {
                errorProvider1.SetError(rb[1], "");
                return true;
            }
            else
            {
                errorProvider1.SetError(rb[1], "Nic nie zostało wybrane");
                return false;
            }
        }

        public bool SetErrorFiltrBox()
        {
            var rb = new RadioButton[] { FiltrByDateBox, FiltrByPriorityBox, FiltrByTypeBox };
            if (rb[0].Checked || rb[1].Checked || rb[2].Checked)
            {
                errorProvider1.SetError(rb[1], "");
                return true;
            }
            else
            {
                errorProvider1.SetError(rb[1], "Nic nie zostało wybrane");
                return false;
            }
        }
    }
}
