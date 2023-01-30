using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Menú");
            Console.WriteLine("---------");
            Console.WriteLine();
            Console.WriteLine("1- EscribeArray5");
            Console.WriteLine("2- EscribeArray");
            Console.WriteLine("3- LeeArray5");
            Console.WriteLine("4- LeeArray");
            Console.WriteLine("5- PonCeros5");
            Console.WriteLine("6- PonCero");
            Console.WriteLine("7- SumaArray5");
            Console.WriteLine("8- SumaArray");
            Console.WriteLine("9- MediaArray5");
            Console.WriteLine("10- MediaArray");
            Console.WriteLine("11- RellenaEnOrden");
            Console.WriteLine("12- RellenaEnOrdenDesc");
            Console.WriteLine("13- RellenaAleatorio");
            Console.WriteLine("14- EstaOrdenado");
            Console.WriteLine("15- NumeroImpares");
            Console.WriteLine("16- MinArray");
            Console.WriteLine("17- MaxArray");
            Console.WriteLine("18- NumeroAprobados");
            Console.WriteLine("19- PorEncimaDe");
            Console.WriteLine("20- CuantosCero");
            Console.WriteLine("21- CopiaArray");
            Console.WriteLine("22- CopiaArrayInvertido");
            Console.WriteLine("23- SumaArrays");
            Console.WriteLine("24- Resta,Dvide y Multiplica Arrays");
            Console.WriteLine("25- InvierteArray");
            Console.WriteLine("26- Compara Arrays");
            Console.WriteLine("27- PonNotasArray");
            Console.WriteLine("28- ConcatenaArrays55");
            Console.WriteLine("29- ConcatenaArrays");
            Console.WriteLine("30- Contiene");
            Console.WriteLine("31- ConcatenaArraysPro");
            Console.WriteLine("32- CopiaArrayPro");
            Console.WriteLine("33- InstertaEnArray");
            Console.WriteLine("34- BorraDeArray");
            Console.WriteLine("35- Elimina1ElemntoArray");
            Console.WriteLine("36- ELiminarElementosArray");
            Console.WriteLine("37- InsertaArrayEnArray");
            Console.WriteLine("38- SubArray");
            Console.WriteLine("39-RecortaArray");
            Console.WriteLine("40-OrdenaBurbuja");
            Console.WriteLine("41-InsertaEnArrayV2");
            Console.WriteLine(".....");
            Console.WriteLine("0- salir");
            Console.WriteLine();
            Console.Write("Elije una opción:");

            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    {
                        int[] a = { 23, -4, 9, 15, 12 };
                        EscribeArray5(a);
                    }

                    break;
                case 2:
                    {
                        int[] a = { 23, -4, 9, 15, 12 };
                        EscribeArray(a);
                    }
                    break;
                case 3:
                    {
                        int[] a=new int[5];
                        LeeArray5(a);
                        EscribeArray5(a);
                    }
                    break;
                case 4:
                    {
                        int[]a= new int[10];
                        LeeArray(a);
                        EscribeArray(a);
                    }
                    break;
                case 5:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        EscribeArray5(a);
                    }
                    break;
                case 6:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        EscribeArray(a);
                    }
                    break;
                case 7:
                    {
                        int[] a = { 5, 7, 10, 8, 12 };
                        Console.WriteLine(SumaArray5(a));
                    }
                    break;
                case 8:
                    {
                        int[] a = {2, 5, 8, 7, 5, 9, 10, 11, 18 };
                        Console.WriteLine(SumaArray(a));
                    }
                    break;
                case 9:
                    {
                        int[] a = { 5, 7, 10, 8, 12 };
                        Console.WriteLine(MediaArray5(a));
                        
                    }
                    break;
                case 10:
                    {
                        int[] a = { 7, 9, 8, 7, 5, 4, 1, 2, 5, 8 };
                        Console.WriteLine(MediaArray(a));
                        
                    }
                    break;
                case 11:
                    {
                        int[] a = new int[8];
                        RellenaEnOrden(a);
                        EscribeArray(a);
                    }
                    break;
                case 12:
                    {
                        int[] a = new int[8];
                        RellenaEnOrdenDesc(a);
                        EscribeArray(a);
                    }
                    break;
                case 13:
                    {
                        int[]a= new int[7];
                        RellenaAleatorio(a);
                        EscribeArray(a);
                    }
                    break;
                case 14:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
                        Console.WriteLine(EstaOrdenado(a));
                    }
                    break;
                case 15:
                    {
                        int[] a = { 1, 3, 5, 2, 2, 2, 2 };
                        Console.WriteLine(NumerosImpares(a));
                    }
                    break;
                case 16:
                    {
                        int []a = { 1, 8, 9, 7, 15, -5 };
                        Console.WriteLine(MinArray(a));
                    }
                    break;
                case 17:
                    {
                        int[] a = { 15, 1, 4, 5, 3, 6, 4, 8 };
                        Console.WriteLine(MaxArray(a));
                    }
                    break;
                case 18:
                    {
                        double[] a = { 5.4, 4, 3, 5, 1 };
                        Console.WriteLine(NumeroAprobados(a));
                    }
                    break;
                case 19:
                    {
                        int[] a = { 4, 5, 11, 13, 5, 6, 8, 7, 9 };
                        Console.WriteLine(PorEncimaDe(a, 10)); 
                    }
                    break;
                case 20:
                    {
                        int []a = { 1, 4, 5, 9, 0, 5, 0 };
                        Console.WriteLine(CuantosCero(a));
                    }
                    break;
                case 21:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] b = new int[5];
                        CopiaArray(a, b);
                        EscribeArray(b);
                    }
                    break;
                case 22:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[]b=new int[5];
                        CopiaArrayInvertido(a, b);
                        EscribeArray(b);
                    }
                    break;
                case 23:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] b = { 2, 3, 4, 5, 8};
                        int []c = new int[5];
                        SumaArrays(a, b, c);
                        EscribeArray(a);
                        EscribeArray(b);
                        EscribeArray(c);
                    }
                    break;
                case 24:
                    {
                        Console.Clear();
                        int opcion1;
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] b = { 4, 5, 6, 7, 8 };
                        int[] c = new int[5];
                        Console.WriteLine("1-RestaArrays 2-DivideArrays 3-MultiplicaArrays");
                        opcion1 = int.Parse(Console.ReadLine());
                        switch (opcion1)
                        {
                            case 1:RestaArrays(b, a, c);
                                EscribeArray(c);
                                break;
                            case 2:DivideArrays(b, a, c);
                                EscribeArray(c);
                                break;
                            case 3:MultiplicaArrays(a, b, c);
                                EscribeArray(c);
                                break;
                        }
                    }
                    break;
                case 25:
                    {
                        int[] a = { 1, 2, 3 };
                        InvierteArrays(a);
                        EscribeArray(a);
                    }
                    break;
                case 26:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] b = { 1, 2, 3, 4};
                        Console.WriteLine(ComparaArrays(a, b));
                    }
                    break;
                case 27:
                    {
                        double[] a = { 5.4, 4, 3, 9, 7.5 };
                        bool[] b = new bool[5];
                        PonNotasArray(a, b);
                        EscribeArrayBooleano(b);
                    }
                    break;
                case 28:
                    {
                        int[] a = { 1, 2, 3, 4, 5 };
                        int[] b = { 6, 7, 8, 9, 10 };
                        int[] c = new int[10];
                        ConcatenaArrays55(a, b, c);
                        EscribeArray(c);
                    }
                    break;
                case 29:
                    {
                        int[] a = { 1, 2, 3, 4 };
                        int[] b = { 5, 6, 7 };
                        int[] c = new int[a.Length + b.Length];
                        ConcatenaArrays(a, b, c);
                        EscribeArray(c);
                    }
                    break;
                case 30:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 8, 7, 4, 10 };
                        int b = 15;
                        Console.WriteLine(Contiene(a, b));
                    }
                    break;
                case 31:
                    {
                        int[] a = { 1, 2, 3 };
                        int[] b = { 4, 5 };
                        int[] c;
                        c =ConcatenaArrayPro(a, b);
                        EscribeArray(c);
                    }
                    break;
                case 32:
                    {
                        int[] a = { 12, 4, 5 };
                        int[] b;
                        b = CopiaArrayPro(a);
                        EscribeArray(b);
                    }
                    break;
                case 33:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6 };
                        InsertaEnArray(ref a, 10, 2);
                        
                        EscribeArray(a);
                    }
                    break;
                case 34:
                    {
                        int[] a = { 1, 2, 4, 5, 6 };
                        BorraDeArray(ref a, 2);
                        EscribeArray(a);
                    }
                    break;
                case 35:
                    {
                        int[] a = { 1, 2, 4, 5, 9 };
                        Elimina1ElementoArray(ref a, 12);
                        EscribeArray(a);
                    }
                    break;
                case 36:
                    {
                        int[] a = { 1, 2, 4, 5, 6, 7, 2, 1, 3, 4, 5 };
                        EliminaElementosArray(ref a, 2);
                        EscribeArray(a);
                    }
                    break;
                case 37:
                    {
                        int[] a = { 1, 2, 3 };
                        int[] b = { 2, 4, 2, 3, 5 };
                        InsertaArrayEnArray(ref a, 1,ref b);
                        EscribeArray(a);
                    }
                    break;
                case 38:
                    {
                        int[] a = { 1, 3, 5, 7, 8, 5, 4 };
                        int[] b;
                        b=SubArray(a, 2, 5);
                        EscribeArray(b);
                    }
                    break;
                case 39:
                    {
                        int[] a = { 1, 3, 5, 7, 8, 5, 4 };
                        RecortaArray(ref a, 2, 6);
                        EscribeArray(a);
                    }
                    break;
                case 40:
                    {
                        int[] a = { 3,9,4,6,8,1};
                        OrdenaBurbuja(ref a);
                    }
                    break;
                case 41:
                    {
                        int[] a = { 10, 20, 30,40,50 };
                        int[] b = { 2, 3, 4, 2, 3, 5 };
                        InsertaArrayEnArrayv2(ref a, 2, b);
                        EscribeArray(a);
                    }
                    break;
                default:
                    Console.WriteLine("");
                    break;

            }
        }
        static void EscribeArray(int[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }

            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void EscribeArray5(int[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }

            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void LeeArray5(int[] a)
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Dime el valor de ["+i+"]");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void LeeArray(int[] a)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Dime el valor de [" + i + "]");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void PonCeros5(int[] a)
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                a[i] = 0;
            }
        }
        static void PonCero(int[] a)
        {
            int i;
            for (i = 0; i < a.Length ; i++)
            {
                a[i] = 0;
            }
        }
        static int SumaArray5(int[] a)
        {
            int i, total=0;
            for (i = 0; i < 5; i++)
            {
                total = total + a[i];
            }
            return total;
        }
        static int SumaArray(int[] a)
        {
            int i, total = 0;
            for (i = 0; i < a.Length; i++)
            {
                total = total + a[i];
            }
            return total;
        }
        static double MediaArray5(int[] a)
        {
            double media;
            media = SumaArray5(a) / 5.0;
            return media;
        }
        static double MediaArray(int[] a)
        {
            double media;
            double tam = a.Length;
            media = SumaArray(a) / tam;
            return media;
        }
        static void RellenaEnOrden(int[] a)
        {
            int i,j=1;
            for (i = 0; i < a.Length ; i++)
            {
                a[i] = j;
                j++;
            }
        }
        static void RellenaEnOrdenDesc(int[] a)
        {
            int i, j = a.Length;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = j;
                j--;
            }
        }
        static void RellenaAleatorio(int[] a)
        {
            Random r = new Random();
            int i;
            int rand = 0;
            for (i = 0; i < a.Length; i++)
            {
                rand = r.Next(1, 11);
                a[i] = rand;
            }
        }
        static bool EstaOrdenado(int[] a)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    cont++;
                }
            }
            if (cont > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static int NumerosImpares(int[] a)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    cont++;
                }
            }
            
            return cont;
        }
        static int MinArray(int[] a)
        {
            int i, min=a[0];
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static int MaxArray(int[] a)
        {
            int i, max = a[0];
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static int NumeroAprobados(double[] a)
        {
            int i, aprobados = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= 5)
                {
                    aprobados++;
                }
            }
            return aprobados;
        }
        static int PorEncimaDe(int[]a,int lim)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > lim)
                {
                    cont++;
                }
            }
            return cont;
        }
        static int CuantosCero(int[] a)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    cont++;
                }
            }
            return cont;
        }
        static void CopiaArray(int[] a, int[] b)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (a.Length == b.Length)
                {
                    for (i = 0; i < a.Length; i++)
                    {
                        b[i] = a[i];
                    }
                }
                else
                {
                    Console.WriteLine("los arrays no tienen el mismo tamaño");
                }
            }
        }
        static void CopiaArrayInvertido(int[] a, int[] b)
        {
            int i, j=b.Length-1;
            for (i = 0; i < a.Length; i++)
            {
                if (a.Length == b.Length)
                {
                    for (i = 0; i < a.Length; i++)
                    {
                        b[i] = a[j];
                        j--;
                    }
                }
                else
                {
                    Console.WriteLine("los arrays no tienen el mismo tamaño");
                }
            }
        }
        static void SumaArrays(int[] a, int[] b, int[] c)
        {
            if (a.Length != b.Length)
            {
                Console.WriteLine("no tienen el mismo tamaño");
            }
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] + b[i];
            }
        }
        static void RestaArrays(int[] a, int[] b, int[] c)
        {
            if (a.Length != b.Length)
            {
                Console.WriteLine("no tienen el mismo tamaño");
            }
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] - b[i];
            }
        }
        static void DivideArrays(int[] a, int[] b, int[] c)
        {
            if (a.Length != b.Length)
            {
                Console.WriteLine("no tienen el mismo tamaño");
            }
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] / b[i];
            }
        }
        static void MultiplicaArrays(int[] a, int[] b, int[] c)
        {
            if (a.Length != b.Length)
            {
                Console.WriteLine("no tienen el mismo tamaño");
            }
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i] * b[i];
            }
        }
        static void InvierteArrays(int[] a)
        {
            int []b = new int[a.Length];
            
            CopiaArrayInvertido(a, b);
            CopiaArray(b, a);
        }
        static bool ComparaArrays(int[] a, int[] b)
        {
            int i, cont = 0;
            if (a.Length != b.Length)
            {
                return false;
            }
            else
            {
                for (i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        cont++;
                    }
                }
            }
            if (cont != 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        static void PonNotasArray(double[] a, bool[] b)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= 5)
                {
                    b[i] = true;
                }
                else
                {
                    b[i] = false;
                }
            }
        }
        static void EscribeArrayBooleano(bool[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ",");
                }

            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void ConcatenaArrays55(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (i = 0; i < b.Length; i++)
            {
                c[i + 5] = b[i];
            }
        }
        static void ConcatenaArrays(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (i = 0; i < b.Length; i++)
            {
                c[i+a.Length] = b[i];
            }
        }
        static bool Contiene(int[]a,int num)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    cont++;
                }
            }
            if (cont != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int[] ConcatenaArrayPro(int[] a, int[] b)
        {
            int i;
            int[] c = new int[a.Length + b.Length];
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }
            return c;
        }
        static int[] CopiaArrayPro(int[] a)
        {
            int[] b = new int[a.Length];
            int i;
            for (i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            return b;
        }
        static void InsertaEnArray(ref int[] a,int val,int pos)
        {
            int i;
            Array.Resize(ref a, a.Length + 1);
            for (i = a.Length - 1; i > pos; i--)
            {
                a[i] = a[i - 1];
            }
            a[pos] = val;
            
        }
        static void BorraDeArray(ref int[]a,int pos)
        {
            int i;
            for (i = pos; i < a.Length-1; i++)
            {
                a[i] = a[i+1];
            }
            Array.Resize(ref a, a.Length - 1);
        }
        static void Elimina1ElementoArray(ref int[]a,int val)
        {
            int i, pos=-1;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == val)
                {
                    pos = i;
                    i = a.Length;
                }
            }
            if (pos != -1)
            {
                BorraDeArray(ref a, pos);
            }
            
        }
        static void EliminaElementosArray(ref int[]a,int val)
        {
            int i, pos = -1, tam = a.Length;
            for (i = 0; i < tam; i++)
            {
                if (a[i] == val)
                {
                    pos = i;
                    BorraDeArray(ref a, pos);
                    tam = tam - 1;
                }
            }
        }
        static void InsertaArrayEnArray(ref int[]a,int pos,ref int[] b)
        {
            int i;
            
            for (i = 0; i < b.Length; i++)
            {
                InsertaEnArray(ref a, b[i],pos);
                pos++;
            }
        }
        static void InsertaArrayEnArrayv2(ref int[]a,int pos, int[] b)
        {
            int i,j=a.Length-1;
            Array.Resize(ref a, a.Length + b.Length);
            for (i = a.Length - 1; j >= pos; i--)
            {
                a[i] = a[j];
                j--;
                EscribeArray(a);
            }
            for (i = 0; i < b.Length; i++)
            {
                a[pos] = b[i];
                pos++;
            }
        }
        static void RecortaArray(ref int[]a,int pos1,int pos2)
        {
            int i;
            
            for (i = pos1; i < pos2+1; i++)
            {
                a[i - pos1] = a[i];
            }
            Array.Resize(ref a, pos2-(pos1-1));

        }
        static int [] SubArray(int[]a,int pos1,int pos2)
        {
            int i;
            int[] b = new int[pos2 - (pos1 - 1)];
            for (i = 0; i < b.Length; i++)
            {
                b[i] = a[i+pos1];
            }
            return b;
        }
        static void OrdenaBurbuja(ref int[] a)
        {
            int i, j, aux;
            for (i = 0; i < a.Length - 1; i++)
            {
                for (j = 0; j < a.Length-1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        aux = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = aux;
                    }
                }
                EscribeArray(a);
            }
        }
    }
}
