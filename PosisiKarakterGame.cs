namespace modul3_1302204035;

public class PosisiKarakterGame
{
    public enum posisiKarakter
    {
        Berdiri, Terbang, Tengkurap, Jongkok
    }

    public enum button
    {
        TombolW, TombolS, TombolX
    }
    
    //NIM = 1302204035 mod 3 = 2

    public class transisiPosisi
    {
        public posisiKarakter stateAwal;
        public posisiKarakter stateAkhir;
        public button tombol;
        
        public transisiPosisi(posisiKarakter stateAwal, posisiKarakter stateAkhir, button tombol)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.tombol = tombol;
        }
    }

    transisiPosisi[] listTransisi =
    {
        new transisiPosisi(posisiKarakter.Berdiri, posisiKarakter.Terbang, button.TombolW), //soal 2 mod nim 
        new transisiPosisi(posisiKarakter.Terbang, posisiKarakter.Berdiri, button.TombolS),
        new transisiPosisi(posisiKarakter.Terbang, posisiKarakter.Jongkok, button.TombolX), //soal 1 mod nim
        new transisiPosisi(posisiKarakter.Jongkok, posisiKarakter.Tengkurap, button.TombolS),
        new transisiPosisi(posisiKarakter.Tengkurap, posisiKarakter.Jongkok, button.TombolW),
        new transisiPosisi(posisiKarakter.Jongkok, posisiKarakter.Berdiri, button.TombolW)
    };
    
    public posisiKarakter stateSekarang = posisiKarakter.Berdiri; //Asumsi awal karakter berdiri

    public posisiKarakter stateAkhir(posisiKarakter stateAwal, button tombol)
    {
        posisiKarakter stateAkhir = stateAwal;
        foreach (transisiPosisi t in listTransisi)
        {
            if (t.stateAwal == stateAwal && t.tombol == tombol)
            {
                stateAkhir = t.stateAkhir;
            }
        }
        return stateAkhir;
    }
    
    public void tombolDitekan(button tombol)
    {
        stateSekarang = stateAkhir(stateSekarang, tombol);
        //Console.WriteLine("State Sekarang : " + stateSekarang);
        if (stateSekarang == posisiKarakter.Terbang)
        {
            Console.WriteLine("posisi take off");
        }

        if (stateSekarang == posisiKarakter.Jongkok)
        {
            Console.WriteLine("Posisi landing");
        }
    }
    public PosisiKarakterGame()
    {
    }
}