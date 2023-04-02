using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.tasks;

namespace tpmodul7_kelompok_09
{
    internal class DataMahasiswa_1302210105
    {
        public string nim { get; set; }
        public string fakultas { get; set; }
        public NamaLengkap nama { get; set; }
        public DataMahasiswa_1302210105() { }
        public DataMahasiswa_1302210105(string nim, string fakultas, NamaLengkap nama)
        {
            this.nim = nim;
            this.fakultas = fakultas;
            this.nama = nama;
        }
        public class NamaLengkap
        {
            public string depan { get; set; }
            public string belakang { get; set; }
            public NamaLengkap() { }
            public NamaLengkap(string depan, string belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }
    }
}
