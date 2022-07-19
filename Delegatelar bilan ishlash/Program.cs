// See https://aka.ms/new-console-template for more information
using Delegatelar_bilan_ishlash;
#region Fayllar bilan ishlash

// Fayl yaratish
/*FileInfo file = new FileInfo(@"C:\Apple.txt");
FileStream stream = file.Create();
Console.WriteLine($"File Creation Time : {file.CreationTime}");*/

//Faylni uchirish
/*FileInfo file = new FileInfo(@"C:\Apple.txt");
file.Delete();
Console.WriteLine($"File Delete : file remove");*/


//Fayllarni diskdan uqish
/*string path = @"C:\Users\Администратор\source\repos\SuniyIntellekt_IAT4\SuniyIntellekt_IAT4\bin\Debug\ABC";
DirectoryInfo directory = new DirectoryInfo(@"C:\");
DirectoryInfo[] dirs = directory.GetDirectories();
Console.WriteLine($"File path : {directory.FullName}\n" +
    $"File Name : {directory.Name}\n" +
    $"File Create Time : {directory.CreationTime}\n" +
    $"File Open Time : {directory.LastAccessTime}\n" +
    $"File folder or file : {directory.Attributes}\n" +
    $"File parent : {directory.Parent}\n" +
    $"File CreationTimeUtc : {directory.CreationTimeUtc}\n" +
    $"File Exists : {directory.Exists}\n" +
    $"File Extension : {directory.Extension}\n" +
    $"File last write time : {directory.LastWriteTime}\n" +
    $"File  : {directory.LastWriteTimeUtc}");
Console.WriteLine("-------------------------------------------------------------------------");
foreach (var item in dirs)
{
    Console.WriteLine($"File path : {item.FullName} || " +
     $"File Name : {item.Name} || " +
     $"File Create Time : {item.CreationTime} || " +
     $"File Open Time : {item.LastAccessTime} || " +
     $"File folder or file : {item.Attributes} || " +
     $"File parent : {item.Parent} || " +
     $"File CreationTimeUtc : {item.CreationTimeUtc} || " +
     $"File Exists : {item.Exists} || " +
     $"File Extension : {item.Extension} || " +
     $"File last write time : {item.LastWriteTime} || File number : {item.ToString().Length} || " +
     $"File  : {item.LastWriteTimeUtc} || File Atrubut : {item.Attributes.ToString()}{Environment.NewLine}");
}
*/
#endregion


#region Eventlar bilan ishlash
/*static void Tugma_Click()
{
    Console.WriteLine("Tugma bosildi");
}
Tugma tugma=new Tugma();
//tugma.Click +=new TugmaDelegate(Tugma_Click);
tugma.Click += Tugma_Click;
tugma.Simulation();
tugma.Click-=new ClicEventHandler(Tugma_Click);*/
#endregion
#region Delegate bilan ishlash
/*mbox:
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
        Console.WriteLine(@delegate.Method.Name);
        break;
        case 1:
        Console.WriteLine("Pul miqdorini kiriting : ");
        int miqdori2 = int.Parse(Console.ReadLine());
        Pul pul2 = new Pul(miqdori2);
        PulBoshqaruvchisi boshqaruvchisi2 = new PulBoshqaruvchisi();
        Pul.PulDelegate @delegate2 = new Pul.PulDelegate(boshqaruvchisi2.Uzb2usd);
        @delegate = boshqaruvchisi2.Uzb2usd;
        boshqaruvchisi2.Pul_Olish(pul2, "Xalq", @delegate2);
        Console.WriteLine(@delegate2.Method.Name);
        break;
    default:
        Console.WriteLine("Bunday valyuta turi yo'q .\n" +
            "Iltimos qayrtadan kiriting!!");
        goto mbox;
        break;
}*/
#endregion