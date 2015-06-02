using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public static class AlgorithmMethods
    {
        public static void MatchlistCreat(string str1, string str2, int[][] MATCHLIST)
        {
            List<int> ListOfJ = new List<int>();//для временного содержания нужных j

            for (int i = 0; i < MATCHLIST.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)//ищем такие j, что элементы строк совпадают
                {
                    if (str1[i] == str2[j])
                        ListOfJ.Add(j + 1);
                }
                MATCHLIST[i] = new int[ListOfJ.Count];
                for (int k = 0; k < ListOfJ.Count; k++)//заполняем массив MATCHLIST[]
                {
                    MATCHLIST[i][k] = ListOfJ[k];
                }
                ListOfJ.Clear();
                Invert(MATCHLIST[i]);//теперь j монотонно убывают
            }
        }

        static void Invert(int[] arr)//инвертирует массив
        {
            int temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }

        static void ThreshAndLinkCreat(int[] THRESH, Node[] LINK, int[][] MATCHLIST, string A, string B)//главный метод в алгоритме
        {
            //начальное заполнение THRESH
            THRESH[0] = 0;
            for (int i = 1; i <= A.Length; i++)
                THRESH[i] = B.Length + 1;
            LINK[0] = null;
            //Заполнение THRESH "успешными" величинами
            int k;
            for(int i=1;i<=A.Length;i++)
                foreach(int j in MATCHLIST[i-1])
                //поиск такого k, что THRESH[k-1] < j <= THRESH[k]
                    if (A[i - 1] == B[j - 1])
                    {
                        k = BinarySearch(THRESH, j);
                        if (k > 0)
                        {
                            if ((THRESH[k - 1] < j) && (j < THRESH[k]))
                            {
                                THRESH[k] = j;
                                LINK[k] = new Node(i, j, LINK[k - 1]);
                            }
                        }
                        //конец поиска
                    }
        }

        public static int SearchMaxk(int[] THRESH, string B)//поиск максимального k, который не равен B.lenght+1
        {
            int maxk = 0;
            for (int k = 0; k < THRESH.Length; k++)
                if ((THRESH[maxk] < THRESH[k]) && (THRESH[k] != B.Length + 1))
                    maxk = k;
            return maxk;
        }

        public static string CalculateLCS(int[] THRESH, Node[] LINK, int[][] MATCHLIST, string A, string B)
        {
            MatchlistCreat(A, B, MATCHLIST);
            ThreshAndLinkCreat(THRESH, LINK, MATCHLIST, A, B);
            int maxk = SearchMaxk(THRESH, B);
            Node PTR = LINK[maxk];
            string lcs = "";
            while (maxk != 0)
            {
                lcs = A[PTR.i - 1] + lcs;
                PTR = PTR.prenode;
                maxk--;
            }
            return lcs;
        }

        public static string OnlyCalculateLCS(int[] THRESH, Node[] LINK, int[][] MATCHLIST, string A, string B)
        {
            ThreshAndLinkCreat(THRESH, LINK, MATCHLIST, A, B);
            int maxk = SearchMaxk(THRESH, B);
            Node PTR = LINK[maxk];
            string lcs = "";
            while (maxk != 0)
            {
                lcs = A[PTR.i - 1] + lcs;
                PTR = PTR.prenode;
                maxk--;
            }
            return lcs;
        }

        static int BinarySearch(int[] array, int key)//поиск такого к, что array[k-1] < key <= array[k]
        {
            int left = 0;
            int right = array.Length;
            int mid = 0;

            while (!(left >= right))
            {
                mid = left + (right - left) / 2;

                if ((key <= array[mid]) && (array[mid - 1] < key))
                    return mid;

                if (key < array[mid])
                    right = mid;
                else
                    left = mid + 1;
            }

            return -(1 + left);
        }
    }

    public class Node//совпадающие символы строк будут узлами
    {
        public int i//координата символа первой строки
        { get; set; }

        public int j//координата символа второй строки
        { get; set; }

        public Node prenode;//ссылка на предыдущую вершину

        public Node(int i1, int j1, Node prenode1)
        {
            i = i1;
            j = j1;
            prenode = prenode1;
        }
    }
}
