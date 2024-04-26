using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Entity.Models
{
    public class SheetMaster
    {
        public int Mark { get; set; }
        public string? Subject { get; set; }
        public virtual Student Student { get; set; } = null!;
    }
}
