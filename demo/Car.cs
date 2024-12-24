using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2
{
    internal class Car
    {
        #region Attribute
        //private int id ;
        //private int speed;
        //private int model;
        public int Id { get; set; }
        public string Model { get; set; }
        public double  Speed { get; set; }
        #endregion

        #region Properties
        //      public int Id
        //{
        //	get { return id; }
        //	set { id = value; }
        //}
        //public int Model
        //{
        //	get { return model; }
        //	set { model = value; }
        //}

        //public int Speed
        //{
        //	get { return speed; }
        //	set { speed = value; }
        //}


        #endregion
        #region Methodws
        public override string ToString()
        {
            return $"Id: {Id} \n Model: {Model}\n Speed : {Speed} ";
        }
        public Car(int Id , string Model ,double Speed ) {
            Console.WriteLine("Ct01");
            this.Id = Id;
            this.Model = Model;
            this.Speed = Speed;
        }
        public Car(int Id, string Model) 
       : this(Id, Model, 190) 
        {
            Console.WriteLine("Ct02");
        }
        public  Car(int id )
            : this(id, "kai", 180) {
            Console.WriteLine("Ct03");
        }

        #endregion


    }
}
