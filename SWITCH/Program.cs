// Estaciones del año usando el SWITCH

int estacion;


Console.WriteLine("Digite un número de 1 a 4 para cada estacion: ");
estacion = Convert.ToInt32(Console.ReadLine());


switch (estacion)
{

    case 1:
       
        Console.WriteLine("Primavera");
        break;
    case 2:
        Console.WriteLine("Verano");
        break;
    case 3:
        Console.WriteLine("Otoño");
        break;
    case 4:
        Console.WriteLine("Invierno");
        break;
    default:
        Console.WriteLine("Estacion Invalida");
        break;
}
   
