using modul3_1302204035;

Console.WriteLine("Hello, World!");
KodeBuah obj = new KodeBuah();
KodeBuah.Nama inputNama = KodeBuah.Nama.Alpukat;
Console.WriteLine("Nama Buah : "+ inputNama + "\nKode Buah : " + obj.getKodeBuah(inputNama));