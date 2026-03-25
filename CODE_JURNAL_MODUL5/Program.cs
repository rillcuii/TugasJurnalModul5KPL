using System;
using System.Collections.Generic;

// ===================================================================================
// BAGIAN FUNGSI UTAMA (MAIN)
// ===================================================================================

// 1. Implementasi Generic Method (Tugas Nomor 4)
Penjumlahan p = new Penjumlahan();
// NIM berakhiran 1, maka menggunakan tipe data float (Instruksi 4E.i)
// Mengambil 3 pasang angka dari NIM: 10, 30, dan 82
p.JumlahTigaAngka<float>(10f, 30f, 82f);

Console.WriteLine(); // Baris baru agar output rapi

// 2. Implementasi Generic Class (Tugas Nomor 6)
SimpleDataBase<float> db = new SimpleDataBase<float>();
// Menambahkan tiga data bertipe float ke database (Instruksi 6D)
db.AddNewData(10f);
db.AddNewData(30f);
db.AddNewData(82f);
// Menampilkan seluruh data beserta waktu simpan (Instruksi 6C.iii)
db.PrintAllData();


// ===================================================================================
// DEFINISI CLASS PENJUMLAHAN (TUGAS NOMOR 4)
// ===================================================================================
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