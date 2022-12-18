using SciarraCaves.Storage.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciarraCaves.Storage.Models
{
    public class Account : Entity
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime DeletionDate { get; set; }
    }
}
