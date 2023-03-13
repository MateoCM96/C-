using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    

            int [] CC = new int[12];
            string [] Nombre = new string[12];
            
            for(int i=0; i<12; i++ ){
                Console.WriteLine("Ingrese su Cedula: ");
                CC[i]= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su Nombre: ");
                Nombre[i]=Console.ReadLine();
                
            }
            for(int j=0;j<12;j++){
                 Console.WriteLine(" su Cedula: " + CC[j]);
                 Console.WriteLine(" su Nombre es " + Nombre[j]);
                
            } 
            
        
    }
}