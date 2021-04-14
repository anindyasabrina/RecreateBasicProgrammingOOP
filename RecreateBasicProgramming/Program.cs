using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecreateBasicProgramming
{
    class Pilihan
    {
        public void InputPilihan()
        {
            Console.WriteLine("Input Number From 1-4");
            Console.WriteLine("1. Body Mas Index \n" + "2. Reprint Name \n" + "3. Print Even's Character \n" + "4. Sum the Inputted Array \n");
        }
    }

    class Hitung : Pilihan
    {
        public void BMI(int bb, int tb)
        {
            float tinggiMeter = (float) tb /100 ;
            float bmi = (float) bb / (tinggiMeter*tinggiMeter);
            double ubah = Math.Round(bmi, 1);
            Console.WriteLine();
            Console.Write("Your BMI's " + ubah + " You're");
            if (bmi < 18.1)
            {
                Console.Write(" Underwight \n");
            }
            else if (bmi >= 18.1 && bmi <= 23.1)
            {
                Console.Write(" Normal \n");
            }
            else if (bmi >= 23.1 && bmi <= 28.1)
            {
                Console.Write(" OverWeight \n");
            }
            else
            {
                Console.Write(" Obesitas \n");
            }
        }

        public void NamaHuruf(String nama)
        {
            for (int i = 0; i < nama.Length; i++)
            {
                Console.WriteLine("Huruf Ke " + (i + 1) + " adalah " + nama[i]);
            }
        }

        public void Nama(String name)
        {
            String[] kata = new String[100];
            for (int i = 0; i < name.Length; i++)
            {
                kata[i] = name.Substring(i, 1);

            }
            for (int i = 1; i <= name.Length; i++)
            {
                Console.WriteLine(kata[i]);
                i += 1;
            }
        }

        public void jumlahArray(int bil)
        {
            int[] jumlah = new int[100];
            int total = 0;
            for (int i = 0; i < bil; i++)
            {

                Console.WriteLine("Input Array ke " + (i + 1));
                String input = Console.ReadLine();
                jumlah[i] = Convert.ToInt32(input);
            }
            for (int i = 0; i < bil; i++)
            {
                total += jumlah[i];

            }
            Console.WriteLine("Total = " + total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object
            Pilihan pil = new Pilihan();
            Hitung hit = new Hitung();
            pil.InputPilihan();

        Menu:
             int pilih = Convert.ToInt32(Console.ReadLine());

            
            switch (pilih)
            {
                case 1:
                    Console.WriteLine($"Input Your Weight (kg)");
                    int bb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Input Your Height (Cm)");
                    int tb = Convert.ToInt32(Console.ReadLine());
                    hit.BMI(bb, tb);
                    break;

                case 2:
                    Console.WriteLine($"Please Input Your Name");
                    string nama = Console.ReadLine();
                    hit.NamaHuruf(nama);
                    break;

                case 3:

                    Console.WriteLine($"Please Input Your Name");
                    string name = Console.ReadLine();
                    hit.Nama(name);
                    break;

                case 4:
                    Console.WriteLine($"Please Input Jumlah Array");
                    int bil = Convert.ToInt32(Console.ReadLine());
                    hit.jumlahArray(bil);
                    break;
            }

            Console.WriteLine("Type Yes for Restart Program");
            String masuk = Console.ReadLine();
            if (masuk.ToLower() != "Yes")
            {
                Console.WriteLine("Yes".Equals("yes", StringComparison.CurrentCultureIgnoreCase));
                Console.Clear();
                pil.InputPilihan();
                goto Menu;
            }

        }

    }
}
