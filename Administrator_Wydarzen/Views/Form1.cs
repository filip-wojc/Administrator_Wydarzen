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

namespace Administrator_Wydarzen.Views
{
    public partial class Form1 : Form, IWydarzenieView
    {
        public Form1()
        {
            InitializeComponent();
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
        }

        public string Title { get => TitleBox.Text; set => TitleBox.Text = value; }
        public string Description { get => DescriptionBox.Text; set => DescriptionBox.Text = value; }
        public DateTime Date { get => DateBox.Value; set => DateBox.Value = value; }
        public string Typ { get => ListBox.Text; set => ListBox.Text = value; }
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

        public event EventHandler AddWydarzenie;
        public event EventHandler DeleteWydarzenie;
        public event EventHandler SerializeWydarzenie;
        public event EventHandler DeserializeWydarzenie;
        public event EventHandler SortWydarzenie;
        public event EventHandler FiltrWydarzenie;

        public void DataGridUpdate(Wydarzenie wydarzenie)
        {
            dataGridView1.Rows.Add(wydarzenie.Title, wydarzenie.Description, wydarzenie.Date.ToShortDateString(), wydarzenie.Typ, wydarzenie.Priority);

            LowPrioBox.Checked = false;
            MidPrioBox.Checked = false;
            HighPrioBox.Checked = false;
        }

        public bool SetErrorPriorityBox()
        {
            throw new NotImplementedException();
        }

        public bool SetErrorTextBox()
        {
            throw new NotImplementedException();
        }

        public bool SetErrorTypeBox()
        {
            throw new NotImplementedException();
        }

        public bool SetErrorSortBox()
        {
            throw new NotImplementedException();
        }

        public bool SetErrorFiltrBox()
        {
            throw new NotImplementedException();
        }
    }
}
