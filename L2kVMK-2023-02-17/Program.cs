// See https://aka.ms/new-console-template for more information

using L2kVMK_2023_02_17;

MyClass mc1 = new MyClass(3, 6, 9);
mc1.Calc();
Console.WriteLine(mc1);

FlagEnum fe = FlagEnum.One | FlagEnum.Two;
Console.WriteLine(fe);

List<MyClass> mcl = new ();
mcl.Add(mc1);
mcl.Add(new MyClass());
mcl.Remove(mc1);
mcl.RemoveAt(0);