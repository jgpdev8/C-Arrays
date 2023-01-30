using System;

namespace Ocalimocho
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            

            string[] jugadores;
            int[] posiciones;
            int i = 0, dado, aux;
            jugadores=NumeroDeJugadores();
            Console.WriteLine();
            EscribeArrayString(jugadores);
            posiciones = new int[jugadores.Length];
            DibujaTablero(posiciones);
            while (posiciones[i] != 72)
            {
                Console.WriteLine("Es el turno de "+ jugadores[i] + " :");
                dado= TirarDado();
                posiciones[i] = posiciones[i]+ dado;
                Console.WriteLine("has sacado un "+dado+" vas a la posicion " +posiciones[i]);
                Console.WriteLine(Ocalimocho(posiciones[i]));
                
                if (posiciones[i] % 10 == 8 && posiciones[i] != 68)
                {
                    posiciones[i] = posiciones[i] + 10;
                }
                Console.WriteLine(posiciones[i]);
                if (posiciones[i] == 5)
                {
                    posiciones[i] = 32;
                }
                if (posiciones[i] == 13)
                {
                    posiciones[i]=0;
                }
                if (posiciones[i] == 20)
                {
                    i--;
                }
                if (posiciones[i] == 23||posiciones[i]==24||posiciones[i]==31)
                {
                    Console.WriteLine("Pulse para tirar el dado");
                    Console.WriteLine(TirarDado());
                    Console.ReadKey();
                }
                if (posiciones[i] == 29)
                {
                    while(posiciones[i]!=1 || posiciones[i] != 4)
                    {
                        Console.WriteLine("¿Quieres ir a la posicion 1 o 4?");
                        posiciones[i] = int.Parse(Console.ReadLine());
                    }
                }
                if (posiciones[i] == 34)
                {
                    Console.WriteLine("Dime el numero del jugador al que quieres mandar la casilla Nº6");
                    aux = int.Parse(Console.ReadLine());
                    posiciones[aux] = 6;
                }
                if (posiciones[i] == 35)
                {
                    posiciones[i] = 6;
                }
                if (posiciones[i] == 36)
                {
                    Console.WriteLine("Dime el numero del jugador al que quieres mandar la casilla Nº6");
                    for (aux = 0; aux < posiciones.Length; aux++)
                    {
                        Console.WriteLine(aux + " : "+jugadores[aux]);
                    }
                    aux = int.Parse(Console.ReadLine());
                    posiciones[aux] = posiciones[i];
                }
                if (posiciones[i] == 42||posiciones[i]==55||posiciones[i]==59)
                {
                    for (aux = 0; aux < posiciones.Length; aux++)
                    {
                        Console.WriteLine("Pulse para tirar el dado");
                        Console.ReadKey();
                        Console.WriteLine(TirarDado());
                    }
                }
                if (posiciones[i] == 62)
                {
                    for (aux = 0; aux < 5; aux++)
                    {
                        dado = TirarDado();
                        Console.WriteLine(dado);
                        posiciones[i] = posiciones[i] - dado;
                    }
                    Console.WriteLine("has acabado en la casilla "+posiciones[i]);
                }
                if (posiciones[i] == 65)
                {
                    for (aux = 0; aux < posiciones.Length; aux++)
                    {
                        posiciones[aux] = posiciones[aux] - 1;
                    }
                }
                if (posiciones[i] == 70)
                {
                    posiciones[i] = UltimaFicha(posiciones);
                }
                if (posiciones[i] == 49)
                {
                    posiciones[i] = 7;
                    i--;
                }
                if (posiciones[i] == 56)
                {
                    posiciones[i] = 11;
                }
                if (i == jugadores.Length-1)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
                Console.WriteLine("Pulse para continuar");
                Console.ReadKey();

            }




        }
        static void EscribeArrayString(string[] array)
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
        static string [] NumeroDeJugadores()
        {
            int numjugadores;
            string[] jugadores;
            Console.WriteLine("Cuantos jugadores sois:");
            numjugadores = int.Parse(Console.ReadLine());
            jugadores = new string[numjugadores];
            for(int i = 0; i < jugadores.Length; i++)
            {
                Console.WriteLine("Dime el nombre del jugador " + (i+1));
                jugadores[i] = Console.ReadLine();
            }
            return jugadores;

        }
        static int TirarDado()
        {
            int dado;
            
            dado=r.Next(1, 7);
            return dado;
        }
        
        
        static string Ocalimocho(int pos)
        {
            string result;
            string[] oca = new string[72];
            oca[0] = "Salida. Tira el dado";
            oca[1] = "Beben todos";
            oca[2] = "Bebes tú y la ficha más cercana";
            oca[3] = "Bebe el de la izquierda";
            oca[4] = "Bebe el de en frente";
            oca[5] = "Bebes y vas a la casilla Nº32";
            oca[6] = "Bebes";
            oca[7] = "Beben todos menos tú";
            oca[8] = "De 8 a 8 y bebo Calimocho";
            oca[9] = "Manda Beber";
            oca[10] = "Beben los chicos";
            oca[11] = "Bebe el de la derecha";
            oca[12] = "Mandas a alguien beber 2 vasos";
            oca[13] = "Mala Suerte. Bebes el Nº de vasos de la tirada y comienzas el juego";
            oca[14] = "Bebe la ficha más adelantada y la más atrasada";
            oca[15] = "Bebe la niña bonita que tu mandes";
            oca[16] = "Bebes tú un buche, y el primero que se ria bebe 2 buches";
            oca[17] = "Bebes y estas un turno sin tirar";
            oca[18] = "De 8 a 8 y bebo Calimocho";
            oca[19] = "Beben las chicas";
            oca[20] = "Bebes y vuelves a tirar";
            oca[21] = "La aceituna. Vas a la barra y nos compras a todos algo para picar";
            oca[22] = "Los 2 patitos. Bebes 2 buches";
            oca[23] = "Tira el dado. SI sacas tres o menos bebes ese número de buches";
            oca[24] = "Tira el dado. Si sacas cuatro o más bebes ese número de buches";
            oca[25] = "Navidad, bebes un buche y en paz";
            oca[26] = "Beben los que tengas años pares";
            oca[27] = "Beben los que tengan años impares";
            oca[28] = "De 8 a 8 y bebo Calimocho";
            oca[29] = "Bebes un buche y retrocedes a la casilla 1 0 4, tú eliges";
            oca[30] = "El que no tenga en los bolsillos más de 5€, bebe";
            oca[31] = "Tira el dado. Si es impar bebes. Si es par manda a beber";
            oca[32] = "Mandas a beber a dos";
            oca[33] = "Mandas a beber a tres";
            oca[34] = "Bebes y mandas a uno retroceder a la casilla Nº6";
            oca[35] = "Retrocede a la casilla Nº6";
            oca[36] = "Manda beber un buche a quien va primero y trae su ficha aquí";
            oca[37] = "Beben los de las casillas que van por delante tuya";
            oca[38] = "De 8 a 8 y bebo Calimocho";
            oca[39] = "No puedes or a mear antes del final del juego. Si vas bebes 5 buches";
            oca[40] = "Bebes el Nº con el que llegas";
            oca[41] = "Bebe el que menos monedas tenga en los bolsillos";
            oca[42] = "Tiran todos el dado.Beben los que saquen un 1";
            oca[43] = "Beben los que tengan hermanas";
            oca[44] = "Bebes , y el de tu izquierda manda a beber a otro";
            oca[45] = "Cada palabrota que digas bebes 2 buches";
            oca[46] = "Si esta semana ha perdido el Madrid beben todos. Si no bebes tú";
            oca[47] = "Mandas a dos que se beban 1 tequila. Si lo hacen bebes tu otro, si no beben 5 buches";
            oca[48] = "De 8 a 8 y bebo Calimocho";
            oca[49] = "Retrocedes a la casilla Nº7 y tiras otra vez";
            oca[50] = "Mandale a uno empezar de nuevo y beber 2 vasos";
            oca[51] = "Beben los dos de la izquierda y se pagan unas patatas fritas para todos";
            oca[52] = "Beben todos los que tengan el Nº de DNI par";
            oca[53] = "Beben el de la derecha y el de la izquierda";
            oca[54] = "Bebe el de la derecha y él manda a beber a otro";
            oca[55] = "Tiran todos el dado.Beben los que saquen 6";
            oca[56] = "Bebes y retrocedes a la casilla Nº11";
            oca[57] = "Ahora los del DNI impar beben";
            oca[58] = "De 8 a 8 y bebo Calimocho";
            oca[59] = "Tirais todos el dado. El que saque 1 bebe 5 buches y empieza";
            oca[60] = "Tienes que bailar y cantar el Aserejé. Si no lo haces Bebes 10 buches";
            oca[61] = "Beben los que no usen ni gafas ni lentillas";
            oca[62] = "Tira el dado 5 veces, suma y retrocede ese Nº de casillas";
            oca[63] = "Beben los que llevan pantalones vaqueros";
            oca[64] = "Si bebes 4 Buches de golpe los demás beben 2, si no bebes 2";
            oca[65] = "Todos retroceden una casilla, y hay 2 minutos de descanso";
            oca[66] = "Bebes tú y la ficha más lejana";
            oca[67] = "Animo estás cerca. Beben todos 2 buches menos tú";
            oca[68] = "De 8 a 8 y bebo Calimocho";
            oca[69] = "Mandas a dos que se den un morreo. Si no lo hacen beben 10 buches";
            oca[70] = "Bebes tu y te vas a a casilla donde esté la ultima ficha";
            oca[71] = "¡¡¡¡OCALIMOCHO , HAS GANADO!!!";
            result= oca[pos];
            return result;
        }
        static int UltimaFicha(int[] a)
        {
            int min = a[0], i;
            for (i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;  
        }
        static void DibujaTablero(int [] a)
        {
            int[] tablero = new int[72];
            int i;
            for (i = 0; i < tablero.Length; i++)
            {
                tablero[i] = i;
            }
            for (i = 0; i < a.Length; i++)
            {
                tablero[a[i]] = 0;
            }
            for (i = 0; i < tablero.Length; i++)
            {

                if (tablero[i] == 0)
                {
                    Console.Write("X  |");
                }
                else
                {
                    if (tablero[i] < 10)
                    {
                        Console.Write(tablero[i] + "  |  ");
                    }
                    else
                    {
                        Console.Write(tablero[i] + " | ");
                    }
                    
                }
                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }
        }
        


    }
}
