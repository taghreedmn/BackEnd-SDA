using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.Entity
{
    public class VideoGameVersion
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("VideoGameInfo")]
        public Guid VideoGameInfoId { get; set; }
        public double Price { get; set; }
        // public VideoGameInfo videoGameInfo{ get; set; }

    }
}