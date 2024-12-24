using Session_2.Polymorphism;
namespace Session_2

{

    internal class Program
    {
        public static int sum(int x, int y) {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y;
        }
        public static double sum(double x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            #region  Indexer 
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Rana", 123);
            //Note.AddPerson(1, "Aya", 456);
            //Note.AddPerson(2, "Omar", 789);
            ////Note.SetNumber("Rana", 2222); // setter 
            //Note["Rana"] = 333; // Use Indexer for setter 
            //Console.WriteLine(Note["Rana"]); // Use Indexer for getter

            #endregion
            #region Car
            // Car C1; 
            //Declare For Redeernce From  type car , Refeing to Null 
            // Can Refer To AN Object From Type Car Or An Object  from Another CLASS Inheriting from 
            //clr will Allocate 4 Bytes For Refiernce C1 At stack 
            //C1 = new Car(10);
            // Console.WriteLine(C1);
            #endregion
            #region Inheritance
            //  Parent P1 = new Parent(1, 2);
            //Console.WriteLine(P1);
            // Child C1 = new Child(3,2,1);
            // Console.WriteLine(C1);
            #endregion
            #region Relationships Between Classes
            // 1- Inheritance : Is A[FullTime Is An Employee ]
            //2- Aggregation : Has 
            // 2.1 : Composition 
            //2.2 Association 

            #endregion
            #region polymorphism
            #region OverLoading 
            //int Result = sum(1, 2);
            //xConsole.WriteLine(Result);
            //Console.WriteLine();
            //Console.WriteLine("Rana");
            //Console.WriteLine("R");
            //Console.WriteLine(4);
            //Console.WriteLine(5.5f);
            #endregion
            #region OverRiding 
           // TypeA typeA = new TypeA(1);
           //typeA.A = 11;
           // typeA.Myfun01();
           // typeA.Myfun01();

            #endregion
            #endregion
        }
    }
}
