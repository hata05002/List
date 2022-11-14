using System;
using System.Collections.Generic;

class program{
    public static void Main(){
        List <double> tal= new List<double>();
        tal.Add(1.3);
        tal.Add(2.7);
        tal.Add(3.8);
        tal.Add(4.8);
        tal.Add(6.8);
        // add 5 element, remove index 3
        tal.RemoveAt(3);

        // write out each element 
        foreach( double e in tal){
            Console.WriteLine(e);
        }
        
    
        Medel(tal,(tal.Count));

    //Medel method    
    static void Medel(List<double>l, int element){

     double sum= l.Sum();
     Console.WriteLine(sum/element);

    }
      
   }
        
}
