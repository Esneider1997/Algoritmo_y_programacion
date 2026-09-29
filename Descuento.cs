using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double montoFinal = 0;
        double descuento=0;
        
        Console.WriteLine ("ingrese el valor tota de su compra");

        double mCompra= Convert.ToInt32(Console.ReadLine());

        if (mCompra>150){

            descuento = mCompra*0.10;
            montoFinal= mCompra-descuento;

            Console.WriteLine("¡Felicidades! ha recibido un descuento de: $", descuento);
            Console.WriteLine("El total a pagar es:" + montoFinal);
        }else {
            Console.WriteLine("No ganaste ningun descuento");
            Console.WriteLine("El total a pagar es:" + mCompra);
        }

        
        
       

    }
}
