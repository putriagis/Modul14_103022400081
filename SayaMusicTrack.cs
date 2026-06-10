using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Modul14_103022400081
{
    internal class SayaMusicTrack
    {
        private int trackId;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            //Memastikan judul lagu valid dan tidak kosong sebelum digunakan
            Debug.Assert(title != null, "judul tidak boleh null");
            Debug.Assert(title.Length <= 100, "Judul Maksimal 100 Karakter");
           

            Random angkaRandom = new Random();
            this.trackId = angkaRandom.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        //Menambahkan method jumlah pemutaran lagu
        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Play Count maksimal 10.000.000");

            //melakukan pengecekan terkait jumlah pemutaran lagu
            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi Overflow");
            }
        }
        //menambahkan method untuk menampilkan informasi lagu
        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {trackId}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}