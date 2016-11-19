using System;
using System.Timers;

public class PomodoroTimer
{
	private static System.Timers.Timer myTimer;
	public static void Main()
	{
		SetTimer();
		Console.WriteLine("\nPress the Enter key to exit the application...\n");
		Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
		Console.ReadLine();
		myTimer.Stop();
		myTimer.Dispose();

	}

	private static void SetTimer()
	{
		//Creating a timer with 25 minutes(1500000 miliseconds) interval
		Console.WriteLine("Its time to start work");
		myTimer = new System.Timers.Timer(1500000);
		myTimer.Elapsed += OnTimedEvent;
		myTimer.AutoReset = true;
		myTimer.Enabled = true;


	}
	private static void BreakTimer()
	{
		//Creating a timer with five minutes interval
		Console.WriteLine("Your break has begun");
		myTimer = new System.Timers.Timer(300000);
		myTimer.Elapsed += OnTimedEvent;
		myTimer.AutoReset = true;
		myTimer.Enabled = true;



	}
	private static void OnTimedEvent(Object source, ElapsedEventArgs e)
	{
		Console.WriteLine("The elapsed event {0:HH:mm:ss.fff}", e.SignalTime);
		BreakTimer();



	}
}