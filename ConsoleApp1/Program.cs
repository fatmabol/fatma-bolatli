using System.ComponentModel.Design;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");
Random rastgele = new Random();
int[] sayilar = new int[10];
for (int i = 0; i < 10; i++)
{
    sayilar[i] = rastgele.Next(1, 100);
    Console.WriteLine(" secılen sayılar   "+ (i+1)+ ".sayı " +sayilar[i].ToString());
}
int c = 0;
int f = 0;

    for (int i = 0; i < 10; i++)


    {

        if (sayilar[i] % 2 == 0)
        {
        c++;

        Console.WriteLine("cift sayı =" + sayilar[i].ToString());
        Console.WriteLine("CİFT SAYI ADEDI:"+ c.ToString());
        }
        else
        {
         f++;
            Console.WriteLine("tek sayı =" + sayilar[i].ToString());
        Console.WriteLine("TEK SAYI ADEDİ:"+f.ToString());
        }
    
}
int enk = sayilar[0];

int enb = sayilar[0];
int enksayi = 0;
int enbsayi = 0;


for (int i = 0; i < 10; i++)

{
    if (sayilar[i] > enb)
    {

        enb = sayilar[i];
        enbsayi = i;
        
    }
    if (sayilar[i] < enk)

    {
        enk = sayilar[i];
        enksayi = i;
    }
}
Console.WriteLine("en buyuk sayı =" + enb.ToString() + "ve bu   " + (enbsayi + 1).ToString() + ".sayı    ");

Console.WriteLine("en kucuk sayı =" + enk.ToString() + "ve bu   " + (enksayi + 1).ToString() + ".sayı    ");


Console.WriteLine("lütfen 1 ıle 100 arası bi sayı giriniz  =");
string sayi = Console.ReadLine();
Console.WriteLine("GİRMİS OLDUGUNUZ SAYI = "+int.Parse(sayi));



int a = int.Parse(sayi);
foreach (int eleman in sayilar)

{
    if (eleman > a)
    {
        Console.WriteLine("buyuk olan sayılar  =" + eleman.ToString());
    }
}






