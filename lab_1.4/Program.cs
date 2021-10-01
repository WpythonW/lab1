using System;

namespace lab_1._4
{ 
    class A
    {
        private B b = null;
        private C c = null;
        private J j = null;

        public A(B b, C c, J j)
        {
            this.b = b;
            this.c = c;
            this.j = j;
        }

        public void mA()
        {
            Console.WriteLine("method of A");
        }

        public B bA
        {
            set { Console.WriteLine("set b"); b = value; }
            get { Console.Write("get b -> "); return b; }
        }
        public C cA //атрибут доступа к атрибутам
        {
            set { Console.WriteLine("set c"); c = value; }
            get { Console.Write("get c -> "); return c; }
        }
        public J jA
        {
            set { Console.WriteLine("set j"); j = value; }
            get { Console.Write("get j -> "); return j; }
        }


    }

    class B
    {
        private K k = null;
        private D d = null;

        public B(K k, D d)
        {
            this.k = k;
            this.d = d;
        }

        public void mB()
        {
            Console.WriteLine("method of B");
        }

        public K kA
        {
            set { Console.WriteLine("set k"); k = value; }
            get { Console.Write("get k -> "); return k; }
        }

        public D dA
        {
            set { Console.WriteLine("set d"); d = value; }
            get { Console.Write("get d -> "); return d; }
        }

    }

    class C
    {
        private E e = null;

        public C(E e)
        {
            this.e = e;
        }

        public void mC()
        {
            Console.WriteLine("method of C");
        }

        public E eA
        {
            set { Console.WriteLine("set e"); e = value; }
            get { Console.Write("get e -> "); return e; }
        }

    }

    class J
    {
        private F f = null;

        public J(F f)
        {
            this.f = f;
        }

        public void mJ()
        {
            Console.WriteLine("Method of J");
        }

        public F fA
        {
            set { Console.WriteLine("set e"); f = value; }
            get { Console.Write("get e -> "); return f; }
        }


    }

    class K
    {
        public K() { }

        public void mK()
        {
            Console.WriteLine("Method of K");
        }

    }

    class D
    {
        public D() { }

        public void mD()
        {
            Console.WriteLine("Method of D");
        }
    }

    class E
    {
        public E() { }

        public void mE()
        {
            Console.WriteLine("Method of E");
        }
    }

    class F
    {
        public F() { }

        public void mF()
        {
            Console.WriteLine("Method of F");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task: ");
            D d = new D();
            K k = new K();

            E e = new E();

            F f = new F();


            B b = new B(k, d);

            C c = new C(e);

            J j = new J(f);
            
            
            A a = new A(b, c, j);

            Console.WriteLine("Передача по ссылке: ");
            a.mA();
            a.jA.mJ();
            a.cA.mC();  //в объекте класса а обращаемся к атрибуту доступа, который возвращает значение. Это значение - ссылка на объект другого класса, в котором мы обращаемся к методу
            a.bA.mB();
            a.bA.kA.mK();
            a.bA.dA.mD();
            a.cA.eA.mE();
            a.jA.fA.mF();   //в объекте класса а обращаемся к атрибуту доступа, который возвращает значение. Это значение - ссылка на объект другого класса, в котором мы обращаемся к атрибуту доступа, который возвращает значение - ссылку на объект другого класса. И по ссылке на объект этого класса, мы получаем доступ к методу
            Console.ReadKey();

        }
    }

}
