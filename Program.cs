using System;
using System.Collections;

namespace Array
{
   static class Program
   {

        #region Forming an array and displaying its elements
        static int? Array1(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = 1 + (i * 2);

            return null;
        }
        static int? Array2(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = array[i - 1] * 2;

            return null;
        }
        static int? Array3(int n, int d)
        {
            int[] array = new int[n];
         
            for (int i = 1; i < n; i++)
                array[i] = array[0] + (i * d);

            return null;
        }
        static int? Array4(int n, int d, int a = 1)
        {
            int[] array = new int[n];
            a *= d;

            for(int i = 1; i < n; i++)
                array[i] = array[0] * a;

            return null;
        }
        static int? Array5(int n)
        {
            int[] array = new int[n];
            array[0] = 1;
            array[1] = 1;

            for (int i = 1; i < n; i++)
                array[i] = array[i - 2] + array[i - 1];

            return null;
        }
        static int? Array6(int n, int a, int b)
        {
            int[] array = new int[n];
            array[0] = a;
            array[1] = b;

            for(int i = 2; i < n; i++)
            {
                array[i] = 0;
                for (int j = 0; j < i; j++)
                    array[i] += array[j];
            }

            return null;
        }
        static int? Array7(int n)
        {
            int[] array = new int[n];

            for (int i = array.Length - 1; i >= 0; i--)
                Console.WriteLine(array[i]);

            return null;
        }
        static int Array8(int n, int result = 1)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                { 
                    Console.Write(array[i]);
                    result++;
                }
                else return n;
            }

            return result;
        }
        static int Array9(int n, int result = 1)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write(array[i]);
                    result++;
                }
                else return n;
            }
            
            return result;
        }
        static int? Array10(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
                if (array[i] % 2 == 0)
                    Console.WriteLine(array[i]);

            for (int j = array.Length - 1; j >= 0; j--)
                if (array[j] % 2 != 0)
                    Console.WriteLine(array[j]);

            return null;
        }
        static int? Array11(int n, int k)
        {
            int[] array = new int[n];

            for (int i = k; i < n; i += k)
                Console.WriteLine(array[i]);

            return null;
        }
        static int? Array12(int n)
        {
            int[] array = new int[n];

            for (int i = 1; i < n; i += 2)
                Console.WriteLine(array[i]);

            return null;
        }
        static int? Array13(int n)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 0; i -= 2)
                Console.WriteLine(array[i]);

            return null;
        }
        static int? Array14(int n)
        {
            int[] array = new int[n];

            for(int i = 1; i < n; i += 2)
                Console.WriteLine(array[i]);

            for(int j = 0; j < n; j += 2)
                Console.WriteLine(array[j]);

            return null;
        }
        static int? Array15(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i += 2)
                Console.WriteLine(array[i]);

            for(int j = n-(n % 2) - 1; j >= 1; j -= 2)
                Console.WriteLine(array[j]);

            return null;
        }
        static int? Array16(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < (n / 2); i++)
            {
                Console.WriteLine(array[i]);
                Console.WriteLine(array[n - i - 1]);
            }

            if(n % 2 != 0)
                Console.WriteLine(array[(n / 2)]);

            return null;
        }
        static int? Array17(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < (n / 2) + 1; i += 2)
            {
                if(i < (n / 2))
                    Console.WriteLine(array[i + 1]);

                if((n - i - 1) > (n / 2)) 
                    Console.WriteLine(array[n - i - 1]);

                if ((n - i - 2) > (n / 2)) 
                    Console.WriteLine(array[(n - i - 2)]);
            }

            return null;
        }
        #endregion

        #region Parsing array elements
        static int? Array18(int k)
        {
            int[] array = new int[10];

            for (k = 0; array[k] >= array[9]; k++) 
            {
                if (k == 10)
                    Console.WriteLine(0);

                else Console.WriteLine(array[k]);
            }     

            return null;
        }
        static int? Array19(int k)
        {
            int[] array = new int[10];

            for(k = 0; k < 10; k++)
            {
                if (array[0] < array[k] && array[k] < array[array.Length - 1])
                    Console.WriteLine(array[k]);

                else Console.WriteLine(k);
            }

            return null;
        }
        static int Array20(int n, int k , int l, int result = 0)
        {
            int[] array = new int[n];

            for (int i = k - 1; i <= l - 1; i++)
                result += array[i];

            return result;
        }
        static int? Array21(int n, int k, int l, int result = 0)
        {
            int[] array = new int[n];

            for (int i = k - 1; i <= l - 1; i++)
                result += array[i];

            Console.WriteLine((float)result / (float)(l - k + 1));

            return null;
        }
        static int Array22(int n, int k, int l, int result = 0)
        {
            int[] array = new int[n];

            for (int i = 0; i < (k - 1); i++)
                result += array[i];

            for (int i = l; i < n; i++)
                result += array[i];

            return result;
        }
        static int? Array23(int n, int k, int l, int result = 0)
        {
            int[] array = new int[n];

            for (int i = 0; i < (k - 1); i++)
                result += array[i];

            for (int i = l; i < n; i++)
                result += array[i];

            Console.WriteLine((float)result / (float)(k - 1 + (n - l)));

            return null;
        }
        static int Array24(int n)
        {
            int[] array = new int[n];

            int a = array[1] - array[0];

            for (int i = 1; i < n; i++)
                if (a != array[i] - array[i - 1]) a = 0;

            return a;
        }
        static float Array25(int n)
        {
            int[] array = new int[n];

            float a = (float)array[1] / (float)array[0];

            for (int i = 1; i < n; i++)
                if (a != (float)array[i] / (float)array[i - 1]) a = 0;

            return a;
        }
        static int? Array26(int n)
        {
            int[] array = new int[n];

            int a = array[0] % 2;

            for (int i = 1; ((i < n) && (a != (array[i] % 2))); i++)
            {
                a = array[i] % 2;

                if (i == n)
                    Console.WriteLine(0);

                else Console.WriteLine(i + 1);
            }

            return null;
        }
        static int? Array27(int n)
        {
            int[] array = new int[n];

            int a = array[0] % 2;

            for (int i = 1; ((i < n) && (a != (array[i] % 2))); i++)
            {
                a = array[i] % 2;

                if (i == n) 
                    Console.WriteLine(0);

                else Console.WriteLine(i + 1);
            }

            return null;
        }
        static int Array28(int n)
        {
            int[] array = new int[n];

            int min = array[1];

            for (int i = 1; i < n; i += 2)
                if (array[i] < min)
                    min = array[i];

            return min;
        }
        static int Array29(int n)
        {
            int[] array = new int[n];

            int max = array[0];

            for (int i = 0; i < n; i += 2)
                if (array[i] > max)
                    max = array[i];

            return max;
        }
        static int Array30(int n, int number = 0)
        {
            int[] array = new int[n];

            for (int i = 0; i < (n - 1); i++)
                if (array[i] > array[(i + 1)])
                {
                    Console.WriteLine(i + 1);
                    number++;
                }

            return number;
        }
        static int Array31(int n, int number = 0)
        {
            int[] array = new int[n];

            for (int i = array.Length - 1; i >= 1; i--)
                if (array[i - 1] < array[i])
                {
                    Console.WriteLine(i + 1);
                    number++;
                }

            return number;
        }
        static int? Array32(int n)
        {
            int[] array = new int[n];

            if (array[0] < array[1]) Console.WriteLine(n);
            else
            {
                int i = 1;
                while ((i < (n - 1)) && !((array[i - 1] > array[i]) && (array[i] < array[i + 1])))
                    i++;

                Console.WriteLine(i + 1);
            }

            return null;
        }
        static int? Array33(int n)
        {
            int[] array = new int[n];

            if(array[n - 1] > array[n - 2]) Console.WriteLine(n);
            else
            {
                int a = n - 2;

                while((a >= 1) && !((array[a - 1] < array[a]) && (array[a]) > array[a + 1]))
                    a--;

                Console.WriteLine(a + 1);
            }

            return null;
        }
        static int Array34(int n, int max = 0)
        {
            int[] array = new int[n];

            for(int i = 1;i < (n - 1); i++)
                if((array[i - 1] > array[i]) && (array[i] < array[i + 1]))
                    max = array[i];
                
            if ((array[0] < array[1]) && (array[0] > max))
                max = array[0];
            
            if ((array[n - 1] < array[n - 2]) && (array[n - 1] > max))
                max = array[n - 1];

            return max;
        }
        static int Array35(int n, int min = 0)
        {
            int[] array = new int[n];

            for(int i = 1; i < (n - 1); i++)
                if((array[i - 1] < array[i]) && (array[i] > array[i + 1]))
                    if ((array[i] < min))
                        min = array[i];
            
            if((array[0] > array[1]) && (array[0] < min)) 
                min = array[0];
            
            if((array[n - 1] > array[n - 2]) && (array[n - 1] < min))
                min = array[n - 1];

            return min;
        }
        static int Array36(int n, int max = 0)
        {
            int[] array = new int[n];

            for (int i = 1; i < n - 1; i++)
                if (!((array[i - 1] < array[i]) && (array[i] > array[i + 1])) && !((array[i - 1] > array[i]) && (array[i] < array[i + 1])))
                    max = array[i];

            if ((array[0] == array[1]) && (array[0] > max))
                max = array[0];

            if ((array[n - 1] == array[n - 2]) && (array[n - 1] > max))
                max = array[n - 1];

            return max;
        }
        static int Array37(int n, int number = 0)
        {
            int[] array = new int[n];

            for (int i = 2; i < n; i++)
                if ((array[i - 2] < array[i - 1]) && !(array[i - 1] < array[i]))
                    number++;

            if (array[n - 2] < array[n - 1])
                number++;

            return number;
        }
        static int Array38(int n, int number = 0)
        {
            int[] array = new int[n];

            for (int i = 2; i < n; i++)
                if ((array[i - 2] > array[i - 1]) && !(array[i - 1] > array[i]))
                    number++;

            if (array[n - 2] > array[n - 1]) 
                number++;

            return number;
        }
        static int Array39(int n, int number = 0)
        {
            int[] array = new int[n];

            for(int i = 2; i < n; i++)
            {
                if ((array[i - 2] > array[i - 1]) && !(array[i - 1] > array[i]))
                    number++;

                if ((array[i - 2] < array[i - 1]) && !(array[i - 1] < array[i]))
                    number++;
            }

            if (array[n - 2] != array[n - 1]) 
                number++;

            return number;
        }
        static int? Array40(int n, int r, int k = 1)
        {
            int[] array = new int[n];

            int min = Math.Abs(array[0] - r);

            for(int i = 1;i < n; i++)
                if((Math.Abs(array[i] - r)) < min)
                {
                    min = (Math.Abs(array[i] - r));
                    k = i;
                }

            Console.WriteLine(array[k]);

            return null;
        }
        static int? Array41(int n, int k = 1)
        {
            int[] array = new int[n];

            int maxSum = array[0] + array[1];

            for(int i = 2; i < n; i++)
                if((array[i - 1] + array[i]) > maxSum)
                {
                    maxSum = array[i - 1] + array[k];
                    k = i;
                }

            Console.WriteLine(array[k - 1]);

            return null;
        }
        static int? Array42(int n, int r, int k = 1)
        {
            int[] array = new int[n];

            int min = Math.Abs(array[0] + array[1] - r);

            for(int i = 2; i < n; i++)
                if(Math.Abs(array[i - 1] + array[i] - r) < min)
                {
                    min = Math.Abs(array[i - 1] + array[i] - r);
                    k = i;
                }

            Console.WriteLine(array[k - 1]);

            return null;
        }
        static int Array43(int n, int number = 1)
        {
            int[] array = new int[n];

            for (int i = 1; i < n; i++)
                if (array[i - 1] != array[i])
                    number++;

            return number;
        }
        static int? Array44(int n)
        {
            int[] array = new int[n];

            for (int i = 0; i < (n - 1); i++)
                for (int j = (i + 1); j < n; j++)
                    if ((array[i] == array[j])) 
                        Console.WriteLine($"{i + 1}, {j + 1}");

            return null;
        }
        static int? Array45(int n, int k = 0, int g = 1)
        {
            int[] array = new int[n];

            for(int i = 0; i < (n - 1); i++)
                for(int j = (i + 1); j < n; j++)
                    if(Math.Abs(array[i] - array[j]) < Math.Abs(array[k] - array[g]))
                    {
                        k = i;
                        g = j;
                    }

            Console.WriteLine($"{k + 1}, {g + 1}");

            return null;
        }
        static int? Array46(int n, int r, int k = 0, int g = 1)
        {
            int[] array = new int[n];

            for(int i = 0; i < (n - 1); i++)
                for(int j = (i + 1); j < n; j++)
                    if(Math.Abs(array[i] + array[j] - r) < Math.Abs(array[k] + array[g] - r))
                    {
                        k = i;
                        g = j;
                    }

            Console.WriteLine($"{k + 1}, {g + 1}");

            return null;
        }
        static int Array47(int n, int number = 1)
        {
            int[] array = new int[n];

            for (int i = 1; i < n; i++)
                for(int j = i - 1; j >= 0; j--)
                    if(array[i] == array[j])
                    {
                        number--;
                        break;
                    }

            return number;
        }
        static int Array48(int n, int maxNumber = 0)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                int number = 1;
                for (int j = i + 1; j < n; j++)
                    if (array[i] == array[j])
                        number++;

                if (number > maxNumber)
                    maxNumber = number;
            }

            return maxNumber;
        }
        static int? Array49(int n)
        {
            int[] array = new int[n];

            for(int i = 1; i <= n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(array[j] == i)
                    {
                        j = n + 100;
                        break;
                    }

                    if (j != n + 100) 
                        break;
                }
                if (i == n + 1) 
                    Console.WriteLine(0);
            }

            return null;
        }
        static int Array50(int n, int number = 0)
        {
            int[] array = new int[n];

            for (int i = 0; i < (n - 1); i++)
                for (int j = i + 1; j < n; j++)
                    if (array[i] > array[j])
                        number++;

            return number;
        }

        #endregion

        #region Array conversion
        static int? Array51(int n)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(int i = 0; i < n; i++)
            {
                arrayA[i] += arrayB[i];
                arrayB[i] -= arrayA[i];
                arrayA[i] -= arrayB[i];
            }

            for (int i = 0; i < n; i++) 
                Console.WriteLine($"{i + 1}, {arrayA[i]}");

            for (int j = 0; j < n; j++)
                Console.WriteLine($"{j + 1}, {arrayB[j]}");

            return null;
        }
        static int? Array52(int n, int k)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 0; k < n; k++)
            {
                if (arrayA[k] < 5)
                    arrayB[k] = 2 * arrayA[k];

                else arrayB[k] = arrayA[k] / 2;
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}");

            return null;
        }
        static int? Array53(int n, int k)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];
            int[] arrayC = new int[n];

            for(k = 0; k < n; k++)
            {
                if (arrayA[k] > arrayB[k])
                    arrayC[k] = arrayA[k];

                else arrayC[k] = arrayB[k];
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}");

            return null;
        }
        static int? Array54(int n, int k, int i = 0)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 0; k < n; k++)
                if(arrayA[k] % 2 == 0)
                {
                    arrayB[i] = arrayA[k];
                    i++;
                }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}, {i}");

            return null;
        }
        static int? Array55(int n, int k, int i = -1)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 0; k < n; k++)
            {
                i++;
                arrayB[i] = arrayA[k];
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}, {i}");

            return null;
        }
        static int? Array56(int n, int k, int i = 0)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 2; k < n; k += 3)
            {
                arrayB[i] = arrayA[k];
                i++;
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}, {i}");

            return null;
        }
        static int? Array57(int n, int k, int i = 0)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 0; k < n; k += 2)
            {
                arrayB[i] = arrayA[k];
                i++;
            }

            for(k = 1; k < n; k += 2)
            {
                arrayB[i] = arrayA[k];
                i++;
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}, {i}");

            return null;
        }
        static int? Array58(int n , int k)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for( k = 0; k < n; k++)
            {
                arrayB[k] = 0;

                for (int i = 0; i <= k; i++)
                    arrayB[k] += arrayA[i];
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}");

            return null;
        }
        static int? Array59(int n, int k)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 0; k < n; k++)
            {
                arrayB[k] = 0;

                for (int i = 0; i <= k; i++)
                    arrayB[k] += arrayA[i];

                arrayB[k] /= k + 1;
            }
            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}");

            return null;
        }
        static int? Array60(int n, int k)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 0; k < n; k++)
            {
                arrayB[k] = 0;

                for (int i = k; i < n; i++)
                    arrayB[k] += arrayA[i];
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}");

            return null;
        }
        static int? Array61(int n, int k)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for(k = 0; k < n; k++)
            {
                arrayB[k] = 0;

                for (int i = k; i < n; i++)
                    arrayB[k] += arrayA[i];

                arrayB[k] /= (n - k);
            }
            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}");

            return null;
        }
        static int? Array62(int n, int k, int a = 0, int b = 0)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];
            int[] arrayC = new int[n];

            for(k = 0; k < n; k++)
            {
                if(arrayA[k] > 0)
                {
                    arrayB[a] = arrayA[k];
                    a++;
                }

                if(arrayA[k] < 0)
                {
                    arrayC[b] = arrayA[k];
                    b++;
                }
            }
            for (k = 0; k < a; k++)
                Console.WriteLine($"{k + 1}, {arrayB[k]}");

            for (k = 0; k < b; k++)
                Console.WriteLine($"{k + 1}, {arrayC[k]}");

            return null;
        }
        static int? Array63(int n, int k, int a = 0, int b = 0)
        {
            int[] arrayA = new int[5];
            int[] arrayB = new int[5];
            int[] arrayC = new int[n];

            for(k = 0; k < n; k++)
            {
                if((a >= 5) || ((arrayA[a] > arrayB[b]) && (b < 5)))
                {
                    arrayC[k] = arrayB[b];
                    b++;
                }

                else
                {
                    arrayC[k] = arrayA[a];
                        a++;
                }
            }

            for (k = 0; k < n; k++)
                Console.WriteLine($"{k + 1}, {arrayC[k]}");

            return null;
        }
        static int? array64(int n, int k, int a, int b, int c, int d, int ka = 0, int kb = 0, int kc = 0)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];
            int[] arrayC = new int[n];
            int[] arrayD = new int[n];

            d = a + b + c;

            for(k = 0; k < d; k++)
            {
                if((ka < a) && ((kb >= b) || (arrayA[ka] >= arrayB[kb])) && ((kc >= c) || (arrayA[ka] > arrayC[kc])))
                {
                    arrayD[k] = arrayA[ka];
                    ka++;
                }

                else if((kb < b) && ((kc >= c) || (arrayB[kb] > arrayC[kc])))
                {
                    arrayD[k] = arrayB[kb];
                    kb++;
                }

                else
                {
                    arrayD[k] = arrayC[kc];
                    kc++;
                }
            }

            for (k = 0; k < d; k++)
                Console.WriteLine($"{k + 1}, {arrayD[k]}");

            return null;
        }
        #endregion

        #region Series of integers
        static int? Array65(int n, int k)
        {
            int[] array = new int[n];

            int ak = array[k - 1];

            for (int i = 0; i < n; i++)
                array[i] += ak;

            for (int i = 0; i < n; i++) 
                Console.WriteLine($"{k + 1}, {array[i]}");

            return null;
        }
        static int? Array66(int n, int even = 0)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
                if(array[i] % 2 == 0)
                {
                    even = array[i];
                    break;
                }

            for (int j = 0; j < n; j++)
                if (array[j] % 2 == 0)
                    array[j] += even;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array67(int n, int odd = 0)
        {
            int[] array = new int[n];

            for(int i = (array.Length - 1); i >= 0; i--)
                if(array[i] % 2 != 0)
                {
                    odd = array[i];

                    break;
                }

            for (int j = array.Length - 1; j >= 0; j--)
                if (array[j] % 2 != 0)
                    array[j] += odd;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array68(int n, int min = 0, int max = 0)
        {
            int[] array = new int[n];

            for(int i = (array.Length - 1); i >= 0; i--)
            {
                if (array[i] > array[max])
                    max = i;

                if (array[i] < array[min])
                    min = i;
            }

            if(max != min)
            {
                array[max] += array[min];
                array[min] -= array[max];
                array[max] -= array[min];
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array69(int n)
        {
            int[] array = new int[n];

            for(int i = 1; i < n; i += 2)
            {
                array[i] += array[i - 1];
                array[i - 1] -= array[i];
                array[i] -= array[i - 1];
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array70(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < (n / 2); i++)
            {
                array[i] += array[(n / 2) + i];
                array[(n / 2) + i] -= array[i];
                array[i] -= array[(n / 2) + i];
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array71(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < (n / 2); i++)
            {
                array[i] += array[n - i - 1];
                array[n - i - 1] -= array[i];
                array[i] -= array[n - i - 1];
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array72(int n, int k, int l)
        {
            int[] array = new int[n];

            for(int i = (k - 1); i < k + (l - k) / 2; i++)
                if(i != (l - i + k - 2))
                {
                    array[i] += array[l - i + k - 2];
                    array[l - i + k - 2] = array[i] - array[l - i + k - 2];
                    array[i] = array[i] - array[l - i + k - 2];
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array73(int n, int k, int l)
        {
            int[] array = new int[n];

            for(int i = k; i < k + (l - k) / 2; i++)
                if(i != (l - i + k - 2))
                {
                    array[i] += array[l - i + k - 2];
                    array[l - i + k - 2] = array[i] - array[l - i + k - 2];
                    array[i] = array[i] - array[l - i + k - 2];
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array74(int n, int min = 0, int max = 0)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > array[max]) max = i;
                if (array[i] < array[min]) min = i;
            }

            if(max < min)
            {
                max += min;
                min = max - min;
                max = max - min;
            }

            for (int i = min + 1; i < min + (max - min); i++)
                array[i] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array75(int n, int min = 0, int max = 0)
        {
            int[] array = new int[n];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > array[max]) max = i;
                if (array[i] < array[min]) min = i;
            }

            if (max < min)
            {
                max += min;
                min = max - min;
                max = max - min;
            }

            for(int i = min; i < min + 1 + (max - min) / 2; i++)
                if(i != (max - i + min))
                {
                    array[i] += array[max - i + min];
                    array[max - i + min] = array[i] - array[max - i + min];
                    array[i] = array[i] - array[max - i + min];
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array76(int n, int i)
        {
            int[] array = new int[n];

            if (array[0] > array[1])
            {
                i = 2;
                array[0] = 0;
            }
            else i = 1;

            for(i = 0; i < (n - 1); i++)
                if((array[i - 1] < array[i]) && (array[i]) > array[i + 1])
                {
                    array[i] = 0;
                    i++;
                }

            if ((i == (n - 1)) && (array[n - 2] < array[n - 1]))
                array[n - 1] = 0;

            for (i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array77(int n, int i)
        {
            int[] array = new int[n];

            if (array[0] > array[1])
            {
                i = 2;
                array[0] = 0;
            }
            else i = 1;

            for(i = 0; i < (n - 1); i++)
                if((array[i - 1] > array[i]) && (array[i] < array[i + 1]))
                {
                    array[i] *= array[i];
                    i++;
                }

            if ((i == (n - 1)) && (array[n - 2] > array[n - 1]))
                array[n - 1] *= array[n - 1];

            for (i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array78(int n, int a)
        {
            int[] array = new int[n];

            int b = array[0];
            array[0] = (b + array[1]) / 2;

            for(int i = 1; i < (n - 1); i++)
            {
                a = b;
                a = array[i];
                array[i] = (a + b + array[i + 1]) / 3;
            }

            array[n - 1] = (array[n - 1] + b) / 2;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        } 
        static int? Array79(int n)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
                array[0] = 0;
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array80(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < (n - 1); i++)
            {
                array[i] = array[i + 1];
                array[n - 1] = 0;
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array81(int n, int k)
        {
            int[] array = new int[n];

            for (int i = array.Length - 1; i > (k - 1); i--)
                array[i] = array[i - k];

            for (int i = array.Length - 1; i >= 0; i--)
                array[i] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array82(int n, int k)
        {
            int[] array = new int[n];

            for (int i = 0; i < (n - k); i++)
                array[i] = array[i + k];

            for (int i = 0; i < n; i++)
                array[i] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array83(int n)
        {
            int[] array = new int[n];

            int a = array[n - 1];

            for(int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
                array[0] = a;
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array84(int n)
        {
            float[] array = new float[n];

            float a = array[0];

            for(int i = 0; i < n - 1; i++)
            {
                array[i] = array[i + 1];
                array[n - 1] = a;
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array85(int n, int k)
        {
            float[] array = new float[n];

            for (int i = 1; i < k; k++)
            {
                float a = array[n - 1];
                for (int j = array.Length - 1; j >= 0; j--)
                {
                    array[i] = array[i - 1];
                    array[0] = a;
                }
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array86(int n, int k)
        {
            float[] array = new float[n];

            for(int j = 1; j <= k; j++)
            {
                float a = array[0];
                for(int i = 0; i < (n - 1); i++)
                {
                    array[i] = array[i + 1];
                    array[n - 1] = a;
                }
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array90(int n, int k)
        {
            int[] array = new int[n];

            --n;

            for (int i = k - 1; i < n; i++)
                array[i] = array[i + 1];

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array91(int n, int k, int l)
        {
            int[] array = new int[n];

            n -= l - k + 1;

            for (int i = k - 1; i < n; i++)
                array[i] = array[i + (l - k + 1)];

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array92(int n, int k = 0)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
                if(array[i] % 2 == 0)
                {
                    array[k] = array[i];
                    k++;
                }

            for(int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array93(int n, int k = 0)
        {
            int[] array = new int[n];

            for (int i = 0; i < n; i += 2)
            {
                array[k] = array[i];
                k++;
            }

            for (int i = 0; i < k; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array94(int n, int k = 0)
        {
            int[] array = new int[n];

            for(int i = 1; i < n; i += 2)
            {
                array[k] = array[i];
                k++;
            }

            for (int i = 0; i < k; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array95(int n, int k = 0)
        {
            int[] array = new int[n];

            for(int i = 1; i < n; i++)
                if(array[k] != array[i])
                {
                    k++;
                    array[k] = array[i];
                }

            k++;

            for (int i = 0; i < k; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array96(int n, int k = 0)
        {
            int[] array = new int[n];

            for(int i = 1; i < n; i++)
            {
                array[k] = array[i];
                for(int j = 0; j < k; j++)
                    if(array[k] == array[j])
                    {
                        k--;
                        break;
                    }
            }

            k++;

            for (int i = 0; i < k; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array97(int n, int k = 0, int j = 0)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                    if (array[j] == array[i])
                        break;

                if(j == n)
                {
                    array[k] = array[i];
                    k++;
                }
            }

            for (int i = 0; i < k; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array98(int n, int k = -1, int j = 0, int number = 0)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                for (j = 0; j <= k; j++)
                    if (array[i] == array[j])
                        break;

                if(j != k + 1)
                {
                    k++;
                    array[k] = array[i];
                }
                else
                {
                    for (j = i; j < n; j++)
                        if (array[j] == array[i])
                            number++;

                    if(number >= 3)
                    {
                        k++;
                        array[k] = array[i];
                    }
                }
                
            }

            k++;

            for (int i = 0; i < k; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array99(int n, int a, int k, int number)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (array[i] == array[j])
                        number++;

                if(number > 2)
                {
                    k = i - 1;
                    a = array[i];

                    for(int j = i; j < n; j++)
                        if(array[j] != a)
                        {
                            k++;
                            array[k] = array[j];
                        }

                    n = k + 1;
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array100(int n, int a, int k, int number)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                number = 0;

                for (int j = 0; j < n; j++)
                    if (array[i] == array[j])
                        number++;

                if (number == 2)
                {
                    k = i - 1;
                    a = array[i];

                    for(int j = 1; j < n; j++)
                        if(array[j] != a)
                        {
                            k++;
                            array[k] = array[j];
                        }

                    n = k + 1;
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array101 (int n, int k)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= k; i--)
            {
                array[i] = array[i - 1];
                array[k - 1] = 0;
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array102(int n, int k)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i > k; i--)
            {
                array[i] = array[i - 1];
                array[k] = 0;
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array103(int n, int min = 0, int max = 0)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                if (array[min] > array[i])
                    min = i;

                if (array[max] < array[i])
                    max = i;
            }

            if (max > min)
                max++;

            n++;

            for(int i = array.Length - 1; i >= min; i--)
            {
                array[i] = array[i - 1];
                array[min] = 0;
            }
            n++;

            for(int i = array.Length - 1; i > max + 1; i--)
            {
                array[i] = array[i - 1];
                array[max + 1] = 0;
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array104(int n, int k, int m)
        {
            int[] array = new int[n];

            n += m;

            for (int i = array.Length - 1; i >= k + m - 1; i--)
                array[i] = array[i - m];

            for (int i = k - 1; i < k + m - 1; i++)
                array[i] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array105(int n, int k, int m)
        {
            int[] array = new int[n];

            n += m;

            for (int i = array.Length - 1; i >= k + m - 1; i--)
                array[i] = array[i - m];

            for (int i = k - 1; i < k + m - 1; i++)
                array[i] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array107(int n)
        {
            int[] array = new int[n];

            for (int i = n - ((n - (n / 2) * 2) - 1) - 1;i >= 0; i -= 2)
                for(int j = 1; j < 3; j++)
                {
                    n++;

                    for (int g = array.Length - 1; g > i; g--)
                        array[g] = array[g - 1];
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array108(int n)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 0; i--)
                if(array[i] > 0)
                {
                    n++;
                    for(int j = array.Length - 1; j > i; j--)
                    {
                        array[j] = array[j - 1];
                        array[i] = 0;
                    }
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array109(int n)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 0; i--)
                if(array[i] < 0)
                {
                    n++;

                    for(int j = n; j > i; j--)
                    {
                        array[j] = array[j - 1];
                        array[i + 1] = 0;
                    }
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array110(int n)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 0; i--)
                if(array[i] % 2 == 0)
                {
                    n++;
                    for (int j = array.Length - 1; j > i; j--)
                        array[j] = array[j - 1];
                }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");

            return null;
        }
        static int? Array111(int n)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i >= 0; i--)
                if(array[i] % 2 != 0)
                    for(int j = 1; j < 3; j++)
                    {
                        n++;
                        for (int g = array.Length - 1; g > i; g--)
                            array[g] = array[g - 1];
                    }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]}");


            return null;
        }
        static int? Array112(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < n - 1; i++)
                for(int j = 0; j < n - i; j++)
                    if(array[j] > array[j + 1])
                    {
                        array[j] += array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] -= array[j + 1];
                    }

            for (int j = 0; j < n; j++)
                Console.WriteLine($"{j + 1}, {array[j]}");

            return null;
        }
        static int? Array113(int n, int max)
        {
            int[] array = new int[n];

            for(int i = array.Length - 1; i > 0; i--)
            {
                max = 1;

                for (int j = 0; j <= i; j++)
                    if (array[j] > array[max])
                        max = j;

                if( i != max)
                {
                    array[i] += array[max];
                    array[max] = array[i] - array[max];
                    array[i] -= array[max];
                }

                for (int j = 0; j < n; j++)
                    Console.WriteLine($"{j + 1}, {array[j]}");
            }

            return null;
        }
        static int? Array114(int n, int temp)
        {
            int[] array = new int[n];

            if(array[0] > array[1])
            {
                temp = array[0];
                array[0] = array[1];
                array[1] = temp;
            }

            for(int i = 2; i <= n - 1; i++)
            {
                temp = array[i];
                for(int j = i - 1; j >= 0; j--)
                {
                    if (temp < array[j])
                        array[j + 1] = array[j];
                    else break;

                    array[j + 1] = temp;
                }

                for (int j = 0; j < n; j++)
                    Console.WriteLine($"{j + 1}, {array[j]}");
            }

            return null;
        }
        static int? Array115(int n, int i)
        {
            int[] arrayN = new int[n];
            int[] arrayI = new int[i];

            for (int g = 0; g < n; g++)
            {
                for(int j = 0; j <= n - g - 2; j++)
                    if(arrayN[arrayI[j]] > arrayN[arrayI[j] + 1])
                    {
                        arrayI[j] += arrayI[j + 1];
                        arrayI[j + 1] = arrayI[j] - arrayI[j + 1];
                        arrayI[j] -= arrayI[j + 1];
                    }
                
                for (int m = 0; m < n; m++)
                    Console.WriteLine($"{m + 1}, {arrayI[m] + 1}");
            }

            return null;
        }
        static int? Array116(int n, int k = 0)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];
            int[] arrayC = new int[n];

            arrayB[k] = 1;
            arrayC[k] = arrayA[k];

            for(int i = 1; i < n; i++)
            {
                if (arrayA[i - 1] == arrayA[i])
                    arrayB[k]++;
                else
                {
                    k++;
                    arrayB[k] = 1;
                    arrayC[k] = arrayA[i];
                }
            }

            for (int i = 0; i <= k; i++)
                Console.WriteLine($"{i + 1}, {arrayB[i]}, {arrayC[i]}");

            return null;
        }
        static int? Array117(int n, int k = 1)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            arrayB[0] = 0;
            arrayB[k] = arrayA[1];

            for(int i = 1; i < n; i++)
            {
                k++;

                if(arrayA[i - 1] != arrayA[i])
                {
                    arrayB[k] = 0;
                    k++;
                }

                arrayB[k] = arrayA[i];
            }

            for (int i = 0; i <= k; i++)
                arrayA[i] = arrayB[i];

            for (int i = 0; i <= k; i++)
                Console.WriteLine($"{i + 1}, {arrayA[i]},");

            return null;
        }
        static int? Array118(int n)
        {
            int[] array = new int[n];
            
            for(int i = 0; i < n; i++)
                if(i + 1 < n)
                    if(array[i + 1] != array[i])
                    {
                        n++;
                        for (int j = array.Length - 1; j > i; j--)
                            array[j] = array[j - 1];
                        i++;
                        array[i] = 0;
                    }

            n++;
            array[n - 1] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        static int? Array119(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
                if(i + 1 < n)
                    if(array[i + 1] != array[i])
                    {
                        n++;
                        for (int j = array.Length - 1; j > i; j--)
                            array[j] = array[j - 1];

                        i++;
                        array[i] = 0;
                    }

            n++;
            array[n - 1] = 0;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        static int? Array120(int n)
        {
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
                if(i + 1 < n)
                    if(array[i] != array[i + 1])
                    {
                        n--;
                        for (int j = i; j < n; j++)
                            array[j] = array[j + 1];

                        i--;
                    }

            n--;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        static int? Array121(int n, int i, int k, int number = 1)
        {
            int[] array = new int[n];

            for (i = 0; (i < n - 1) && (number < k); i++)
                if (array[i] != array[i + 1])
                    number++;

            int begin = i;

            for (i = begin; i < n - 1; i++)
                if (array[i] != array[i + 1])
                    break;

            int end = i;

            for(int j = 1; j <= end - begin + 1; j++)
            {
                n++;
                array[i] = array[i - 1];
            }

            for (i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        static int? Array122(int n, int k)
        {
            int[] array = new int[n];

            int a = 1;
            int serial = k == 1 ? 1 : 0;// эта строка из интернета

            for (int i = 1; i < n; i++)
                if (array[i - 1] != array[i])
                    a++;

            n -= serial;

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        static int? Array123(int n, int k, int endSeries,  int lenSeries = 1, int series = 0, int a = 1, int g = -1) 
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            for (int i = 0; i < arrayA.Length; i++)
                arrayB[i] = 0;

            for(int i = 1; (i < n) && (a <= k); i++)
            {
                if (arrayA[i - 1] != arrayA[i]) 
                    a++;
                if (a == 1) 
                    lenSeries++;
                if(a == k)
                {
                    series++;
                    arrayB[g++] = arrayA[i];
                }
                endSeries = i;
            }

            for(int i = lenSeries; (i < n) && (i < endSeries - series); i++)
            {
                if (arrayA[i - 1] != arrayA[i])
                    a++;

                arrayB[g++] = arrayA[i];
            }

            for (int i = 0; i < lenSeries; i++)
                arrayB[g++] = arrayA[i];

            for (int i = endSeries; i < n; i++)
                arrayB[g++] = arrayA[i];

            for (int i = 0; i < n; i++)
                arrayA[i] = arrayB[i];

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {arrayA[i]},");

            return null;
        }
        static int? Array124(int n, int k, int beginEndSeries, int a = 1, int beginSeries = 1, int g = -1)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            int lenSeries = (k == 1 ? 1 : 0);

            for(int i = 1; i < n; i++)
            {
                if(arrayA[i - 1] != arrayA[i])
                {
                    a++;

                    if (a == k)
                        beginSeries = i;

                    beginEndSeries = 1;
                }
                if (a == k)
                    lenSeries++;
            }

            for (int i = 0; i < beginSeries; i++)
                arrayB[g++] = arrayA[i];

            for(int i = beginEndSeries; i < n; i++)
                arrayB[g++] = arrayA[i];

            for (int i = beginSeries + lenSeries; i < beginEndSeries; i++)
                arrayB[g++] = arrayA[i];

            for (int i = beginSeries; i < beginSeries + lenSeries; i++)
                arrayB[g++] = arrayA[i];

            for (int i = 0; i < n; i++)
                arrayA[i] = arrayB[i];

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}, {arrayA[i]},");

            return null;
        }
        static int? Array125(int n,int l = 1, int g = -1, int len = 1)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            int end = n;
            int i;

            for( i = 1; i < n; i++)
            {
                if(arrayA[i - 1] != arrayA[i])
                {
                    if (len < l)
                    {
                        arrayB[g++] = 0;
                        end -= len - 1;
                    }
                    else
                        for (int j = 0; j < len; j++)
                            arrayB[g++] = arrayB[i - 1];

                    len = 0;
                }
                len++;
            }
            if (len < 1)
            {
                arrayB[g++] = 0;
                end -= len - 1;
            }
            else
                for (int j = 1; j <= len; j++)
                    arrayB[g++] = arrayA[i - 1];

            for (i = 0; i < end; i++)
                arrayA[i] = arrayB[i];

            for (i = 0; i < end; i++)
                Console.WriteLine($"{i + 1}, {arrayA[i]},");

            return null;
        }
        static int? Array126(int n, int l = 1, int g = -1, int len = 1)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            int end = n;

            for(int i = 1; i < n; i++)
            {
                if (arrayA[i - 1] != arrayA[i])
                {
                    if (len == 1)
                    {
                        arrayB[g++] = 0;
                        end -= len - 1;
                    }
                    else
                        for (int j = 0; j < len; j++)
                            arrayB[j++] = arrayA[i - 1];

                    len = 0;
                }
                len++;
            }
            if (len == 1)
            {
                arrayB[g++] = 0;
                end -= len - 1;
            }
            else
                for (int j = 0; j < len; j++)
                    arrayB[g++] = arrayA[j - 1];

            for (int i = 0; i < end; i++)
                arrayA[i] = arrayB[i];

            for (int i = 0; i < end; i++)
                Console.WriteLine($"{i + 1}, {arrayA[i]},");

            return null;
        }
        static int? Array127(int n, int g = -1,int len = 1)
        {
            int[] arrayA = new int[n];
            int[] arrayB = new int[n];

            int end = n;

            for(int i = 1; i < n; i++)
            {
                if (arrayA[i - 1] != arrayA[i])
                {
                    arrayB[g++] = 0;
                    end -= len - 1;
                }
                else
                    for (int j = 0; j < len; j++)
                        arrayB[g++] = arrayA[i - 1];

                arrayB[g++] = 0;
                end -= len - 1;
            }
            for (int j = 0; j < len; j++)
                arrayB[j++] = arrayA[j - 1];

            for (int i = 0; i < end; i++)
                arrayA[i] = arrayB[i];

            for (int i = 0; i < end; i++)
                Console.WriteLine($"{i + 1}, {arrayA[i]},");

            return null;
        }
        static int? Array128(int n, int len = 1, int max = 1,int end = 1)
        {
            int[] array = new int[n];
            int i;

            for(i = 1; i < n; i++)
            {
                if(array[i - 1] != array[i])
                {
                    if(len > max)
                    {
                        max = len;
                        end = i - 1;
                    }
                    len = 0;
                }
                len++;
            }
            if(len> max)
            {
                max = len;
                end = i - 1;
            }
            for (i = array.Length - 1; i > end; i--)
                array[i] = array[i - 1];

            for ( i = 0; i < end; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        static int? Array129(int n, int len = 1, int max = 1, int end = 1)
        {
            int[] array = new int[n];
            int i;

            for(i = 1; i < n; i++)
            {
                if(array[i - 1] != array[i])
                {
                    if(len >= max)
                    {
                        max = len;
                        end = i - 1;
                    }
                    len = 0;
                }
                len++;
            }
            if(len > max)
            {
                max = len;
                end = i - 1;
            }
            for (i = array.Length - 1; i > end; i--)
                array[i] = array[i - 1];

            for (i = 0; i < end; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        static int? Array130(int n, int len = 1, int max = 1,int end = 1)
        {
            int[] array = new int[n];
            int i;

            for (i = 1; i < n; i++)
            {
                if (array[i - 1] != array[i])
                {
                    if (len == max)
                    {
                        for (int j = array.Length - 1; j > i; j--)
                            array[j] = array[j - 1];
                        i++;
                    }
                    len = 0;
                }
                len++;
            }

            for (i = 0; i < end; i++)
                Console.WriteLine($"{i + 1}, {array[i]},");

            return null;
        }
        #endregion
    }
}
