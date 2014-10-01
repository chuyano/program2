/*
 * Created by SharpDevelop.
 * User: buba
 * Date: 01/10/2014
 * Time: 04:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace program2
{
	class Program
	{
		public static void Main(string[] args)
		{
int n1,p1,pr,n2,n3,p3,precio;
			double p2,pre,iva=.16,i,v,a,total,subtotal;
			string d1,d2,d3;
					 	
			
		Console.WriteLine("dame la cantidad del producto 1");
               n1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("dame la descripcion del producto 1");            
        d1= Console.ReadLine();
        Console.WriteLine("dame el precio unitario");
               p1 = Convert.ToInt16(Console.ReadLine());  


			
			pr=n1*p1;
		Console.WriteLine( "el precio es" + pr);
		
		Console.WriteLine("dame la cantidad del producto 2");
               n2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("dame la descripcion del producto 2");            
        d2= Console.ReadLine();
        Console.WriteLine("dame el precio unitario");
        p2 = Convert.ToDouble(Console.ReadLine());  

        
        pre=n2*p2;
		Console.WriteLine( "el precio es" + pre);
        
        Console.WriteLine("dame la cantidad del producto 3");
               n3 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("dame la descripcion del producto 3");            
        d3= Console.ReadLine();
        Console.WriteLine("dame el precio unitario");
        p3 = Convert.ToInt16(Console.ReadLine());
        
        
        precio=n3*p3;
		Console.WriteLine( "el precio es" + precio);
		
		subtotal=pr+pre+precio;
		   Console.WriteLine( "el subtotal es" + subtotal);
		   i=pr*iva;
		   v=pre*iva;
		   a=precio*iva;
		   
		   iva=i+v+a;
		   total=iva+subtotal;
		    Console.WriteLine( "el total es" + total);

			
	
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}