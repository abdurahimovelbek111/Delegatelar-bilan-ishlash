// See https://aka.ms/new-console-template for more information
using Delegatelar_bilan_ishlash;
mbox:
Console.WriteLine("Kiritayotgan pul miqdoriz dollor bulsa 0, so'm bo'lsa 1 kiriting :");
int val=int.Parse(Console.ReadLine());
switch (val)
{
    case 0:
        Console.WriteLine("Pul miqdorini kiriting : ");
        int miqdori = int.Parse(Console.ReadLine());
        Pul pul = new Pul(miqdori);
        PulBoshqaruvchisi boshqaruvchisi = new PulBoshqaruvchisi();
        Pul.PulDelegate @delegate = new Pul.PulDelegate(boshqaruvchisi.Usd2Uzb);
        boshqaruvchisi.Pul_Yuborish(pul, "Ipoteka", @delegate);
        break;
        case 1:
        Console.WriteLine("Pul miqdorini kiriting : ");
        int miqdori2 = int.Parse(Console.ReadLine());
        Pul pul2 = new Pul(miqdori2);
        PulBoshqaruvchisi boshqaruvchisi2 = new PulBoshqaruvchisi();
        Pul.PulDelegate @delegate2 = new Pul.PulDelegate(boshqaruvchisi2.Uzb2usd);
        @delegate = boshqaruvchisi2.Uzb2usd;
        boshqaruvchisi2.Pul_Olish(pul2, "Xalq", @delegate2);
        break;
    default:
        Console.WriteLine("Bunday valyuta turi yo'q .\n" +
            "Iltimos qayrtadan kiriting!!");
        goto mbox;
        break;
}

