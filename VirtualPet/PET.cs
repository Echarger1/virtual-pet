using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PET
    {
        public string PetName { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Play { get; set; }
        public long Ticks { get; }
    }
}
