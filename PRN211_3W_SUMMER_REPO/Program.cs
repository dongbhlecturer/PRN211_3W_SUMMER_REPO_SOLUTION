//single line comments
/*
    Multi-line
 */
//Import all dependencies 
using System;

namespace Prn3w.Program;
/*
 Viet chuong trinh thuc hien viec:
    - Them vao cac so nguyen,
    - Sap xep tang dan
    - Thay doi gia tri (tang len 10 lan) trong mang theo 1 chi so bat ky
    - Tinh tong cac so chan va so luong cac so le (return dong thoi)
    - Tim kiem va tra ra tat ca cac so nguyen thoa man theo 1 gia tri can tim
    - Them mot so nguyen vao mot vi tri bat ky trong mang
    - Hien thi thong tin ra console
 */
public class Program
{
    public static void Main()
    {
        /*1. Them vao cac so nguyen*/
        int[] numbers;
        Console.Write("Nhap so luong phan tu so nguyen: ");
        int size = int.Parse(Console.ReadLine());
        numbers = InputNumber(size);
        DisplayNumber(numbers);
        Console.WriteLine();
        Console.WriteLine("So nguyen da sap xep la:");
        SortArray(numbers);
        DisplayNumber(numbers);
        Console.WriteLine();
        Console.Write("Nhap gia tri can tang len 10 lan: ");
        int target = int.Parse(Console.ReadLine());
        ref int value = ref ChangeArray(numbers, target);
        value *= 10;//shorthand (value = value * 10; -=, +=, /=, %=...

        DisplayNumber(numbers);
        Console.WriteLine();
        var (sum,count) = Calculator(numbers);
        Console.Write($"Tong cac so chan la: {sum} va tong cac so le la: {count}");
        Console.WriteLine();
        Console.Write($"Them moi 1 so nguyen vao mang ");
        UpdateArray(numbers, 3, 77);
        DisplayNumber(numbers);
        Console.ReadLine();
    }


    public static int[] InputNumber(int size)
    {
        int[] resultNumbers = new int[size];
        int i = 0;
        while (i < size)
        {
            Console.Write($"Nhap so nguyen thu {i + 1} là: ");
            resultNumbers[i] = int.Parse(Console.ReadLine());
            i++; //unary operator (++i, i++ => i = i +1;)
        }
        return resultNumbers;
    }

    /*Hien thi thong tin so nguyen*/
    public static void DisplayNumber(int[] numbers)
    {
        Console.WriteLine("Day so nguyen la:");
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i],4}");
        }
    }

    public static void SortArray(int[] arr)
    {
        int temp;
        /*Sap xep theo bubble*/
        for (int j = 0; j <= arr.Length - 2; j++)
        {
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }

    public static ref int ChangeArray(int[] numbers, int num)
    {
        //Lay dia chi cua phan tu dau tien
        ref int value = ref numbers[0];
        if (numbers is not null && numbers?.Length != 0)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    value = ref numbers[i];
                    break; //de ngat vong lap va xuong duoi
                }
            }
        }
        return ref value;
    }

    public static (int total, int count) Calculator(int[] numbers)
    {
        var t = (total: 0, count: 0); //de return out (temp)
        //tinh tong so chan va dem so le
        foreach(int n in numbers)
        {
            if (IsEvenNumber(n)){
                t.total += n;
            }
            else
            {
                t.count++;
            }
        }
        return t;
        //local function for check even (chan)
        bool IsEvenNumber(int n)
        {
            return n % 2 == 0;
        }
    }
    //Them mot so nguyen vao mot vi tri bat ky trong mang => tu lam

    public static void UpdateArray(int[] numbers,int index,int num)
    {
        int[] temp = new int[numbers.Length + 1];
        if (IsValidIndex())
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                temp[i] = numbers[i];
            }
            //dich tu vi tri index ve ben phai 1 don vi
            for(int k = temp.Length - 1; k > index; k--)
            {
                temp[k] = temp[k-1];
            }
            temp[index] = num;
            numbers = temp; //tham chieu lai numbers vao mang moi

        }
        
        

        bool IsValidIndex()
        {
            /*
            if(index > temp.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
            */


            //conditional expression
            return (index > temp.Length)? false : true;
        }
    }
}

