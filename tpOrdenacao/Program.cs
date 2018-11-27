using System;
using System.Diagnostics;

namespace tpOrdenacao
{
    class Program
    {
        static void Preencher(int[] vetor1, int[] vetor2, int[] vetor3)
        {
            for (int i = 0; i <= vetor1.Length - 1; i++)//CRESCENTE
            {
                vetor1[i] = i + 1;
            }

            for (int i = vetor2.Length - 1; i >= 1; i--)//DECRESCENTE
            {
                vetor2[i] = i + 1;
            }

            for (int i = 0; i <= vetor3.Length - 1; i++)//NÚMEROS ALEATÓRIOS
            {
                vetor3[i] = RandomNumber(0, 10000);
            }
        }

        public static void Main()
        {
            int[] vetor1;
            int[] vetor2;
            int[] vetor3;

            bool sair = false;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(
                "\n\t╔════CONTAGEM DE TEMPO DA ORDENAÇÃO════╗");
                Console.WriteLine(
                "\t║                                      ║\n" +
                "\t║      [1] = BubbleSort                ║\n" +
                "\t║      [2] = InsertionSort             ║\n" +
                "\t║      [3] = SelectionSort             ║\n" +
                "\t║      [4] = MergeSort                 ║\n" +
                "\t║      [5] = QuickSort                 ║\n" +
                "\t║                                      ║\n" +
                "\t╚══════════════════════════════════════╝\n");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\tINSIRA A OPÇÃO ESCOLHIDA: ");
                Console.ResetColor();

                Stopwatch timer = new Stopwatch();// O comando Stopwatch conta o tempo que o programa levou para ler um metodo

                bool bubble = false;
                bool insertion = false;
                bool selection = false;
                bool merge = false;
                bool quick = false;

                var menu = Console.ReadKey();
                Console.WriteLine("\n");

                if (bubble = menu.KeyChar == '1')
                {
                    vetor1 = new int[100000];
                    vetor2 = new int[100000];
                    vetor3 = new int[100000];

                    Preencher(vetor1, vetor2, vetor3);

                    timer.Start();
                    bubbleSort(vetor1);
                    timer.Stop();
                    TimeSpan tempoBubble1 = timer.Elapsed;//declara o tempo que levou para decorrer o bubblesort
                    timer.Reset();

                    timer.Start();
                    bubbleSort(vetor2);
                    timer.Stop();
                    TimeSpan tempoBubble2 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    bubbleSort(vetor3);
                    timer.Stop();
                    TimeSpan tempoBubble3 = timer.Elapsed;
                    timer.Reset();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\tBubble Sort no 1º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble1.Minutes, tempoBubble1.Seconds, tempoBubble1.Milliseconds);
                    Console.WriteLine("\tBubble Sort no 2º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble2.Minutes, tempoBubble2.Seconds, tempoBubble2.Milliseconds);
                    Console.WriteLine("\tBubble Sort no 3º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoBubble3.Minutes, tempoBubble3.Seconds, tempoBubble3.Milliseconds);
                    timer.Reset();
                    Console.ResetColor();
                }

                else if (insertion = menu.KeyChar == '2')
                {
                    vetor1 = new int[100000];
                    vetor2 = new int[100000];
                    vetor3 = new int[100000];

                    timer.Start();
                    InsertionSort(vetor1);
                    timer.Stop();
                    TimeSpan tempoInsertion1 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    InsertionSort(vetor2);
                    timer.Stop();
                    TimeSpan tempoInsertion2 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    InsertionSort(vetor3);
                    timer.Stop();
                    TimeSpan tempoInsertion3 = timer.Elapsed;
                    timer.Reset();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\tInsertion Sort no 1º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion1.Minutes, tempoInsertion1.Seconds, tempoInsertion1.Milliseconds);
                    Console.WriteLine("\tInsertion Sort no 2º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion2.Minutes, tempoInsertion2.Seconds, tempoInsertion2.Milliseconds);
                    Console.WriteLine("\tInsertion Sort no 3º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoInsertion3.Minutes, tempoInsertion3.Seconds, tempoInsertion3.Milliseconds);
                    timer.Reset();
                    Console.ResetColor();
                }

                else if (selection = menu.KeyChar == '3')
                {
                    vetor1 = new int[100000];
                    vetor2 = new int[100000];
                    vetor3 = new int[100000];

                    Preencher(vetor1, vetor2, vetor3);

                    timer.Start();
                    SelectionSort(vetor1);
                    timer.Stop();
                    TimeSpan tempoSelection1 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    SelectionSort(vetor2);
                    timer.Stop();
                    TimeSpan tempoSelection2 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    SelectionSort(vetor3);
                    timer.Stop();
                    TimeSpan tempoSelection3 = timer.Elapsed;
                    timer.Reset();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\tSelection Sort no 1º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection1.Minutes, tempoSelection1.Seconds, tempoSelection1.Milliseconds);
                    Console.WriteLine("\tSelection Sort no 2º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection2.Minutes, tempoSelection2.Seconds, tempoSelection2.Milliseconds);
                    Console.WriteLine("\tSelection Sort no 3º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoSelection3.Minutes, tempoSelection3.Seconds, tempoSelection3.Milliseconds);
                    timer.Reset();
                    Console.ResetColor();
                }

                else if (merge = menu.KeyChar == '4')
                {
                    vetor1 = new int[100000];
                    vetor2 = new int[100000];
                    vetor3 = new int[100000];

                    Preencher(vetor1, vetor2, vetor3);

                    timer.Start();
                    MergeSort(vetor1, vetor1[0], vetor1.Length - 1);
                    timer.Stop();
                    TimeSpan tempoMerge1 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    MergeSort(vetor2, vetor2[0], vetor2.Length - 1);
                    timer.Stop();
                    TimeSpan tempoMerge2 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    MergeSort(vetor3, vetor3[0], vetor3.Length - 1);
                    timer.Stop();
                    TimeSpan tempoMerge3 = timer.Elapsed;
                    timer.Reset();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\tMerge Sort no 1º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge1.Minutes, tempoMerge1.Seconds, tempoMerge1.Milliseconds);
                    Console.WriteLine("\tMerge Sort no 2º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge2.Minutes, tempoMerge2.Seconds, tempoMerge2.Milliseconds);
                    Console.WriteLine("\tMerge Sort no 3º Vetor: {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoMerge3.Minutes, tempoMerge3.Seconds, tempoMerge3.Milliseconds);
                    timer.Reset();
                    Console.ResetColor();
                }

                else if (quick = menu.KeyChar == '5')
                {
                    vetor1 = new int[10000];
                    vetor2 = new int[10000];
                    vetor3 = new int[10000];
                    Preencher(vetor1, vetor2, vetor3);

                    timer.Start();
                    QuickSort(vetor1, vetor1[0], (vetor1.Length - 1));
                    timer.Stop();
                    TimeSpan tempoQuick1 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    QuickSort(vetor2, (vetor2.Length - 1), vetor2[0]);
                    timer.Stop();
                    TimeSpan tempoQuick2 = timer.Elapsed;
                    timer.Reset();

                    timer.Start();
                    QuickSort(vetor3, vetor3[0], (vetor3.Length - 1));
                    timer.Stop();
                    TimeSpan tempoQuick3 = timer.Elapsed;
                    timer.Reset();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\tQuickSort no 1º Vetor:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick1.Minutes, tempoQuick1.Seconds, tempoQuick1.Milliseconds);
                    Console.WriteLine("\tQuickSort no 2º Vetor:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick2.Minutes, tempoQuick2.Seconds, tempoQuick2.Milliseconds);
                    Console.WriteLine("\tQuickSort no 3º Vetor:  {0} Minutos, {1} Segundo e {2} Milisegundos ", tempoQuick3.Minutes, tempoQuick3.Seconds, tempoQuick3.Milliseconds);
                    timer.Reset();
                    Console.ResetColor();
                }

                else if (menu.KeyChar > 5)
                Console.WriteLine("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\n\tAperte 'R' para Resetar");
                Console.ResetColor();

                var end = Console.ReadKey();
                sair = end.KeyChar == 'R' || end.KeyChar == 'r';
                Console.WriteLine("\n");
            } while (sair);

            Console.ReadKey();
        }

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static void bubbleSort(int[] Vetor)
        {
            int aux = 0;
            for (int i = 0; i < Vetor.Length; i++)
            {
                for (int j = 0; j < Vetor.Length - 1; j++)
                {
                    if (Vetor[j] > Vetor[j + 1])
                    {
                        aux = Vetor[j + 1];
                        Vetor[j + 1] = Vetor[j];
                        Vetor[j] = aux;
                    }
                }
            }
        }

        static void InsertionSort(int[] vetor)
        {
            int n = vetor.Length;
            for (int i = 1; i < n; ++i)
            {
                int aux = vetor[i];
                int j = i - 1;

                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j = j - 1;
                }
                vetor[j + 1] = aux;
            }
        }

        static void SelectionSort(int[] Vetor)
        {
            int menor, i, j, aux;
            for (i = 0; i < Vetor.Length - 1; i++)
            {
                menor = i;
                for (j = i; j < Vetor.Length; j++)
                {
                    if (Vetor[j] < Vetor[menor])
                        menor = j;
                    aux = Vetor[menor];
                    Vetor[menor] = Vetor[i];
                    Vetor[i] = aux;
                }
            }
        }

        public static void MergeSort(int[] vetor, int vetorum, int vetortres)
        {
            if (vetorum < vetortres)
            {
                int meio = (vetorum + vetortres) / 2;

                MergeSort(vetor, vetorum, meio);
                MergeSort(vetor, meio + 1, vetortres);

                //Merge
                int[] leftArray = new int[meio - vetorum + 1];
                int[] rightArray = new int[vetortres - meio];

                //Copia os valores ordenados em left e right e faz um merge de novo
                Array.Copy(vetor, vetorum, leftArray, 0, meio - vetorum + 1);
                Array.Copy(vetor, meio + 1, rightArray, 0, vetortres - meio);

                int i = 0;
                int j = 0;
                for (int k = vetorum; k < vetortres + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        vetor[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        vetor[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        vetor[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        vetor[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }

        static public void QuickSort(int[] vetor, int vetorum, int vetortres)
        {
            int menor, maior, meio, organi, aux;
            menor = vetorum;
            maior = vetortres;
            meio = (int)((menor + maior) / 2);
            organi = vetor[meio];

            while (menor <= maior)
            {
                while (vetor[menor] < organi)
                    menor++;
                while (vetor[maior] > organi)
                    maior--;

                if (menor < maior)
                {
                    aux = vetor[menor];
                    vetor[menor++] = vetor[maior];
                    vetor[maior--] = aux;
                }
                else
                {
                    if (menor == maior)
                    {
                        menor++;
                        maior--;
                    }
                }
            }

            if (maior > vetorum)
                QuickSort(vetor, vetorum, maior);
            if (menor < vetortres)
                QuickSort(vetor, menor, vetortres);
        }
    }
}