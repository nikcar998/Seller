using System;

namespace Domain
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public double Cost { get; set; }
        //  public string[] Comments { get; set; }
        // public Image image
        public int Phone { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

    }
}