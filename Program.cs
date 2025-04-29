using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

public class Program{

    public static void Main(){
        Console.WriteLine("Hello, World!");
        Debug.WriteLine("Hello From Debug");
        var appWindow = new Window2();

appWindow.Show();
    }

    // public void Show(){
    //     Window window = new Window();
    //     window.Show();
    // }
}



