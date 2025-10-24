
using CSharpDesignPatternSamples.DesignPatterns.AdapterPattern;
using CSharpDesignPatternSamples.DesignPatterns.CommandPattern;
using CSharpDesignPatternSamples.DesignPatterns.CompositePattern;

Console.WriteLine("C# 設計模式範例");
Console.WriteLine();

Console.WriteLine("轉接器模式===========================================================");
Console.WriteLine();

//轉接器模式: 將一個類別的介面轉換成客戶端所期望的另一個介面
AdapterPatternSample adaperPatternSample = new AdapterPatternSample();
adaperPatternSample.Run();


Console.WriteLine("命令模式===========================================================");
Console.WriteLine();

//命令模式: 封裝呼叫
CommandPatternSample commandPatternSample = new CommandPatternSample();
commandPatternSample.Run();


Console.WriteLine("組合模式==========================================================");
Console.WriteLine();

//組合模式
CompositePatternSample compositePatternSample = new CompositePatternSample();
compositePatternSample.Run();













