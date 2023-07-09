using IsciAdi;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
#region company
//namespace Collection
//{
//    class company
//    {
//        public static List<string> IsciAd1 { get; set; } = new List<string>();
//        public List<int> IsciMaas1 { get; set; } = new List<int>();


//        static void Main()
//        {
//            ElaveEt("Suleyman");
//            Goster();

//            List<string> IsciAd = new List<string>();
//            IsciAd.Add("Ayxan");
//            IsciAd.Add("Ruslan");
//            IsciAd.Add("Bextiyar");

//            Console.WriteLine();
//            ArrayList IsciMaas = new ArrayList();
//            IsciMaas.Add(789);
//            IsciMaas.Add(567);
//            IsciMaas.Add(1000);
//            for (int i = 0; i < IsciMaas.Count; i++)
//            {
//                Console.WriteLine(IsciAd[i] + ":" + IsciMaas[i]);
//            }
//            Console.WriteLine("Maaslari deyisdirmek ucun M duymesine basin");

//            string Change = Console.ReadLine();
//            if (Change == "Y")
//            {
//                Console.WriteLine("kimin Maasini deyisdirmek isdeyirsiniz");
//                string DeyisenAd = Console.ReadLine();
//                Console.WriteLine("yeni maasi daxil edin");
//                int YeniMaas = Convert.ToInt32(Console.ReadLine());
//                for (int i = 0; i < IsciAd.Count; i++)
//                {
//                    if (DeyisenAd == IsciAd[i])
//                    {
//                        IsciMaas[i] = YeniMaas;
//                    }
//                }
//                for (int i = 0; i < IsciMaas.Count; i++)
//                {
//                    Console.WriteLine(IsciAd[i] + ":" + IsciMaas[i]);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Maas deyisilmedi");
//            }
//            Console.WriteLine("Isci elave etmek ucun I duymesine basin");
//            string Change2 = Console.ReadLine();
//            if (Change2 == "I")
//            {
//                Console.WriteLine("yeni adi ve yeni maasi daxil edin");


//                string YeniAd = Console.ReadLine();
//                int YeniAdMaas = Convert.ToInt32(Console.ReadLine());
//                IsciAd.Add(YeniAd);
//                IsciMaas.Add(YeniAdMaas);

//                for (int i = 0; i < IsciMaas.Count; i++)
//                {
//                    Console.WriteLine(IsciAd[i] + ":" + IsciMaas[i]);
//                }
//            }
//            else
//            {
//                Console.WriteLine("isci elave olunmadi");
//            }
//            Console.WriteLine("iscini siyahidan silmek ucun S duymesine basin");
//            string Change3 = Console.ReadLine();
//            if (Change3 == "S")
//            {

//                Console.WriteLine("silmek isdediyiniz adi daxil edin");
//                string RemoveName = Console.ReadLine();
//                for (int i = 0; i < IsciAd.Count; i++)
//                {
//                    if (IsciAd[i] == RemoveName)
//                    {
//                        IsciAd.Remove(IsciAd[i]);
//                        IsciMaas.Remove(IsciMaas[i]);
//                    }
//                }
//                Console.WriteLine();
//                for (int i = 0; i < IsciMaas.Count; i++)
//                {
//                    Console.WriteLine(IsciAd[i] + ":" + IsciMaas[i]);
//                }
//            }
//            else
//            {
//                Console.WriteLine("isci silinmedi");
//            }

//        }
//        public static void ElaveEt(string ad)
//        {

//            for (int i = 0; i < IsciAd1.Count; i++)
//            {

//                if (IsciAd1[i] == null)
//                {
//                    IsciAd1[i] = ad;
//                }
//            }
//        }
//        public static void Goster()
//        {
//            for (int i = 0; i < IsciAd1.Count; i++)
//            {
//                Console.WriteLine(IsciAd1[i]);
//            }
//        }

//    }

//}
#endregion
#region KItabxana
//namespace program
//{


//    class Kitabxana : Jurnal
//    {
//        static void Main(string[] args)
//        {
//            Jurnal jurnal = new Jurnal();
//            Kitab kitab = new Kitab();
//            kitab.Ad = "Anna Karenina";
//            kitab.Yazar = "Leo Tolstoy";
//            kitab.BuraxilisIli = 1887;
//            kitab.SehveSayi = 864;
//            janr KitabinJanri = janr.dastan;


//            ArrayList KitabList = new ArrayList();
//            KitabList.Add(kitab.Ad);
//            KitabList.Add(kitab.Yazar);
//            KitabList.Add(kitab.BuraxilisIli);
//            KitabList.Add(kitab.SehveSayi);
//            KitabList.Add(KitabinJanri);
//            foreach (var item in KitabList)
//            {
//                Console.WriteLine(item);
//            }
//            ArrayList JurnalList = new ArrayList();
//        }
//    }
//    class Kitab
//    {
//        public string Ad { get; set; }
//        public string Yazar { get; set; }
//        public int BuraxilisIli { get; set; }
//        public int SehveSayi { get; set; }
//        public enum janr
//        {
//            dastan,
//            roman,
//            povest,
//            hekayə,
//            komediya
//        }


//    }

//    class Jurnal : Kitab
//    {
//        public string Ad { get; set; }
//        public string Yazar { get; set; }
//        public int BuraxilisIli { get; set; }
//        public int SehveSayi { get; set; }
//        enum janr
//        {
//            elmi,
//            populyar
//        }

//    }


//}
#endregion
namespace programmetod
{
//    public class metodlar
//    {
//        public ArrayList Adlar { get; set; }
//        static void Main()
//        {
//            ///ArrayList(add,remove)

//            Add add = new Add();

//            //Console.WriteLine(Add("sagol"));??????



//            ///List<>(add,remove)
//            ///Queue(inqueue,dequeue)
//            ///Stack(push,pull  )
//            ///HashTable(add,remove)
//            ///Dictionary<>(add,remove)
//            ///LinkedList(head,data,next,node,dull)


//        }
//        public int Add(string nov)
//        {
//            Adlar.Add(nov);
//            Console.WriteLine("sagol");
//            return 0;

//        }
//        public void show()
//        {
//            for (int i = 0; i < Adlar.Count; i++)
//            {
//                Console.WriteLine(Adlar[i]);
//            }

//        }
//    }

}
namespace QueueStack
{
    class QueueStack

    {

        #region Queue
       // public static Queue Kuyu { get; set; } = new Queue();

       // public static void Main()
       // {

       //     Queue Kuyu1 = new Queue();
       //     Elave(1);
       //     Elave(2);
       //     Elave(3);
       //     Elave(4);
       //     Elave(5);
       //     Elave(6);
       //     Show();
       //     Console.WriteLine("_____&*()&)&*(*___)++++++++++++++");
       //     Sil();
       //     Sil();
       //     Show();




       // }



       //// metodlar
       // public static void Elave(int ElaveOlunan)
       // {
       //     Kuyu.Enqueue(ElaveOlunan);

       // }
       // public static void Sil()
       // {
       //     Kuyu.Dequeue();
       // }
       // public static void Show()
       // {
       //     foreach (var item in Kuyu)
       //     {
       //         Console.WriteLine(item);
       //     }
       // }
        
        #endregion
        #region Stack
       // public static Stack Stek { get; set; } = new Stack();
       // static void Main(string[] args)
       // {
       //     Stack stack1 = new Stack();
       //     sElave(1);
       //     sElave("saam");
       //     sElave(23);
       //     sShow();
       //     sSil();
       //     Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
       //     sShow();
       // }
       //// metodlar
       // public static void sElave(object deyer)
       // {
       //     Stek.Push(deyer);
       // }
       // public static void sSil()
       // {
       //     Stek.Pop();
       // }
       // public static void sShow()
       // {
       //     foreach (var item in Stek)
       //     {
       //         Console.WriteLine(item);
       //     }
       // }

        #endregion
        #region LinkedListler(????)
        //public class Node
        //{
        //    public int head { get; set; }
        //    public string tail { get; set; }
        //    public string Value { get; set; }
        //    public Node() { }

        //}
        //public class DoubleLinkedList
        //{

        //}
        //public class CircularLinkedList
        //{
        //    public Node head;
        //    public Node tail;
        //    private int size = 0;
        //}
        //public void AddLast()
        //{
        //    Node node = new Node();

        //}
        //public void AddFirst(Node node)
        //{

        //}
        #endregion
    }

}
//stack queue with massiv
#region MassivStack
//namespace MassivStack
//{
//    class Umumi
//    {
//       public static int[] Stek { get; set; }= new int[12];
//        public static int swap=0;
//        public static int g = 0;
//        public static int USteGel  = 0;
//        static void Main()
//        {
//            ElaveEt(1);
//            ElaveEt(2);
//            ElaveEt(3);
//            ElaveEt(4);
//            ElaveEt(5);
//            ElaveEt(6);
//            ElaveEt(7);
//            ElaveEt(8);
//            YuxariCek();
//            Show();
//            Console.WriteLine("=======================================");
//            Sil();
//            Sil();
//            Show();
          
//        }

//        //Stek[Stek.Length]!=null  => lazimli

//        public static void ElaveEt(int Elave)
//        {
          
//            if (Stek[0] != null )
//            {
//                for (g = 0; g < Stek.Length; g++)
//                {

//                    if (g == 0)
//                    {
//                         swap = Stek[Stek.Length-1];
//                    Stek[Stek.Length-1] = Elave;
//                    Elave = swap;
//                    swap = 0;

//                    }
                   
                    

//                    if (g != 0 && g!=Stek.Length-1)
//                    {
//                        swap = Stek[g ];
//                        Stek[g ] = Stek[Stek.Length-1];
//                        Stek[Stek.Length-1] = swap;
//                        swap = 0;
                        

//                    }
                
//                }
//            }
//            else
//            {
//                Stek[0] = Elave;
//            }

            
            

//        }

//        public static void YuxariCek()
//        {
//            swap = 0;
//            if (Stek[0] == 0)
//            {
//                for (int i = 0; i < Stek.Length-1; i++)
//                {
//                    swap= Stek[i];
//                    Stek[i]= Stek[i+1];
//                    Stek[i+1]= swap;
//                }
//            }
//        }

//        public static void Sil()
//        {
//            Stek[0] = 0;
//            YuxariCek();
//        }

//        public static void Show()
//        {
            
//            for(int i = 0;i < Stek.Length;i++)
//            {
//                if (Stek[i]!=0)
//                {
//                    Console.WriteLine(Stek[i]);
//                }
              
//            }
//        }
//    }

//}
#endregion