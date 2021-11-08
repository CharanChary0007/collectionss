using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Collactins
{
    class Collecttt
    {
        public static void Main(String[] args)
        {
            // Nullable< int> i = null ;
            //  int a = 55 + (int)i;
            //  Console.WriteLine(i+""+a);
            //   Console.WriteLine(i.HasValue);

            Listtt.Me11();
            Arr1.Me12();
            Hashy.M13();
            Gens<string>.M13();
            Constra<double>.M16();

        }
    }
    public class Listtt
    {
        public static void Me11()
        {
            var lam = new List<string>();
            lam.Add("charan ");
            lam.Add("has  ");
            lam.Add("two bikes ");
            lam.Add("and five ");
            lam.Add("cars ");
            lam.Add("and a building");
            lam.Add("with");
            lam.Add("500 floors ");
            lam.Remove("500 floors ");
            lam.Add("only 50 floors");
            foreach (var i in lam)
            {
                Console.Write("{0} ", i);
            }

        }
    }
    public class Arr1//non generic arrylist
    {
        public static void Me12()
        {
            ArrayList arrr = new ArrayList();
            arrr.Add(123);
            arrr.Add("Charan");
            arrr.Add('A');
            arrr.Add(1.3);
            arrr.Add(12.332214);
            foreach (var i in arrr)
                Console.WriteLine(i);
          /*     Console.WriteLine("Sorted Array");Array cant be sortde as threr are diffrent type of data types;;;
            //    arrr.Sort();*/
            foreach (var i in arrr)
                Console.WriteLine(i);
            arrr.Reverse();
            foreach (var i in arrr)
                Console.WriteLine(i);
            arrr.Insert(3, "abc");
            foreach (var i in arrr)
                Console.WriteLine(i);
            Console.WriteLine("count ofb the list  " + arrr.Count);
            Console.WriteLine("capacity ofb the list " + arrr.Capacity);
            arrr.Add("yam");
            Console.WriteLine("count ofb the list  " + arrr.Count);
            Console.WriteLine("capacity ofb the list " + arrr.Capacity);
            arrr.Add("yauhsdum");
            Console.WriteLine("count ofb the list  " + arrr.Count);
            Console.WriteLine("capacity ofb the list " + arrr.Capacity);
            arrr.Add("yam");
            Console.WriteLine("count ofb the list  " + arrr.Count);
            Console.WriteLine("capacity ofb the list " + arrr.Capacity);//capacity increase by 4,8,16,32;
            int a = arrr.GetHashCode();
            Console.WriteLine(a);
            Console.WriteLine("method m12 exicuted");
        }
    }
    public class Hashy
    {
        public static void M13()
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "name");
            hash.Add("name", "charan");
            hash.Add('a', "age");
            hash.Add("age", 21);
            hash.Add(21, "is age");
            foreach (DictionaryEntry i in hash)
            {
                Console.WriteLine("value is {1} which is containd by {0}", i.Value, i.Key);
            }
            bool y = hash.Contains(1);
            Console.WriteLine(y);
            hash.Remove(1);
            y = hash.Contains(1);
            Console.WriteLine(y);
            y = hash.ContainsValue("name");
            Console.WriteLine(y);
            foreach (var i in hash.Values)
            {
                Console.WriteLine(i);
            }



        }
    }
    public class Gens<gen>
    {
        public gen fullname;
        public void genics(gen name, gen Fullname)
        {

            Console.WriteLine(name);
            fullname = Fullname;
            Console.WriteLine(this.fullname);

        }
        public void Genmethod<p>(p age, p date)
        {
            Console.WriteLine(age);

            Console.WriteLine(date);
        }
        public static void M13()
        {
            Gens<string> gens1 = new Gens<string>();
            gens1.genics("charan", "neernemulaa charan");
            gens1.Genmethod<int>(21, 30);
        }
    }
    public class Constra<i> : Gens<string> where i : struct
    {
        public void M15(i salery, i height)
        {
            Console.WriteLine("{0} is salery and {1} is the height of the member {2}", salery, height, base.fullname);
        }
        public static void M16()
        {
            Constra<double> a1 = new Constra<double>();
            a1.M15(55000.15, 6.67);
        }
    }

}
