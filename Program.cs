using Modul14_103022400081;

class Program
{
    static void Main(string[] args)
    {
        //MMembuat objek lagu
        SayaMusicTrack musik = new SayaMusicTrack("Never say never");

        //menambahkan jumlah pemutaran lagu
        musik.IncreasePlayCount(10);

        //menampilkan informasi lagu
        musik.PrintTrackDetails();

        for (int i = 0; i < 100; i++)
        {
            musik.IncreasePlayCount(10000000);
        }
    }
}