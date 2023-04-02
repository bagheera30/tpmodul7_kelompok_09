// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using tpmodul7_kelompok_09;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302210105 data = new DataMahasiswa_1302210105();
        String jsonString = File.ReadAllText("..\\..\\..\\tp7_1_1302210105.json");
        DataMahasiswa_1302210105 mhs = JsonSerializer.Deserialize<DataMahasiswa_1302210105>(jsonString);
        Console.WriteLine("Nama: " + mhs.nama.depan + " " + mhs.nama.belakang + " dengan nim  " + mhs.nim + " dari fakultas " + mhs.fakultas);
        String jsonString2 = File.ReadAllText("..\\..\\..\\tp7_2_1302210105.json");
        KuliahMahasiswa_1302210105 kuliah = JsonSerializer.Deserialize<KuliahMahasiswa_1302210105>(jsonString2);
        if (kuliah.matkul != null)
        {
            int i = 1;
            foreach (MataKuliah_1302210105 matkul in kuliah.matkul)
            {
                Console.WriteLine("MK " + (i) + " " + matkul.kode + " - " + matkul.nama);
                i++;
            }
        }
    }

}