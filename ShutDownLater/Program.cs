//ShutDownLater
//Version: 0.3
//Author: Markaelie
//Created: April 21, 2015
//Updated: August 21, 2022

using System.Diagnostics;

Console.WriteLine("╔╔══════════════════════╗╗ ShutDownLater v0.3");
Thread.Sleep(10);
Console.WriteLine("║║▐█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▌║║    by Markaelie");
Thread.Sleep(10);
Console.WriteLine("║║▐▌░░▒▒░░▒▒░░▒▒░░▒▒░░▐▌║║");
Thread.Sleep(10);
Console.WriteLine("║║▐▌▒▒░░▒▒░░▒▒░░▒▒░░▒▒▐▌║║");
Thread.Sleep(10);
Console.WriteLine("║║▐▌▒▒░░▒▒░░▒▒░░▒▒░░▒▒▐▌║║");
Thread.Sleep(10);
Console.WriteLine("║║▐▌░░▒▒░░▒▒░░▒▒░░▒▒░░▐▌║║");
Thread.Sleep(10);
Console.WriteLine("║║▐▌▒▒░░▒▒░░▒▒░░▒▒░░▒▒▐▌║║");
Thread.Sleep(10);
Console.WriteLine("║║▐▌░░▒▒░░▒▒░░▒▒░░▒▒░░▐▌║║");
Thread.Sleep(10);
Console.WriteLine("║║▐█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█▌║║");
Thread.Sleep(10);
Console.WriteLine("╚╚══════════════════════╝╝");
Thread.Sleep(10);
Console.WriteLine("██▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄██");
Thread.Sleep(10);
Console.WriteLine("██▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄██");
Thread.Sleep(10);
Console.WriteLine("██▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄██");
Thread.Sleep(10);
Console.WriteLine("██▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██");
Thread.Sleep(10);
Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");

Console.Write(" Write shut down time in minutes: ");

short minutes = Convert.ToInt16(Console.ReadLine());
DateTime shutDownTime = DateTime.Now.AddMinutes(minutes);
TimeSpan ts = shutDownTime - DateTime.Now;

Console.WriteLine("");

while (ts > TimeSpan.Zero)
{
    ClearCurrentConsoleLine();
    ts = shutDownTime - DateTime.Now;
    Console.Write(" " + ts.Hours + " hours " + ts.Minutes + " minutes " + ts.Seconds + " seconds ");
    Thread.Sleep(500);
    if (shutDownTime < DateTime.Now) Process.Start("shutdown.exe", "-h");
}

static void ClearCurrentConsoleLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    for (int i = 0; i < Console.WindowWidth; i++) Console.Write(" ");
    Console.SetCursorPosition(0, currentLineCursor);
}