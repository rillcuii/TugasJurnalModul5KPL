using System;
using System.Collections.Generic;

Penjumlahan jumlahkan = new Penjumlahan();

jumlahkan.JumlahTigaAngka<float>(10f, 30f, 82f);

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;

        Console.WriteLine(a + b + c);
    }
}