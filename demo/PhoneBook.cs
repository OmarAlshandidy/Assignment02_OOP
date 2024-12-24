using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_2
{
    internal class PhoneBook
    {
        #region Attribute 
        string[] names;
        long[] numbers;
        int size;

        #endregion
        #region Prooerties 
        public int Size
        {
            get { return size; }
        }
        #endregion
        #region constructor 
        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new long[size];

        }
        #endregion
        #region  Methods 
        public void  AddPerson(int Position , string Name,long Number )
        {
            if(names is not  null&& numbers is not null)
            {
                if(Position >=0 && Position < size)
                {
                    names[Position] = Name;
                    numbers[Position] = Number;

                }
            }
        }
        // Numbers
        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }

            }
            return -1;
        }
        public void SetNumber(string name, long number)
        {
            if (names != null && numbers != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = number;
                    }
                }
            }
        }
        #endregion
        #region Indexer 
        // Idexer : Specail property 
        // 1- Named Alyays With KeyWord This
        // 2- Can Take Paramerters

        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }

                }
                return -1;
            }
            set {

                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                        }
                    }
                }
            }
        }
        #endregion
    }
}
