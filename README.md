Simplified Configuration for C#
===============================

A C# class for clean and error-free reading of config file app settings. Donwload and include the classes in any Web/Windows/Console 
project and then you can read your configuration as follows-

public static readonly int IntValue = appConfiguration.GetValueAsInt32(()=>IntValue);

It uses name of the peoperty as the name of app setting key in the config file. If you have your app setting name different
than name of the property, you can use the provided overload that expects a key.

Download the code and give it a try. Also included is a sample console application that uses this library to demonstrate its use.

