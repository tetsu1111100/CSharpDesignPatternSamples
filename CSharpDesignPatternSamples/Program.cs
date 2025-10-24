
using CSharpDesignPatternSamples.DesignPatterns.AdapterPattern;
using CSharpDesignPatternSamples.DesignPatterns.CommandPattern;
using CSharpDesignPatternSamples.DesignPatterns.CompositePattern;
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern;

Console.WriteLine("C# 設計模式範例");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("===========================================================");
Console.WriteLine("轉接器模式");

//轉接器模式: 將一個類別的介面轉換成客戶端所期望的另一個介面
AdapterPatternSample adaperPatternSample = new AdapterPatternSample();
adaperPatternSample.Run();


Console.WriteLine();
Console.WriteLine("===========================================================");
Console.WriteLine("命令模式");

//命令模式: 封裝呼叫
CommandPatternSample commandPatternSample = new CommandPatternSample();
commandPatternSample.Run();


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("組合模式");

//組合模式
CompositePatternSample compositePatternSample = new CompositePatternSample();
compositePatternSample.Run();


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("裝飾器模式");

//裝飾器模式: 裝飾物件
DecoratorPatternSample decoratorPatternSample = new DecoratorPatternSample();
decoratorPatternSample.Run();









