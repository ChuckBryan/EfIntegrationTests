namespace BusinessLayer
{
    using System;
    using System.Xml.Schema;

    public class Car : EntityBase
    {
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
    }
}