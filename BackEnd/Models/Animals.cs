using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Animals : Subject
    {

        public int AnimalsId { get; set; }
        public string Country { get; set; }
        public LivingArea LA {get; set; }
        public Class CS {get; set; }
        public string Gender { get; set; }

    }
    public class Class
    {
        public int Id { get; set; }
        public bool Mammal { get; set; }
        public bool Bird { get; set; }
        public bool Fish { get; set; }
        public bool Reptile { get; set; }

    }
    public class LivingArea
    {
        public int Id { get; set; }
        public bool Land { get; set; }
        public bool Sea { get; set; }
    }
}
