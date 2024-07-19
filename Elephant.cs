using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignments
{
    interface ISpecies
    {
        void african();
         void aslan();
    }
    interface IBodyCharacteristics
    {
        void Trunk();
        void Tosktusk();
        void teeth();
        void skin();
        void legs();
        void ears();
    }
    interface IDiet 
    {
        void herbivores();
    }
    interface IReproduction
    {
        void Interval();
        void weight();
    }
    interface IDomestication
    {
        void use();
    }
    public class Elephant : ISpecies, IBodyCharacteristics, IDiet, IReproduction, IDomestication
    {
       public  void african()
        {
            Console.WriteLine("Elephant is African!");
        }
        public void aslan()
        {
            Console.WriteLine("Elephant is aslan !");
        }

        public void Trunk()
        {
            Console.WriteLine("Elephant has trunk !");
        }
        public void Tosktusk()
        {
            Console.WriteLine("Elephant has tosk !");
        }
        public void teeth()
        {
            Console.WriteLine("Elephant has teeth !");
        }

       public  void skin()
        {
            Console.WriteLine("Elephant has skin !");
        }
        public void legs()
        {
            Console.WriteLine("Elephant has legs !");
        }
        public void ears()
        {
            Console.WriteLine("Elephant has ears !");
        }

        public void herbivores()
        {
            Console.WriteLine("Elephant has herbivores !");
        }

        public void Interval()
        {
            Console.WriteLine("Elephant has Interval !");
        }
       public  void weight()
        {
            Console.WriteLine("Elephant has weight !");
        }

       public  void use()
        {
            Console.WriteLine("Elephant is cute !");
        }
    }
}
