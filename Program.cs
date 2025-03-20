// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Mime;

public class PemrosesanData {
   

    public T DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
    {
        dynamic n1 = (dynamic)nilai1;
        dynamic n2 = (dynamic)nilai2;
        dynamic n3 = (dynamic)nilai3;
        dynamic highTemp = n1;

        if (n2 > highTemp)
        {
            highTemp = n2;
        }
        if (n3 > highTemp)
        {
            highTemp = n3;
        }


        return highTemp;

    }

}

class program {
    public static void Main(string[] args)
    {
        PemrosesanData data = new PemrosesanData();
        long terbesar = data.DapatkanNilaiTerbesar<long>(10, 20, 30);
        Console.WriteLine("Nilai terbesar adalah : " + terbesar);
    }
}

