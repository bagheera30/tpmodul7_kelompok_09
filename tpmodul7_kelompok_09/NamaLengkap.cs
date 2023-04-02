using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_09
{
    internal class NamaLengkap
    {
        public string depan { get; set; }
        public string belakang { get; set; }
        public NamaLengkap(string depan, string belakang) { 
            this.depan = depan;
            this.belakang = belakang;
        }
    }
}
