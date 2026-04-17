// See https://aka.ms/new-console-template for more information

//In các số nguyên từ 1 đến 100 ra màn hình.
for (int i =0; i < 100; i++)
{
    Console.WriteLine(i);
}
//In các số chẵn trong khoảng từ 1 đến n (với n nhập từ bàn phím).
Console.WriteLine("Nhap so: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
//Tính tổng các số từ 1 đến n.
Console.WriteLine("Nhap so: ");
int n1 = int.Parse(Console.ReadLine());
int tong = 0;
for (int i = 1; i < n1; i++)
{
    tong += i;
}
Console.WriteLine(tong);
//In bảng cửu chương của một số bất kỳ nhập từ bàn phím.
Console.WriteLine("Nhap so: ");
int n2 = int.Parse(Console.ReadLine());
int table;
for (int i = 0; i < 10; i++)
{
    table = n2 * i;
    Console.WriteLine(n2 + "x" + i + "=" + table);
}
//Tính giai thừa. Nhập số nguyên $n$, tính $n! = 1 \times 2 \times 3 \times ... \times n$.
Console.WriteLine("Nhap so: ");
int n3 = int.Parse(Console.ReadLine());
int kq = 1;
for (int i = 1; i <= n3; i++)
{
    kq *= i;
    Console.WriteLine(kq);
}
//Tính tổng phân số. Tính giá trị của biểu thức:
Console.WriteLine("Nhap so: ");
int n4 = int.Parse(Console.ReadLine());
double sum = 0;
for (int i = 1; i < n4; i++)
{ 
    sum += 1.0/i;
}
Console.WriteLine(sum);

//Vẽ hình chữ nhật đặc kích thước $m \times n$
Console.WriteLine("Nhap so m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Nhap so n6: ");
int n6 = int.Parse(Console.ReadLine());
for (int i = 0; i <= m; i++)
{
    for (int j = 0; j <= n6; j++)
    {
        Console.Write("$");
    }
    Console.WriteLine();
}

//Vẽ tam giác vuông cân có độ cao $h$.
Console.WriteLine("Nhap so h: ");
int h = int.Parse(Console.ReadLine());
for (int i = 0; i <= h; i++)
{
    for (int j1 = 0; j1 <= i; j1++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}