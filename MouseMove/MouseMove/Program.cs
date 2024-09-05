using System;
using System.Drawing;
using System.Windows.Forms;

static class Program
{
    static void Main()
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        // timer.Interval = 4 minutes
        timer.Interval = (int)(TimeSpan.TicksPerMinute * 10 / TimeSpan.TicksPerMillisecond);
        timer.Tick += (sender, args) => { Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y + 1); };
        timer.Start();
        Application.Run();
    }
}