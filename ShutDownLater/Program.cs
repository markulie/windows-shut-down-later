//ShutDownLater
//Version: 0.3
//Author: Markulie
//Created: April 21, 2015
//Updated: August 21, 2022

using System.Diagnostics;

Console.WriteLine("╔╔══════════════════════╗╗ ShutDownLater v0.3");
Thread.Sleep(10);
Console.WriteLine("║║▐█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▌║║    by Markulie");
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
TimeSpan timeSpan = shutDownTime - DateTime.Now;

Console.WriteLine("");

while (timeSpan > TimeSpan.Zero)
{
    ClearCurrentConsoleLine();
    timeSpan = shutDownTime - DateTime.Now;
    Console.Write(" " + timeSpan.Hours + " hours " + timeSpan.Minutes + " minutes " + timeSpan.Seconds + " seconds ");
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