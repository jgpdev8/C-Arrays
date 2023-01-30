using System;

namespace ArraysAdicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1- IntercambiaParesImpares");
            Console.WriteLine("2- CompruebaTarjeta");
            Console.WriteLine("3- TailArray");
            Console.WriteLine("4- Detecta5");
            Console.WriteLine("5- CalculaNPrimos");
            Console.WriteLine("6- EscribeArrayEnNotas");
            Console.WriteLine("7- TachaElementosNoComunes");
            Console.WriteLine("8- EliminaRepetidos");
            Console.WriteLine("9- RedondeaArray");
            Console.WriteLine("10- DesordenaArray");
            Console.WriteLine("11 -MinMaxArray");
            Console.WriteLine("12- GráficaBarras");
            Console.WriteLine("13- MejorRacha");
            Console.WriteLine("14- NumeroPrimosPro");
            Console.WriteLine("15- SucesionFibonaci");
            Console.WriteLine("16- SeriesMundiales");
            Console.WriteLine("17- ElementosComunes3");
            Console.WriteLine("18- SeparaNegativosPositivos");
            Console.WriteLine("19- SumaPosicionesPares");
            Console.WriteLine("20- ArrayCapicua");
            Console.WriteLine("21- TroceaArray");

            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    {
                        int[] a = { 1, 4, 5, 9, 3, 6, 4, 8 };
                        IntercambiaParesImpares(ref a);
                        EscribeArray(a);
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        int[] a = { 4, 9, 2, 9, 9, 9, 6, 8, 6, 1, 5, 0, 1, 7, 5, 6 };
                        Console.WriteLine(CompruebaTarjeta(a));
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };


                        EscribeArray(TailArray(ref a, 4));
                    }
                    break;
                case 4:
                    {
                        int[] a = { 1, 1, 1, 1, 2 };
                        Console.WriteLine(Detecta5(a));
                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        EscribeArrayBool(CalculaNPrimos(20));
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        double[] a = { 5, 7, 4, 8.5, 9, -5 };
                        EscribeArrayNotas(a);
                    }
                    break;
                case 7:
                    {
                        int[] a = { 1, 3, 5, 7 };
                        int[] b = { 1, 2, 3, 4 };
                        TachaELementosNoComunes(ref a, ref b);
                        EscribeArray(a);
                        EscribeArray(b);
                    }
                    break;
                case 8:
                    {
                        int[] a = { 1, 5, 9, 2, 3, 4, 1, 1, 2 };

                        EscribeArray(EliminaRepetidos(a));
                    }
                    break;
                case 9:
                    {
                        Console.Clear();
                        double[] a = { 9.34, 8.36, 7.59, 9.12 };

                        EscribeArrayDouble(DecimalesArray(ref a));
                    }
                    break;
                case 10:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        EscribeArray(DesordenaArray(a));
                    }
                    break;
                case 11:
                    {
                        int[] a = { 3, 5, 4, 6, 4, 13, 4 };
                        EscribeArray(MinMaxArray(a));
                    }
                    break;
                case 12:
                    {
                        Console.Clear();
                        int[] a = { 1, 4, 6, 8, 5, 10 };
                        GraficaBarras(a);
                    }
                    break;
                case 13:
                    {
                        Console.Clear();
                        int[] a = { 1, 0, 2, 0, 4, 0, 1, 2, 2, 2, 2, 3, 1, 0, 2, 0 };

                        Console.WriteLine(MejorRacha(a));
                    }
                    break;
                case 14:
                    {
                        NumeroPrimosPro(400000000);
                    }
                    break;
                case 15:
                    {
                        int[] a = new int[14];
                        SucesionFibonaci(a);
                        EscribeArray(a);
                    }
                    break;
                case 16:
                    {
                        int[] a = { 4, 3, 8, 3 };
                        string local = "Madrid";
                        string visitante = "Barcelona";
                        Console.WriteLine(SeriesMundiales(local, visitante, a));
                    }
                    break;
                case 17:
                    {
                        int[] a = { 1, 3, 5, 7 };
                        int[] b = { 2, 3, 4, 5, 6, 7 };
                        int[] c = { 1, 2, 3, 4, 5 };
                        ElementosComunes3(a, b, c);
                    }
                    break;
                case 18:
                    {
                        int[] a = { -1, 5, -4, 5 };
                        EscribeArray(SeparaNegativosPositivos(a));

                    }
                    break;
                case 19:
                    {
                        int[] a = { 1, 2, 5, 3, 1, 4 };
                        Console.WriteLine(SumaPosicionesPares(a));
                    }
                    break;
                case 20:
                    {
                        int[] a = { 1, 2, 3, 2, 1};
                        Console.WriteLine(ArrayCapicua(a));
                    }
                    break;
                case 21:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int[] b = new int[5];
                        int[] c= new int[5];
                        TroceaArray(a,b,c);
                        EscribeArray(b);
                        EscribeArray(c);
                        
                    }
                    break;
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
        static void EscribeArrayDouble(double[] array)
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
        static void EscribeArrayBool(bool[] array)
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
        static void IntercambiaParesImpares(ref int[] a)
        {
            int i, aux;
            if (a.Length % 2 != 0)
            {
                Console.WriteLine("Error , el tamaño del array no es par");
            }
            else
            {
                for (i = 0; i < a.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        aux = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = aux;
                    }
                }
            }
        }
        static bool CompruebaTarjeta(int[] a)
        {
            int i, suma = 0, aux;
            if (a.Length != 16)
            {
                return false;
            }
            else
            {
                for (i = 0; i < a.Length; i++)
                {
                    if (i % 2 == 0)
                    {

                        aux = a[i] * 2;
                        if (aux >= 10)
                        {
                            aux = aux - 9;
                            suma = suma + aux;
                        }
                        else
                        {
                            suma = suma + aux;
                        }
                    }
                    else
                    {
                        suma = suma + a[i];
                    }
                }
                Console.WriteLine(suma);
                if (suma % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        static int[] TailArray(ref int[] a, int tam)
        {
            int[] b = new int[tam];
            int i, j = 0;
            for (i = a.Length - tam; i < a.Length; i++)
            {
                b[j] = a[i];
                j++;
            }
            return b;
        }
        static bool Detecta5(int[] a)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    cont++;
                    if (cont == 4)
                    {
                        return true;
                    }
                }
                else
                {
                    cont = 0;
                }
            }
            return false;
        }
        static bool[] CalculaNPrimos(int max)
        {
            int i, j = 0;

            bool[] a = new bool[max];
            for (i = 0; i < max; i++)
            {
                if (Primo(i))
                {
                    a[j] = true;
                    j++;
                }
                else
                {
                    a[j] = false;
                    j++;
                }
            }
            return a;


        }
        static bool Primo(int n)
        {
            int contador = 2, i;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    contador = contador + 1;
                    break;
                }
            }
            if (contador == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void EscribeArrayNotas(double[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < array.Length; i++)
            {

                if (array[i] >= 5 && array[i] <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(array[i]);

                }
                else
                {
                    if (array[i] < 5 && array[i] >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Error");
                    }
                }
                if (i == array.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(",");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void TachaELementosNoComunes(ref int[] a, ref int[] b)
        {
            int i, j = 0, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < b.Length; j++)
                {

                    if (a[i] == b[j])
                    {
                        cont++;
                    }

                }
                if (cont == 0)
                {
                    a[i] = 0;
                }
                cont = 0;
            }
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < b.Length; j++)
                {

                    if (b[i] == a[j])
                    {
                        cont++;
                    }

                }
                if (cont == 0)
                {
                    b[i] = 0;
                }
                cont = 0;
            }



        }
        static int[] EliminaRepetidos(int[] a)
        {
            int i, pos = 0, j, cont;
            int[] b = new int[a.Length];
            for (i = 0; i < a.Length; i++)
            {
                cont = 0;
                for (j = 0; j < pos; j++)
                {
                    if (a[i] == b[j])
                    {
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    b[pos] = a[i];
                    pos++;
                }
            }
            Array.Resize(ref b, pos);
            return b;

        }

        static int NumeroVecesSeRepite(int[] a, int n)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (n == a[i])
                {
                    cont++;
                }
            }
            return cont;
        }
        static double[] RedondeaArray(ref double[] a)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = Math.Truncate(a[i]);
            }
            return a;
        }
        static double[] DecimalesArray(ref double[] a)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = a[i] - Math.Truncate(a[i]);
            }
            return a;
        }
        static int[] DesordenaArray(int[] a)
        {
            int[] b = new int[a.Length];
            int[] c = new int[a.Length];
            Random r = new Random();
            int i = 0, aux;

            for (i = 0; i < c.Length; i++)
            {
                c[i] = -1;
            }

            for (i = 0; i < a.Length; i++)
            {
                aux = r.Next(0, a.Length);

                while (ExisteEnArray(c, aux))
                {
                    aux = r.Next(0, a.Length);
                }
                b[i] = a[aux];
                c[i] = aux;

            }
            return b;
        }
        static bool ExisteEnArray(int[] a, int n)
        {
            int i, cont = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
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
        static int[] MinMaxArray(int[] a)
        {
            int[] b;
            int i, max, min, j;
            max = MaxDeArray(a);
            min = MinDeArray(a);
            b = new int[(max - min) + 1];
            j = min;
            for (i = 0; i < b.Length; i++)
            {
                b[i] = j;
                j++;
            }
            return b;
        }
        static int MinDeArray(int[] a)
        {
            int i, min;
            min = a[0];
            for (i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;

        }
        static int MaxDeArray(int[] a)
        {
            int i, max;
            max = a[0];
            for (i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void GraficaBarras(int[] a)
        {
            int i, j;
            Console.WriteLine();
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < 0 || a[i] > 10)
                {
                    Console.WriteLine("ERROR");
                }

            }
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < 10)
                {
                    Console.Write(" ");
                }

                Console.Write(a[i] + " ");
                if (a[i] >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                for (j = 0; j < a[i]; j++)
                {
                    Console.Write("██");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        static int MejorRacha(int[] a)
        {
            int i, racha = 0, mejor = 0;
            if (a.Length % 2 != 0)
            {
                Console.WriteLine("Error en los resultados");
            }
            else
            {
                for (i = 0; i < a.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (a[i] > a[i + 1])
                        {
                            racha++;
                        }
                        else
                        {
                            if (mejor < racha)
                            {
                                mejor = racha;
                            }
                            racha = 0;
                        }
                    }
                }

            }
            return mejor;

        }
        static void NumeroPrimosPro(int n)
        {
            int i, aux, cont = 0;
            int[] a = new int[n];
            for (i = 2; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    aux = i;
                    while (aux + i < n)
                    {

                        aux = aux + i;
                        a[aux] = -1;
                    }
                }
            }

            for (i = 2; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    Console.Write(i + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Hay " + cont + " numeros primos");
        }
        static void SucesionFibonaci(int[] a)
        {
            int i;
            a[1] = 1;
            for (i = 2; i < a.Length; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }
        }
        static string SeriesMundiales(string local, string visitante, int[] a)
        {
            int i, vis = 0, loc = 0;
            string resultado;
            if (a.Length % 2 != 0)
            {
                resultado = "ERROR";
            }
            else
            {
                for (i = 1; i < a.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (a[i] < a[i - 1])
                        {
                            vis++;
                        }
                        else
                        {
                            if (a[i] > a[i - 1])
                            {
                                loc++;
                            }
                            else
                            {
                                resultado = "ERROR";
                                i = a.Length;
                            }
                        }
                    }
                }
                if (loc > vis)
                {
                    resultado = local;
                }
                else
                {
                    if (loc == vis)
                    {
                        resultado = "ERROR";
                    }
                    else
                    {
                        resultado = visitante;
                    }
                }
            }
            return resultado;
        }
        static void ElementosComunes3(int[] a, int[] b, int[] c)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                
                if (ApareceEnArray(b, a[i]) && ApareceEnArray(c, a[i]))
                {
                    Console.Write(a[i]+" , ");
                }
            }
            
        }
        static bool ApareceEnArray(int[]a,int num)
        {
            int i, cont=0;
            for (i = 0; i < a.Length; i++)
            {
                if (num == a[i])
                {
                    cont++;
                }
            }
            if (cont > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int[] SeparaNegativosPositivos(int[] a)
        {
            int[] b = new int[a.Length];
            int i, j = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    b[j] = a[i];
                    j++;
                }
            }
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    b[j] = a[i];
                    j++;
                }
            }
            return b;
        }
        static int SumaPosicionesPares(int[] a)
        {
            int i, suma = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + a[i];
                }
            }
            return suma;
        }
        static bool ArrayCapicua(int[] a)
        {
            int i, j, cont = 0;
            j = a.Length-1;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] != a[j])
                {
                    cont++;  
                }
                j--;
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
        static void TroceaArray(int[] a, int[] b, int[] c)
        {
            int i, j=0;
            if (a.Length != (b.Length + c.Length))
            {
                Console.WriteLine("Error"); 
            }
            for (i = 0; i < b.Length; i++)
            {
                b[i] = a[i];
            }
            for (i = b.Length; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }
        }


    }
    
}
