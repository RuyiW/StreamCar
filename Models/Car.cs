using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreamCar.Models
{
    public enum Transmissions
    {
        Automatic, Manual
    }
    public enum MakeNames
    {
        Audi, BMW, Cadillac, Dodge
    }
    public enum ModelNames
    {
        A3, Q3, Q7, TT,
        BMW330i, X1, X5, M240i,
        CT6, Escalade, XT5, ATSV,
        Dart, Durango, Journey, Hellcat
    }

    public class Car
    {
        [Key]
        [Display(Name = "VIN")]
        public int ID { get; set; }

        public int Year { get; set; }
        public int Value { get; set; }
        public int Mileage { get; set; }
        public String Colour { get; set; }
        public Transmissions Transmission { get; set; }
        public MakeNames MakeName { get; set; }
        public ModelNames ModelName { get; set; }
    }
}