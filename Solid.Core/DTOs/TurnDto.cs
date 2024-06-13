using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class TurnDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double SumHour { get; set; }
        public string Type { get; set; }
        public string NameServiceProvider { get; set; }
    }
}
