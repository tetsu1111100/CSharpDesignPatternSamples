
using CSharpDesignPatternSamples.DesignPatterns.AdapterPattern;
using CSharpDesignPatternSamples.DesignPatterns.CommandPattern;
using CSharpDesignPatternSamples.DesignPatterns.CompositePattern;
using CSharpDesignPatternSamples.DesignPatterns.DecoratorPattern;
using CSharpDesignPatternSamples.DesignPatterns.FacadePattern;
using CSharpDesignPatternSamples.DesignPatterns.FactoryPattern;
using CSharpDesignPatternSamples.DesignPatterns.IteratorPattern;
using CSharpDesignPatternSamples.DesignPatterns.ObserverPattern;
using CSharpDesignPatternSamples.DesignPatterns.ProxyPattern;
using CSharpDesignPatternSamples.DesignPatterns.SingletonPattern;

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


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("門面模式");

//門面模式: 提供一個統一的介面來訪問子系統中的一組介面
FacadePatternSample facadePatternSample = new FacadePatternSample();
facadePatternSample.Run();


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("工廠模式");

//工廠模式: 創建物件的工廠
FactoryPatternSample factoryPatternSample = new FactoryPatternSample();
factoryPatternSample.Run();


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("迭代器模式");

//迭代器模式: 提供一種方法來順序訪問集合中的元素，而不暴露集合的底層表示
IteratorPatternSample iteratorPatternSample = new IteratorPatternSample();
iteratorPatternSample.Run();


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("觀察者模式");

//觀察者模式: 讓你的物件掌握現況
ObserverPatternSample observerPatternSample = new ObserverPatternSample();
observerPatternSample.Run1();
Console.WriteLine("---------------");
observerPatternSample.Run2();


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("代理模式");

//代理模式: 為其他物件提供一個代理以控制對這個物件的存取
ProxyPatternSample proxyPatternSample = new ProxyPatternSample();
proxyPatternSample.Run();


Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("單例模式");

//單例模式: 獨一無二的物件(確保一個類別只有一個實例，並提供全域存取點)
SingletonPatternSample singletonPatternSample = new SingletonPatternSample();
singletonPatternSample.Run1();   //懶漢式 (Lazy Initialization)
Console.WriteLine("---------------");
singletonPatternSample.Run2();   //餓漢式 (Eager Initialization)







