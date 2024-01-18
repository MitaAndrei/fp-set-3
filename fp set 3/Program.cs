using System;
using System.Collections.Generic;

namespace fp_set_3;

class Program
{
    static void Main(string[] args)
    {
        P1();

        Console.ReadLine();
    }

    // 1.Calculati suma elementelor unui vector de n numere citite de la
    // tastatura. Rezultatul se va afisa pe ecran.

    static void P1()
    {
        Console.Write("vector: ");
        char[] sep = { ' ', ',' };
        string[] v = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int[] ab = new int[v.Length];
        for (int i = 0; i < v.Length; i++)
            ab[i] = int.Parse(v[i]);

        Console.WriteLine($"Suma: {ab.Sum()}");

    }

    // 2. Se da un vector cu n elemente si o valoare k. Se cere sa se
    // determine prima pozitie din vector pe care apare k.
    // Daca k nu apare in vector rezultatul va fi -1.

    static void P2()
    {
        Console.Write("vector: ");
        char[] sep = { ' ', ',' };
        string[] ab = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("k = ");
        string k = Console.ReadLine();

        try
        {
            Console.WriteLine(Array.IndexOf(ab, k));
        }
        catch
        {
            Console.WriteLine(-1);
        }
    }


    /// <summary>
    /// 3. Sa se determine pozitiile dintr-un vector pe care
    /// apar cel mai mic si cel mai mare element al vectorului.
    /// Pentru extra-credit realizati programul efectuand 3n/2
    /// comparatii (in cel mai rau caz).
    /// </summary>
    static void P3()
    {
        Console.Write("vector: ");
        char[] sep = { ' ', ',' };
        string[] v = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        int[] ab = new int[v.Length];
        for (int i = 0; i < v.Length; i++)
            ab[i] = int.Parse(v[i]);

        int n = v.Length;
        if (n >= 1)
        {

            int i, min, max;

            if (n % 2 == 1)
            {
                (min, max) = (0, 0);
                i = 1;
            }
            else
            {
                if (ab[0] > ab[1])
                    (min, max) = (1, 0);
                else if (ab[0] < ab[1])
                    (min, max) = (0, 1);
                else
                    (min, max) = (0, 0);
                i = 2;
            }

            while (i < n - 1)
            {

                if (ab[i] > ab[i + 1])
                {
                    if (ab[max] < ab[i])
                        max = i;
                    if (ab[min] > ab[i + 1])
                        min = i + 1;
                }
                else
                {
                    if (ab[max] < ab[i + 1])
                        max = i + 1;
                    if (ab[min] > ab[i])
                        min = i;
                }
                i += 2;
            }

            Console.WriteLine($"\nMin: {min}, Max: {max}");
        }

    }

    /// <summary>
    /// 4. Deteminati printr-o singura parcurgere,
    /// cea mai mica si cea mai mare valoare
    /// dintr-un vector si de cate ori apar acestea
    /// </summary>

    static void P4()
    {
        Console.Write("vector: ");
        char[] sep = { ' ', ',' };
        string[] v = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        int[] ab = new int[v.Length];
        for (int i = 0; i < v.Length; i++)
            ab[i] = int.Parse(v[i]);

        int min = ab[0];
        int max = ab[0];
        int mincnt = 0;
        int maxcnt = 0;

        for (int i = 0; i < ab.Length; i++)
        {
            if (ab[i] < min)
            {
                min = ab[i];
                mincnt = 1;
            }
            else if (ab[i] == min)
                mincnt++;

            if (ab[i] > max)
            {
                max = ab[i];
                maxcnt = 1;
            }
            else if (ab[i] == max)
                maxcnt++;
        }

        Console.WriteLine($"Min = {min}, apare de {mincnt} ori");
        Console.WriteLine($"Max = {max}, apare de {maxcnt} ori");
    }


    /// <summary>
    /// 5. Se da un vector cu n elemente, o valoare e si o
    /// pozitie din vector k. Se cere sa se insereze valoarea
    /// e in vector pe pozitia k. Primul element al vectorului
    /// se considera pe pozitia zero. 
    /// </summary>
    static void P5()
    {

        Console.Write("vector: ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int n = ab.Length;
        Console.Write("e = ");
        string e = Console.ReadLine();
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        string[] abc = new string[n + 1];

        for (int i = 0; i < n + 1; i++)
        {
            if (i < k)
                abc[i] = ab[i];
            else if (i == k)
                abc[i] = e;
            else
                abc[i] = ab[i - 1];
            Console.Write($"{abc[i]} ");
        }
    }


    /// <summary>
    /// 6. Se da un vector cu n elemente si o pozitie din vector k.
    /// Se cere sa se stearga din vector elementul de pe pozitia k.
    /// Prin stergerea unui element, toate elementele din dreapta
    /// lui se muta cu o pozitie spre stanga. 
    /// </summary>
    static void P6()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("vector: ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        string[] abc = new string[n - 1];
        for (int i = 0; i < n; i++)
        {
            if (i < k)
                abc[i] = ab[i];

            else if (i == k)
                continue;
            else
                abc[i - 1] = ab[i];
        }
        Console.WriteLine(String.Join(" ", abc));
    }

    /// <summary>
    /// 7. Reverse. Se da un vector nu n elemente. Se cere sa se
    /// inverseze ordinea elementelor din vector. Prin inversare se
    /// intelege ca primul element devine ultimul, al doilea devine penultimul etc.
    /// </summary>
    static void P7()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("vector: ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(ab);
        Console.WriteLine(String.Join(" ", ab));
    }

    /// <summary>
    /// 8. Rotire. Se da un vector cu n elemente.
    /// Rotiti elementele vectorului cu o pozitie spre stanga.
    /// Prin rotire spre stanga primul element devine ultimul,
    /// al doilea devine primul etc. 
    /// </summary>
    static void P8()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("vector: ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < n - 1; i++)
        {
            (ab[i], ab[i + 1]) = (ab[i + 1], ab[i]);
        }

        Console.WriteLine(String.Join(' ', ab));
    }

    /// <summary>
    /// 9. Rotire k. Se da un vector cu n elemente.
    /// Rotiti elementele vectorului cu k pozitii spre stanga. 
    /// </summary>
    static void P9()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("vector: ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        k = k % n;

        ab = ab[k..].Concat(ab[..k]).ToArray();
        Console.WriteLine(String.Join(' ', ab));
    }

    /// <summary>
    /// 10. Cautare binara. Se da un vector cu n elemente sortat in
    /// ordine crescatoare. Se cere sa se determine pozitia unui
    /// element dat k. Daca elementul nu se gaseste in vector
    /// rezultatul va fi -1. 
    /// </summary>
    static void P10()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("vector: ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int left = 0;
        int right = n - 1;
        int result = -1;
        while (left <= right)
        {

            int middle = (left + right) / 2;
            int abmid = int.Parse(ab[middle]);
            if (abmid == k)
            {
                result = middle;
                break;
            }
            else if (abmid < k)
                left = middle + 1;
            else
                right = middle - 1;

        }
        Console.WriteLine($"Pozitia lui k: {result}");
    }

    /// <summary>
    /// 11. Se da un numar natural n. Se cere sa se afiseze toate
    /// numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
    /// </summary>
    static void P11()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] v = new int[n + 1];

        for (int i = 2; i < n + 1; i++)
        {
            if (v[i] == 0)
            {
                Console.Write($"{i} ");
                for (int j = 2; j <= n / i; j++)
                    v[j * i] = 1;
            }
        }
    }


    /// <summary>
    /// 12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
    /// </summary>
    static void P12()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("vector : ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < n; i++)
        {

            int min = i;
            for (int j = i + 1; j < n; j++)
                if (int.Parse(ab[j]) < int.Parse(ab[min]))
                    min = j;


            (ab[i], ab[min]) = (ab[min], ab[i]);
            Console.Write(ab[i] + " ");
        }

    }

    /// <summary>
    /// 13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
    /// </summary>
    static void P13()
    {
        Console.Write("vector : ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int[] ints = new int[ab.Length];

        for (int k = 0; k < ab.Length; k++)
            ints[k] = int.Parse(ab[k]);


        for (int i = 1; i < ints.Length; i++)
            for (int k = i; k > 0 && ints[k] < ints[k - 1]; k--)
                (ints[k - 1], ints[k]) = (ints[k], ints[k - 1]);

        for (int j = 0; j < ints.Length; j++)
            Console.Write($"{ints[j]} ");

    }


    /// <summary>
    /// 14.Interschimbati elementele unui vector in asa fel incat la final
    /// toate valorile egale cu zero sa ajunga la sfarsit.
    /// (nu se vor folosi vectori suplimentari - operatia se va realiza
    /// inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
    /// </summary>
    static void P14()
    {

        Console.Write("vector : ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int n = ab.Length;

        int[] ints = new int[n];

        for (int k = 0; k < n; k++)
            ints[k] = int.Parse(ab[k]);

        int nonZeroIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if (ints[i] != 0)
            {
                (ints[i], ints[nonZeroIndex]) = (ints[nonZeroIndex], ints[i]);
                nonZeroIndex++;
            }
        }

        for (int j = 0; j < n; j++)
            Console.Write($"{ints[j]} ");

    }

    /// <summary>
    /// 15. Modificati un vector prin eliminarea elementelor care
    /// se repeta, fara a folosi un alt vector.
    /// </summary>
    static void P15()
    {

        Console.Write("vector (elementele vor fi separate prin spatiu sau virgula): ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int n = ab.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
                if (ab[i] == ab[j])
                {
                    for (int k = j; k < n - 1; k++)
                        ab[k] = ab[k + 1];
                    j--;
                    n--;
                }

        }

        Array.Resize(ref ab, n);
        Console.WriteLine(String.Join(' ', ab));
    }


    /// <summary>
    /// 16. Se da un vector de n numere naturale.
    /// Determinati cel mai mare divizor comun al elementelor vectorului.
    /// </summary>
    static void P16()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("vector (elementele vor fi separate prin spatiu sau virgula): ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

        int a = int.Parse(ab[0]);
        for (int i = 1; i < n; i++)
        {
            int b = int.Parse(ab[i]);
            while (b != 0)
                (a, b) = (b, a % b);

        }
        Console.WriteLine($"Cel mai mare divizor comun: {a}");
    }

    /// <summary>
    /// 17. Se da un numar n in baza 10 si un numar b. 1 < b < 17.
    /// Sa se converteasca si sa se afiseze numarul n in baza b.   
    /// </summary>
    static void P17()
    {
        Console.Write("n (partea fractionara se separa prin punct) = ");
        decimal n = Convert.ToDecimal(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int intreg = Convert.ToInt32(Math.Floor(n));
        decimal frac = n - intreg;

        string coresp = "0123456789ABCDEF";
        string result = $"{coresp[intreg % b]}";

        while (intreg / b != 0)
        {
            intreg /= b;
            int abc = intreg % b;
            result = $"{coresp[abc]}" + result;
        }

        result += '.';
        for (int i = 0; i < 20; i++)
        {
            frac *= b;
            int pint = Convert.ToInt32(Math.Floor(frac));
            result += coresp[pint];
            frac -= pint;
            if (frac == 0)
                break;

        }
        Console.WriteLine(result);
    }


    /// <summary>
    /// 18. Se da un polinom de grad n ai carui coeficienti sunt stocati
    /// intr-un vector. Cel mai putin semnificativ coeficient este pe
    /// pozitia zero in vector. Se cere valoarea polinomului intr-un
    /// punct x. 
    /// </summary>
    static void P18()
    {

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("coeficienti: ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double result = 0;

        for (int i = 0; i < n + 1; i++)
        {
            int bb = int.Parse(ab[i]);
            result += bb * Math.Pow(x, i);
        }

        Console.WriteLine(result);
    }

    /// <summary>
    /// 19. Se da un vector s (vectorul in care se cauta) si un vector p
    /// (vectorul care se cauta). Determinati de cate ori apare p in s.
    /// De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
    /// (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
    /// </summary>
    static void P19()
    {
        Console.Write("s: ");
        char[] sep = { ' ', ',' };
        string[] s = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("p: ");
        string[] p = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        int cnt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == p[0])
            {
                bool este = true;

                for (int j = 1; j < p.Length; j++)
                {
                    if (j + i >= s.Length || s[j + i] != p[j])
                    {
                        este = false;
                        break;
                    }
                }

                if (este)
                    cnt++;
            }
        }
        Console.WriteLine(cnt);
    }

    /// <summary>
    /// 20.Se dau doua siraguri de margele formate din margele albe si
    /// negre, notate s1, respectiv s2. Determinati numarul de
    /// suprapuneri (margea cu margea) a unui sirag peste celalalt
    /// astfel incat margelele suprapuse au aceeasi culoare.
    /// Siragurile de margele se pot roti atunci cand le suprapunem. 
    /// </summary>
    static void P20()
    {
        Console.WriteLine("Margele albe - 0, negre - 1");
        Console.Write("s1: ");
        char[] sep = { ' ', ',' };
        string[] s1 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("s2: ");
        string[] s2 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        int max = 0;
        int minlen = Math.Min(s1.Length, s2.Length);
        for (int i = 0; i < minlen; i++)
        {
            int c = 0;
            for (int j = 0; j < minlen; j++)
            {
                if (s1[j] == s2[j])
                    c++;
            }
            if (c > max)
                max = c;


            if (s1.Length == minlen)
                s1 = Rotate(s1);
            else
                s2 = Rotate(s2);
        }

        Console.WriteLine($"Numarul maxim de suprapuneri: {max}");
        static string[] Rotate(string[] arr)
        {
            return arr[1..].Append(arr[0]).ToArray();
        }

    }


    /// <summary>
    /// 21. Se dau doi vectori. Se cere sa se determine ordinea lor
    /// lexicografica (care ar trebui sa apara primul in dictionar). 
    /// </summary>
    static void P21()
    {
        Console.Write("s1: ");
        char[] sep = { ' ', ',' };
        string[] s1 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("s2: ");
        string[] s2 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        string msg = "sunt egale";
        string s1primul = "s1 trebuie sa apara primul", s2primul = "s2 trebuie sa apara primul";

        int minlen = Math.Min(s1.Length, s2.Length);
        for (int i = 0; i < minlen; i++)
        {
            int minlen2 = Math.Min(s1[i].Length, s2[i].Length);
            for (int j = 0; j < minlen2; j++)
            {
                if (s1[i][j] < s2[i][j])
                {
                    msg = s1primul;
                    break;
                }

                else if (s1[i][j] > s2[i][j])
                {
                    msg = s2primul;
                    break;
                }
            }

            if (msg != "sunt egale")
                break;
        }

        Console.WriteLine(msg);
    }


    /// <summary>
    /// 22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia,
    /// reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi).
    /// Elementele care se repeta vor fi scrise o singura data in rezultat. 
    /// </summary>
    static void P22()
    {
        Console.Write("v1: ");
        char[] sep = { ' ', ',' };
        string[] v1 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("v2: ");
        string[] v2 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("Reuniunea: ");
        Console.WriteLine(String.Join(" ", v1.Union(v2)));

        Console.Write("Intersectia: ");
        Console.WriteLine(String.Join(" ", v1.Intersect(v2)));

        Console.Write("v1 - v2: ");
        Console.WriteLine(String.Join(" ", Scadere(v1, v2)));

        Console.Write("v2 - v1: ");
        Console.WriteLine(String.Join(" ", Scadere(v2, v1)));

        static string[] Scadere(string[] s, string[] d)
        {

            string[] result = new string[s.Length];
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!d.Contains(s[i]))
                {
                    result[j] = s[i];
                    j++;
                }
            }

            return result;
        }

    }

    /// <summary>
    /// 23. Aceleasi cerinte ca si la problema anterioara dar de data asta
    /// elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
    /// </summary>
    static void P23()
    {
        P22();
    }

    /// <summary>
    /// Aceleasi cerinte ca si la problema anterioara dar de data
    /// asta elementele sunt stocate ca vectori cu valori binare
    /// (v[i] este 1 daca i face parte din multime si este 0 in caz
    /// contrar).
    /// </summary>
    static void P24()
    {
        Console.Write("v1: ");
        char[] sep = { ' ', ',' };
        string[] v1 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("v2: ");
        string[] v2 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<int, int> a1 = new();
        Dictionary<int, int> a2 = new();

        for (int i = 0; i < Math.Max(v1.Length, v2.Length); i++)
        {
            if (i < v1.Length)
            {
                if (v1[i] == "1")
                    a1[i] = 1;
            }

            if (i < v2.Length)
            {
                if (v2[i] == "1")
                    a2[i] = 1;
            }
        }

        int[] b1 = a1.Keys.ToArray();
        int[] b2 = a2.Keys.ToArray();


        Console.Write("Reuniunea: ");
        Console.WriteLine(String.Join(" ", b1.Union(b2)));

        Console.Write("Intersectia: ");
        Console.WriteLine(String.Join(" ", b1.Intersect(b2)));

        Console.Write("v1 - v2: ");
        Console.WriteLine(String.Join(" ", Scadere(b1, b2)));

        Console.Write("v2 - v1: ");
        Console.WriteLine(String.Join(" ", Scadere(b2, b1)));

        static int[] Scadere(int[] s, int[] d)
        {

            int[] result = new int[s.Length];
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!d.Contains(s[i]))
                {
                    result[j] = s[i];
                    j++;
                }
            }

            return result[..j];
        }

    }



    /// <summary>
    /// (Interclasare) Se dau doi vector sortati crescator v1 si v2.
    /// Construiti un al treilea vector ordonat crescator format din
    /// toate elementele din v1 si v2. Sunt permise elemente duplicate. 
    /// </summary>
    static void P25()
    {
        Console.Write("v1: ");
        char[] sep = { ' ', ',' };
        string[] v1 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("v2: ");
        string[] v2 = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        string[] v3 = new string[v1.Length + v2.Length];

        int v2min = 0, v1min = 0;

        for (int i = 0; i < v3.Length; i++)

            if ((v1min < v1.Length) && (int.Parse(v1[v1min]) <= int.Parse(v2[v2min])))
            {
                v3[i] = v1[v1min];
                v1min++;
            }

            else
            {
                v3[i] = v2[v2min];
                v2min++;
            }

        Console.WriteLine(String.Join(" ", v3));
    }


    /// <summary>
    /// Se dau doua numere naturale foarte mari
    /// (cifrele unui numar foarte mare sunt stocate intr-un vector -
    /// fiecare cifra pe cate o pozitie).
    /// Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
    /// </summary>
    static void P26()
    {
        Console.Write("numarul 1: ");
        string n1 = Console.ReadLine();
        Console.Write("numarul 2: ");
        string n2 = Console.ReadLine();

        int[] v1 = new int[n1.Length];
        int[] v2 = new int[n2.Length];
        int maxlen = Math.Max(v1.Length, v2.Length);

        for (int i = 0; i < maxlen; i++)
        {
            if (i < n1.Length)
                v1[i] = Convert.ToInt32(Convert.ToString(n1[i]));
            if (i < n2.Length)
                v2[i] = Convert.ToInt32(Convert.ToString(n2[i]));
        }

        if (v1.Length < maxlen)
        {
            Array.Reverse(v1);
            Array.Resize(ref v1, maxlen);
            Array.Reverse(v1);
        }
        else if (v2.Length < maxlen)
        {
            Array.Reverse(v2);
            Array.Resize(ref v2, maxlen);
            Array.Reverse(v2);
        }


        static int[] Add(int[] num1, int[] num2, int maxlen)
        {
            int[] result = new int[maxlen];

            int carry = 0;
            for (int i = maxlen - 1; i >= 0; i--)
            {
                int sum = carry + num1[i] + num2[i];
                carry = sum / 10;
                result[i] = sum % 10;
            }

            if (carry > 0)
            {
                Array.Reverse(result);
                Array.Resize(ref result, maxlen + 1);
                result[maxlen] = carry;
                Array.Reverse(result);
            }

            return result;
        }


        static int[] Subtract(int[] num1, int[] num2, int maxlen)
        {
            int[] result = new int[maxlen];

            int borrow = 0;

            for (int i = maxlen - 1; i >= 0; i--)
            {
                int dif = num1[i] - num2[i] - borrow;
                if (dif < 0)
                {
                    dif += 10;
                    borrow = 1;
                }
                else borrow = 0;

                result[i] = dif;

            }

            if (borrow == 1)
            {
                result = Subtract(num2, num1, maxlen);
                result[0] *= -1;
            }

            return RemoveLeadingZeroes(result);
        }

        static int[] Multiply(int[] num1, int[] num2)
        {
            int m = num1.Length, n = num2.Length;
            int[] result = new int[m + n];

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int product = num1[i] * num2[j];

                    int d1 = i + j;
                    int d2 = i + j + 1;

                    product += result[d2];

                    result[d1] += product / 10;
                    result[d2] = product % 10;
                }
            }

            return RemoveLeadingZeroes(result);
        }

        static int[] RemoveLeadingZeroes(int[] abc)
        {

            int c = 0;
            for (int i = 0; i < abc.Length - 1; i++)
                if (abc[i] == 0)
                    c++;
                else break;

            return abc[c..];
        }

        Console.WriteLine($"num1 + num 2 = {String.Join("", Add(v1, v2, maxlen))}");
        Console.WriteLine($"num1 - num 2 = {String.Join("", Subtract(v1, v2, maxlen))}");
        Console.WriteLine($"num1 * num 2 = {String.Join("", Multiply(v1, v2))}");

    }

    /// <summary>
    /// Se da un vector si un index in vectorul respectiv.
    /// Se cere sa se determine valoarea din vector care va fi pe
    /// pozitia index dupa ce vectorul este sortat. 
    /// </summary>
    static void P27()
    {
        Console.Write("vector: ");
        char[] sep = { ' ', ',' };
        string[] v = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("index: ");
        int index = int.Parse(Console.ReadLine());

        int[] v2 = new int[v.Length];
        for (int i = 0; i < v.Length; i++)
            v2[i] = int.Parse(v[i]);

        Array.Sort(v2);
        int value;
        if (0 <= index && index < v.Length)
        {
            value = v2[index];
            Console.WriteLine($"Valoarea in vectorul sortat de pe pozitia {index} este {value}");
        }
        else
            Console.WriteLine("indexul nu e valid");
    }


    /// <summary>
    /// Quicksort. Sortati un vector folosind metoda QuickSort. 
    /// </summary>
    static void P28()
    {
        Console.Write("vector : ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int[] ints = new int[ab.Length];

        for (int i = 0; i < ab.Length; i++)
            ints[i] = int.Parse(ab[i]);

        QuickSort(ints);

        foreach (int i in ints)
            Console.Write($"{i} ");

        static int Partition(int[] ints, int st, int dr)
        {
            int k = st;
            for (int i = st + 1; i <= dr; i++)
                if (ints[i] < ints[st])
                {
                    k++;
                    (ints[i], ints[k]) = (ints[k], ints[i]);
                }
            (ints[st], ints[k]) = (ints[k], ints[st]);
            return k;
        }
        static void QuickSort(int[] ints)
        {
            QuickSortHelper(ints, 0, ints.Length - 1);
        }

        static void QuickSortHelper(int[] ints, int st, int dr)
        {
            Random r = new();
            if (st < dr)
            {
                int idx = r.Next(st, dr + 1);
                (ints[st], ints[idx]) = (ints[idx], ints[st]);
                int k = Partition(ints, st, dr);

                QuickSortHelper(ints, st, k - 1);
                QuickSortHelper(ints, k + 1, dr);
            }
        }
    }

    /// <summary>
    /// MergeSort. Sortati un vector folosind metoda MergeSort.
    /// </summary>
    static void P29()
    {
        Console.Write("vector : ");
        string line = Console.ReadLine();
        char[] sep = { ' ', ',' };
        string[] ab = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int[] ints = new int[ab.Length];

        for (int i = 0; i < ab.Length; i++)
            ints[i] = int.Parse(ab[i]);

        MergeSort(ints);

        foreach (int i in ints)
            Console.Write($"{i} ");

        static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];

            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);
        }

        static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }
    }

    /// <summary>
    /// Sortare bicriteriala. Se dau doi vectori de numere intregi
    /// E si W, unde E[i] este un numar iar W[i] este un numar care
    /// reprezinta ponderea lui E[i]. Sortati vectorii astfel incat
    /// elementele lui E sa fie in in ordine crescatoare iar pentru
    /// doua valori egale din E, cea cu pondere mai mare va fi prima. 
    /// </summary>
    static void P30()
    {
        Console.Write("E: ");
        char[] sep = { ' ', ',' };
        string[] es = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("W: ");
        string[] ws = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        int[] e = new int[es.Length];
        int[] w = new int[ws.Length];

        for (int l = 0; l < e.Length; l++)
        {
            e[l] = int.Parse(es[l]);
            w[l] = int.Parse(ws[l]);
        }

        for (int i = 0; i < e.Length; i++)

            for (int j = i + 1; j < e.Length; j++)
                if (e[j] < e[i] || (e[j] == e[i] && w[j] > w[i]))

                    (e[i], e[j]) = (e[j], e[i]);

        Console.WriteLine(String.Join(" ", e));
    }


    /// <summary>
    /// (Element majoritate). Intr-un vector cu n elemente, un element
    /// m este element majoritate daca mai mult de n/2 din valorile
    /// vectorului sunt egale cu m (prin urmare, daca un vector are
    /// element majoritate acesta este unui singur).
    /// Sa se determine elementul majoritate al unui vector
    /// (daca nu exista atunci se va afisa <nu exista>).
    /// incercati sa gasiti o solutie liniara. 
    /// </summary>
    static void P31()
    {
        Console.Write("v: ");
        char[] sep = { ' ', ',' };
        string[] v = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> seen = new();

        string majorityElement = "";

        foreach (string a in v)
        {
            if (seen.ContainsKey(a))
                seen[a]++;
            else
                seen[a] = 1;

            if (seen[a] > v.Length / 2)
            {
                majorityElement = a;
                break;
            }
        }

        if (majorityElement.Length > 0)
            Console.WriteLine($"Elementul majoritate: {majorityElement}");
        else
            Console.WriteLine("nu exista");

    }
}