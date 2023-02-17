using System;

namespace ConsoleApp1
{
    // Membuat Class dengan Nama Aplikasi
    class Aplikasi
    {
        // Membuat Fungsi Untuk Menentukan Posisi Lantai Berdasarkan Nomor Loker
        static void Main(string[] args)
        {
            // Input Nomor Loker
            Console.Write("Masukan Nomor Loker :");
            // Masukan Input ke dalam variable string dengan nama nomorLoker
            string nomorLoker = Console.ReadLine();
            // Membuat Urutan Kapasitas Masing-Masing Lantai 
            int [] urutanKapasitas = {5,6,7};
            // Merubah Input Nomor Loker dari String Menjadi Tipe Data Integer
            int _noLoker = Int32.Parse(nomorLoker);
            // Setting default Posisi Lantai
            int lantai = 0;
            // Membuat Perulangan Berjangkar
            // Apabila nilai index < 3 dan nilai _noLoker > 0 maka perulangan akan terus terjadi
            for (int i = 0; i < urutanKapasitas.Length && _noLoker > 0; i++)
            {
                if (_noLoker > 0)
                {
                    // indexKapasitas = urutankapasitas[sesuai nilai index] -> {5,6,7) / i[0]=5, i[1]=6, i[2]=7
                    int indexKapasitas = urutanKapasitas[i];
                    // Jumlah Nomor Loker dikurangi indexKapasitas
                    _noLoker = _noLoker - indexKapasitas;
                    // Iterasi menambahkan posisi lantai berada
                    lantai = lantai + 1;

                    
                    if (_noLoker > 0)
                    {
                        // Jika nilai index sama dengan 2 maka reset nilai index menjadi -1
                        if (i == urutanKapasitas.Length - 1)
                            i = -1;
                        else
                            continue;
                        
                    }
                    // Jika Nilai _noLoker dibawah 0 maka Hentikan Program
                    else
                        break;
                }
            }
            // Tampilkan Output yang menampilkan Nomor Loker Yang dimasukan, dan dimana posisi lantainya berada.
            Console.WriteLine("Loker nomor "+ nomorLoker + " ada di lantai " + lantai);

        }

    }
}// Salman Alfarisi | Linkedin : Linkedin.com/salman-alfarisi-purwakarta/