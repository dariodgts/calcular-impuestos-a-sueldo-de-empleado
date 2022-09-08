using System;

namespace geometria
{
class Program
{
    static void Main(string[] args)
    {
        imp a = new imp();
        a.MostrarDatos();
        
        Double Sueldo, ISR, AFP,ITBIS_ISR, ITBIS_AFP;
        Console.Write("SUELDO BASE:");
        Sueldo = Double.Parse(Console.ReadLine());
        ITBIS_ISR = Sueldo * 0.20;
        ITBIS_AFP = Sueldo * 0.25;
        ISR = Sueldo - ITBIS_ISR;
        AFP = Sueldo - ITBIS_AFP;

        if (Sueldo>=8900 && Sueldo<=29999 )
        {
            Console.WriteLine("\nEXENTO DE IMPUESTO\n");
            Console.WriteLine("SUELDO NETO :"+Sueldo);
        }

        if (Sueldo >= 30000 && Sueldo <= 41399)
        {
            Console.WriteLine("\nSE LE HA APLICADO UN 20% CORRESPONDIENTE A EL IMPUESTO SOBRE LA RENTA ISR \n");
            Console.WriteLine("ITBIS: "+ITBIS_ISR);
            Console.WriteLine("SUELDO NETO : " + ISR);
        }

        if (Sueldo >= 41400 )
        {
            Console.WriteLine("\nSE LE HA APLICADO UN 25% CORRESPONDIENTE A SU SEGURO AFP\n ");
            Console.WriteLine("ITBIS: "+ITBIS_AFP);
            Console.WriteLine("SUELDO NETO :" + AFP);
        }

        if (Sueldo<=8899)
        {
            Console.WriteLine("\n\nSUELDO NO DISPONIBLE PARA MOSTRAR");
        }
        Console.ReadKey();
        
    }
}
}