// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Mime;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;


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

class SimpleDataBase<T> { 
    private List<T> storedData ;
    private List<DateTime> inputDates;

    public SimpleDataBase() {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public T AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
        return data;
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data : " + storedData[i] + "\nDate : " + inputDates[i] + "\n") ;
        }
    }
}

class program {
    public static void Main(string[] args)
    {
        PemrosesanData data = new PemrosesanData();
        long terbesar = data.DapatkanNilaiTerbesar<long>(10, 20, 30);
        Console.WriteLine("Nilai terbesar adalah : " + terbesar);

        Console.WriteLine(" ");

        SimpleDataBase<long> dataBase = new SimpleDataBase<long>();
        dataBase.AddNewData(10);
        dataBase.AddNewData(34);
        dataBase.AddNewData(56);
        dataBase.PrintAllData();
    }
}

