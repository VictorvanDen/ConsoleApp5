

using ConsoleApp5;
//using System; дз: сделать два класса: паспорт и человек, у человека может быть "свой паспорт"
                //в своем паспорте объект "человек" "может увидеть все данные", в чужом нет
                //в своем паспорте человек может изменить имя, но оно не должно содержать число 1
                //задача реализовать это.

//pelmeshka PlusP(pelmeshka a1, pelmeshka a2)
//{
//    a1.dolya_myasa += a2.dolya_myasa;
//    a1.kg += a2.kg;
//    a1.name += a2.name;
//    return a1;
//}
//void PrintP(pelmeshka a1)
//{
//    Console.WriteLine(a1.dolya_myasa+ " " + a1.kg+ " " + a1.name);
//}

Console.WriteLine("Hello, World!");
pelmeshka P1 = new pelmeshka(1, 2, "u");
pelmeshka P2 = new pelmeshka(1, 2, "y");
double o = P1.getKg();
P1.Plus(P2);
Console.WriteLine(P1.Print());
//P1 = P1 + P2;
//P1 = PlusP(P1, P2);
//PrintP(P1);
//List<int> o= new List<int>();
//o.Add(1);