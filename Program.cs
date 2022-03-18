using System;

namespace zadanieBrs2
{
    class Program
    {
        static void Main(string[] args)
        {
            Runn Maria = new Runn();
            katrina Daria = new katrina();
            char anastasia = new char();
            Maria.tdtyn += new Run(Daria.zhmurik);

            while( anastasia != 'c')
                {

                anastasia = Convert.ToChar(Console.ReadLine());
                Maria.vtnjl(anastasia);


            }
            //1

        }

        class OnKeyPressedArgs : EventArgs
        {
            public char sim { get; set; }

        }

        delegate void Run(Object source, OnKeyPressedArgs args);


        class Runn
        {
            public event Run tdtyn;

            public void vtnjl(Char simb)
            {

                OnKeyPressedArgs kot = new OnKeyPressedArgs();
                kot.sim = simb;
                tdtyn(this, kot);


                


            }

        }
        class katrina
        {
            public void zhmurik(Object source, OnKeyPressedArgs args)
            {
                
                Console.WriteLine(args.sim);


            }
            


        }


    }
}
