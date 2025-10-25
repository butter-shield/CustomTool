using System;
using System.Diagnostics;
using System.Reflection;

public class Program{

    public static void Main(){
        Console.WriteLine("Hello, World!");
        Debug.WriteLine("Hello From Debug");

        var tick = 0;
        var stillRunning = true;

        do{
            if(tick == 100)
            {
                stillRunning = false
                Debug.WriteLine("Still running");
            }
            else{
                Debug.WriteLine("Stopped");
            }

        }
        while(stillRunning);
    }
}



