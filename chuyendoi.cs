using System;
class HelloWorld {
  static void Main() {
    //khai bao n la so dola chuyen sang VND
    float n;
    Console.WriteLine("nhap n dola");
    n = float.Parse(Console.ReadLine());
    Console.WriteLine("so tien tu dola sang VND la: ");
    Console.WriteLine(n*23000 + "VND");
  }
}