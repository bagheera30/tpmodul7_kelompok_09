using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_09
{
    public class KuliahMahasiswa_1302210105
    {
        public List<MataKuliah_1302210105> matkul { get; set; }
        public KuliahMahasiswa_1302210105(List<MataKuliah_1302210105> matkul)
        {
            this.matkul = matkul;
        }
        public KuliahMahasiswa_1302210105()
        {
        }
    }
    public class MataKuliah_1302210105
    {
        public string kode { get; set; }
        public string nama { get; set; }
        public MataKuliah_1302210105(string kodeX, string namaX)
        {
            kode = kodeX;
            nama = namaX;
        }
        public MataKuliah_1302210105() { }
    }
}