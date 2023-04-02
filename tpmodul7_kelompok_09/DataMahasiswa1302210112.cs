using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace tpmodul7_kelompok_09
{
    internal class DataMahasiswa1302210112
    {
        public NamaLengkap nama { get; set; }
        public string namaBelakang { get; set; }
        public int nim { get; set; }
        public string falkutas { get; set; }
        public DataMahasiswa1302210112() { }
        public DataMahasiswa1302210112(NamaLengkap nama,int nim,string falkutas)
        {
            this.nama = nama;
            this.nim = nim;
            this.falkutas = falkutas;
        }
        public void readJson()
        {
            string file = "C:\\Users\\asus\\Documents\\latihan\\tpkpl\\tpmodul7_kelompok_09\\tpmodul7_kelompok_09\\tp7_1_1302210112.json";
            string JsonString = File.ReadAllText(file);
            DataMahasiswa1302210112 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302210112>(JsonString);
            Console.WriteLine($"Nama {mahasiswa.nama.depan + " " + mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari Fakultas {mahasiswa.falkutas}");

        }

    }
}
