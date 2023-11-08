using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kompresijaSlik.cs
{
    internal class Program
    {

        static int findIndex(int[] list,int number)
        {
            for(int i = 0; i < list.Length; i++)
                if (list[i] == number) return i;
            Console.WriteLine("returned 0");
            return 0;
        }
        void neki()
        {
            int[] numbers = { 55, 53, 53, 53, 53, 53, 10, 10, 11, 11, 11, 11 };

            List<int> list = new List<int>();
            list.Add(numbers[0]);

            string output = "";

            for (int i = 1; i < numbers.Length; i++)
                list.Add(numbers[i] - numbers[i - 1]);

            bool firstValue = true;
            int[] twoBit = { -2, -1, 1, 2 };
            int[] threeBit = { -6, -5, -4, -3, 3, 4, 5, 6 };
            int[] fourBit = { -14, -13, -12, -11, -10, -9, -8, -7, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] fiveBit = { -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17, -16, -15, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int st = 0;
            foreach (int item in list)
            {

                if (firstValue)
                {
                    //treba se fixat ker more bit 8 bitov, sam ka ce je cifra vecja od 6 bitov kot je trenutno pol bo 9 bitov kar scursa life
                    output += "00" + Convert.ToString(item, 2);
                }
                else
                {


                    //if(item >)

                
                
                if(item == 0)
                {
                    int repeat = 0;
                    int repeatIfMoreThanEight = 0;
                    int breakk = 1;
                    int index = 0;
                    int saveRepeat = 0;
                    for(int i = 0;i < list.Count;i++) {
                        if (list[i] == item)
                        {
                            index = i; break;
                        }
                    }
                    for(int x = 0;x <= breakk;x++) { 
                        for(int i = index+1; i  < list.Count;i++)
                        {
                            if(repeat > 8) {
                                    breakk++;
                                    break;
                            }
                            if(i == item) repeat++;
                             else { break; }
                        }
                        repeatIfMoreThanEight++;
                        saveRepeat += repeat;
                        repeat = 0;

                    }
                    output += "01";
                    if (saveRepeat == 0)
                        output += "000";
                    else if (saveRepeat == 1)
                        output += "001";
                    else if (saveRepeat == 2)
                        output += "010";
                    else if (saveRepeat == 3)
                        output += "011";
                    else if (saveRepeat == 4)
                        output += "100";
                    else if (saveRepeat == 5)
                        output += "101";
                    else if (saveRepeat == 6)
                        output += "110";
                    else if (saveRepeat == 7)
                        output += "111";
                    

                    

                }
                if (item >= -2 && item <= -1 || item >= 1 && item <= 2)
                    output += "00" + Convert.ToString(findIndex(twoBit, item),2);
                if (item >= -6 && item <= -3 || item >= 3 && item <= 6)
                    output += "01" + Convert.ToString(findIndex(threeBit, item), 2);
                if (item >= -14 && item <= -7 || item >= 7 && item <= 14)
                    output += "10" + Convert.ToString(findIndex(fourBit, item), 2);
                if (item >= -30 && item <= -15 || item >= 15 && item <= 30)
                    output += "11" + Convert.ToString(findIndex(fiveBit, item), 2);
                }
                st++;

            }
        }
        static void Main(string[] args)
        {

            int val = 10;
            string binary = Convert.ToString(val,2);
            Console.WriteLine(binary);

            


            
            
            

            
        }
    }
}
