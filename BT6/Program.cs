//Yêu cầu: Viết chương trình yêu cầu người dùng nhập vào một số nguyên dương n. Sử dụng vòng lặp while để in ra màn hình các số từ 1 đến n.

using System.Runtime.CompilerServices;

int i = 1;
Console.WriteLine("Nhap so nguyen duong: ");
int n = int.Parse(Console.ReadLine());
while (i <= n)
{
    Console.WriteLine(i);
    i++;
}
//Yêu cầu: Sử dụng vòng lặp while để tính và in ra tổng của tất cả các số chẵn trong khoảng từ 1 đến 100.
int i1 = 2;
int sum1 = 0;
while (i1 <= 100)
{
    sum1 += i1;
    i1 += 2;
    Console.WriteLine(sum1);
}
//Yêu cầu: Viết chương trình yêu cầu người dùng nhập vào một số điểm hợp lệ (từ 0 đến 10).
//Sử dụng vòng lặp do...while để lặp lại việc yêu cầu nhập nếu người dùng nhập sai (nhỏ hơn 0 hoặc lớn hơn 10).
int i2 = 0;
do
{
    Console.WriteLine("Nhap so (0-10): ");
    i2 = int.Parse(Console.ReadLine());
} while (i2 < 0 || i2 > 10);
Console.WriteLine("Nhap Thanh Cong So: " + i2);

// Nhập vào một số nguyên dương n. Sử dụng vòng lặp while để đếm xem số đó có bao nhiêu chữ số.
int i3 = 0;
while (i3 <= 0)
{
    Console.WriteLine("Nhap so > 0: ");
    i3 = int.Parse(Console.ReadLine());
}
int count = 0;
while (i3 > 0)
{
    i3 /= 10;
    count++;
}
Console.WriteLine("So co: " + count + " chu so"); 

//Nhập vào một số nguyên dương. Tìm và in ra số đảo ngược của số đó bằng vòng lặp while.
int n1 = 0;
int sodu;
int sodaonguoc = 0;
while (n1 <= 0)
{
    Console.WriteLine("Nhap so nguyen duong: ");
    n1 = int.Parse(Console.ReadLine());
}

while (n1 > 0)
{
    sodu = n1 % 10;
    n1 = n1 / 10;
    sodaonguoc = sodaonguoc * 10 + sodu;
}
Console.Write(sodaonguoc);

//Chương trình sẽ tạo ra một số ngẫu nhiên từ 1 đến 100.
//Cho người dùng đoán số. Nếu đoán nhỏ hơn kết quả, in ra "Quá thấp!".
//Nếu đoán lớn hơn kết quả, in ra "Quá cao!".
//Vòng lặp kết thúc khi người dùng đoán đúng. 
int random = 55;
int guess = 0;
while (guess < 1 || guess > 100)
{
    Console.WriteLine("Doan so tu 1-100: ");
    guess = int.Parse(Console.ReadLine());
}

do
{
    Console.WriteLine("Nhap lai: ");
    guess = int.Parse(Console.ReadLine());
    if (guess < random)
    {
        Console.WriteLine("Qua Thap!");
    }

    if (guess > random)
    {
        Console.WriteLine("Qua Cao!");
    }
} while (guess != random);
if (guess == random)
{
    Console.WriteLine("Dung roi!");
}

//Nhập vào hai số nguyên dương a và b.
//Sử dụng thuật toán Euclid và vòng lặp while để tìm UCLN của hai số đó.
int a = -1;
int b = -1;
int r;
while (a < 0 || b < 0)
{
    Console.WriteLine("Nhap so nguyen duong a: ");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap so nguyen duong b: ");
    b = int.Parse(Console.ReadLine());
}

while (a > 0 && b > 0)
{
    r = a % b;
    a = b;
    b = r;
    if (b == 0)
    {
        break;
    }
}
Console.WriteLine("UCLN la: " + a);

//Nhập vào một số nguyên dương n > 1. Sử dụng vòng lặp while để phân tích n thành tích của các thừa số nguyên tố.
int n2 = 0;
int j = 2;
while (n2 <= 0)
{
    Console.WriteLine("Nhap so nguyen duong: ");
    n2 = int.Parse(Console.ReadLine());
}

while (n2 > 1)
{
    if (n2 % j == 0)
    {
        Console.Write(j + " ");
        n2 = n2 / j;
    }
    else
    {
        j++;
    }
}

//Dãy Fibonacci là dãy bắt đầu bằng 0, 1, và mỗi số phần tử tiếp theo bằng tổng 2 số liền trước nó (0, 1, 1, 2, 3, 5, 8...).
//Yêu cầu người dùng nhập vào số Max. In ra các số trong dãy Fibonacci sao cho các số này không vượt quá Max.
int x = 0;
int y = 1;
int z = x + y;
int max = 0;
while (max <= 0)
{
    Console.WriteLine("Nhap so > 0: ");
    max = int.Parse(Console.ReadLine());
}

while (x < max)
{
        Console.Write(x + " ");
        z = x + y;
        x = y;
        y = z;
}

//Viết một chương trình hiển thị menu cho người dùng.
//Sử dụng do...while để giữ chương trình chạy cho đến khi người dùng chọn "Thoát". Kết hợp với lệnh switch...case.
//Tính diện tích hình chữ nhật
//Tính diện tích hình tròn
//Thoát
int choice = 0;
do
{
    Console.WriteLine("Chon mot chuc nang");
    Console.WriteLine("1. Tinh Dien Tich Hinh CN");
    Console.WriteLine("2. Tinh Dien Tich Hinh Tron");
    Console.WriteLine("3. Thoat");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
        {
            int choice1 = 0;
            do
            {
                Console.WriteLine("1.Tiep tuc");
                Console.WriteLine("2.Thoat Ve Menu");
                choice1 = int.Parse(Console.ReadLine());
                if (choice1 == 1)
                {
                    Console.WriteLine("Nhap chieu dai: ");
                    double dai = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Nhap Chieu Rong: ");
                    double rong = Convert.ToDouble(Console.ReadLine());
                    double Scn = dai * rong;
                    Console.WriteLine("Dien tich = " + Scn.ToString("F2"));
                }
            } while (choice1 != 2);

            break;
        }
        case 2:
        {
            int choice2 = 0;
            do
            {
                Console.WriteLine("1.Tiep tuc");
                Console.WriteLine("2.Thoat Ve Menu");
                choice2 = int.Parse(Console.ReadLine());
                if (choice2 == 1)
                {
                    Console.WriteLine("Nhap ban kinh: ");
                    double r1 = Convert.ToDouble(Console.ReadLine());
                    double Stron = 3.14 * (r1 * r1);
                    Console.WriteLine("Dien tich = " + Stron.ToString("F2"));
                }
            } while (choice2 != 2);
        }
            break;
        case 3:
        {
            Console.WriteLine("Ban Da Thoat");
        }
            break;
    }
} while (choice != 3);
