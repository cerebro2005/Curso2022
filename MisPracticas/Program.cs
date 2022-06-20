/*
Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona. INGRESO DE DATOS
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!" IMPRIMIR EN PANTALLA
4) Preguntar si se quiere continuar. CONDICIONAL "IF"
5) Si la respuesta es "S" repetir desde el punto 1. BUCLE
6) Si la respuesta es "N" finalizar el programa mostrando 
   un mensaje que diga "Programa finalizado correctamente". IMP. PANTALLA
7) Si la respuesta no es ni "S" ni "N" que tambien 
   finalice el programa, pero mostrando un mensaje 
   que diga "Opcion no valida". IMP. PANTALLA

*/
//Ejercicio Nº 1
/* Inicio: // nombre de punto de inicio (goto)
//Limpio la pantalla
Console.Clear();
Console.WriteLine("Ingrese su nombre: "); // Mensaje para ingreso de datos
string nombre = Console.ReadLine(); // se asigna el valor ingresado a la variable nombre
Console.WriteLine($"¡Hola {nombre}!"); // impresion de mensaje con el nombre ingresado
Console.WriteLine("Desea Continua...? (S/N)");// Mensaje para preguntas si desea continuar
string continua = Console.ReadLine();// se asigna el valor ingresado a la variable continua


if (continua.ToLower() == "s") // si la respuesta es "s"
{
    goto Inicio; // se salta al punto de inicio
}
else if(continua.ToLower() == "n") // si la respuesta es "n"
{
    Console.WriteLine("Programa finalizado correctamente"); // Mensaje
    Console.ReadKey();// se espera una tecla para finalizar
}
else
{
    Console.WriteLine("Opcion no valida"); // Mensaje
    Console.ReadKey(); // se espera una tecla para finalizar
} */

//Ejercicio Nº 2
/* ********************************************************************************** */
//Se dispone de un array de n números aleatorios (Usar la clase Random). 
//Diseñar un programa que permita insertar un valor x en el lugar k-ésimo del array

Console.Clear();
Console.WriteLine("Ingrese el numero de elementos del array: "); // Mensaje para ingreso de datos
int n = int.Parse(Console.ReadLine()); // se asigna el valor ingresado a la variable n

int[] miVector = new int[n]; // se crea un array de n elementos
Random aleatorio = new Random(); // se crea un objeto de la clase Random

for (var i = 0; i < miVector.Length; i++)
{
    miVector[i] = new Random().Next(0, 100); // se asigna un valor aleatorio a cada elemento del array
}
Console.Clear();
Console.WriteLine("Lista de Numeros Aleatorios:"); // Mensaje para impresion de datos
Console.WriteLine("");
var contador = 0; // se crea una variable contador
foreach (var item in miVector)
{
    contador++; // se incrementa el contador
    Console.WriteLine($"Posición: {contador} -> {item}"); // impresion de los elementos del array
}
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Ingrese posición a modificar: "); // Mensaje para ingreso de datos
int k = int.Parse(Console.ReadLine()); // se asigna el valor ingresado a la variable k
if (k > miVector.Length || k < 0) // si la posicion ingresada es mayor al numero de elementos del array
{
    Console.WriteLine("Posicion no valida"); // Mensaje
}
else
{
    contador = 0; // se reinicia el contador
    Console.WriteLine("Ingrese el valor Modificar: "); // Mensaje para ingreso de datos

    while (true) // mientras el valor ingresado sea mayor a 0 y menor a 100
    {
        int x = int.Parse(Console.ReadLine()); // se asigna el valor ingresado a la variable x
        if (x > 0 && x < 100)
        {
            miVector[k - 1] = x; // se asigna el valor ingresado a la posicion k del array -1 para que la posicion sea desde real
            break; // se sale del bucle while infinito
        }
        else
        {
            Console.WriteLine("Recuerde que el valor debe ser positivo menos a 100"); // Mensaje
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Lista de Numeros Aleatorios Modificada:"); // Mensaje para impresion de datos
    Console.WriteLine("");
    foreach (var item in miVector)
    {
        contador++; // se incrementa el contador
        Console.WriteLine($"Posición: {contador} -> {item}"); // impresion de los elementos del array
    }
}