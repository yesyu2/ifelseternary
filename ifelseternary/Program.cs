int time = DateTime.Now.Hour;
if (time>6 && time<11)
    Console.WriteLine("Good Morning!");
else if (time<=18)
    Console.WriteLine("İyi günler!");
else
    Console.WriteLine("Good Night!)");

string sonuc = time<=18 ? "Have a nice day!" : "Good Night!";
Console.WriteLine(sonuc);

sonuc = time>=6 && time<11 ? "Good Morning!": time <= 18 ? "Have a nice day" : "Good Night!";
Console.WriteLine(sonuc);