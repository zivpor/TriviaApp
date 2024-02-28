using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaApp.Models
{
    public class SubjectQuestion
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;

    }
}
