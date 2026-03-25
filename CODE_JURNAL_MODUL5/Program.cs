using System;
using System.Collections.Generic;

Penjumlahan p = new Penjumlahan();
p.JumlahTigaAngka<float>(10f, 30f, 82f);

Console.WriteLine(); 

SimpleDataBase<float> db = new SimpleDataBase<float>();
db.AddNewData(10f);
db.AddNewData(30f);
db.AddNewData(82f);
db.PrintAllData();


public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        Console.WriteLine($"Hasil penjumlahan: {a + b + c}");
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu: {inputDates[i]}");
        }
    }
}