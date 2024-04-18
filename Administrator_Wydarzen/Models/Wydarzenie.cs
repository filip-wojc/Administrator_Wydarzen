using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrator_Wydarzen.Models
{
    public class Wydarzenie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Type {  get; set; }
        public string Priority {  get; set; }

        public Wydarzenie(string title, string description, DateTime date, string typ, string priority)
        {
            Title = title;
            Description = description;
            Date = date;
            Type = typ;
            Priority = priority;
        }
        public Wydarzenie() { }
        public override string ToString()
        {
            return $"{Title}, {Description}, {Date.ToShortDateString()}, {Type}, {Priority}";
        }
    }
}
