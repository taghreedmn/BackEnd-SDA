using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FusionTech.src.Entity
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string? Game_Name { get; set; }
        public float Price{ get; set; }
        public string? Description{ get; set; }
        public DateTime Year_of_release { get; set; }
        public int Rating{ get; set; }
        public int Company_ID{ get; set; }
    }
}