using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.ViewModels.ViewModels
{
    public class StudentModel
    {
        public int? Id { get; set; }

        public string Name { get; set; } = null!;

        public string Class { get; set; } = null!;

        public int? MarkObtained { get; set; }
        public List<SheetModel>? StudentSheet { get; set; }
    }
}
