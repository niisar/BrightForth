using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightForth.EF.Entities
{
    public class ErrLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ErrLogID { get; set; }
        public string LogError { get; set; }
        public DateTime LogDate { get; set; }
        public string LogUser { get; set; }

    }
}
