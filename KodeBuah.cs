namespace modul3_1302204035;

public class KodeBuah
{
    /*public enum Kode {
        A00, B00, C00, D00, E00, F00, G00, H00, I00, J00, K00, L00, M00, N00, O00
    }*/

    public enum Nama
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
    }
    
    public string getKodeBuah(Nama inputNama)
    {
        string[] kodeBuah = new string[15];
        kodeBuah[0] = "A00";
        kodeBuah[1] = "B00";
        kodeBuah[2] = "C00";
        kodeBuah[3] = "D00";
        kodeBuah[4] = "E00";
        kodeBuah[5] = "F00";
        kodeBuah[6] = "G00";
        kodeBuah[7] = "H00";
        kodeBuah[8] = "I00";
        kodeBuah[9] = "J00";
        kodeBuah[10] = "K00";
        kodeBuah[11] = "L00";
        kodeBuah[12] = "M00";
        kodeBuah[13] = "N00";
        kodeBuah[14] = "O00";
        
        return kodeBuah[(int)inputNama];
    }
}