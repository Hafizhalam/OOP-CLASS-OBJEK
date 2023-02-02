using apa;

Kalkulator hitung = new Kalkulator();

// hitung.tambah();
// hitung.kurang();

Console.Write("masukan alas : ");
int a = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan tinggi : ");
int t = Convert.ToInt32( Console.ReadLine() );

Rumus rumus = new Rumus();
int luas = rumus.jajargenjang (a,t);

Console.WriteLine($"luas jajargenjang dengan a ={a} dan t={t} adalah {luas}");
