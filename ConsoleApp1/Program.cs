﻿using System.Reflection;

Assembly? myApp = Assembly.GetEntryAssembly();

if(myApp == null) return;

foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);
    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    double heightInMetres = 1.33;
    Console.WriteLine($"The var {nameof(heightInMetres)} has the value {heightInMetres}.");
    
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}