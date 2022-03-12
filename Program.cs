using modul3_1302204035;

Console.WriteLine("Hello, World!");
KodeBuah obj = new KodeBuah();
KodeBuah.Nama inputNama = KodeBuah.Nama.Alpukat;
Console.WriteLine("Nama Buah : "+ inputNama + "\nKode Buah : " + obj.getKodeBuah(inputNama) + "\n"); //GetKodeBuah
PosisiKarakterGame obj1 = new PosisiKarakterGame();
Console.WriteLine(obj1.stateSekarang);
obj1.tombolDitekan(PosisiKarakterGame.button.TombolW); //SOAL 2
obj1.tombolDitekan(PosisiKarakterGame.button.TombolX); //SOAL 1