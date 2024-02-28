using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaApp.Models
{
    public class StatusQuestion
    {
       
        public int StatusId { get; set; }
        public string StatusDescription { get; set; } = null!;

    }
}
