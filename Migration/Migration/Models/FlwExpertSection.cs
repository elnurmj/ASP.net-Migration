using LessonMigration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Models
{
    public class FlwExpertSection:BaseEntity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public ICollection<Expert> Experts { get; set; }
    }
}
