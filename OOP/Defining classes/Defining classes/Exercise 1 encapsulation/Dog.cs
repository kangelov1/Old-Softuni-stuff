using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 public class Dog:Animal
 {
     public void digHole()
     {
         Console.WriteLine("Digging a hole");
     }
     public Dog()
     {
         setSound("Woof");
         flyingType = new CantFly();
     }
 }

