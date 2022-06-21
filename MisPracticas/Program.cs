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

/* Console.Clear();
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
} */

//Ejercicio Nº 3 - Arrays
// Arrays de Numeros Primos
/* Console.Clear();
Console.WriteLine("Ingrese la cantidad de numeros primos deseados: "); // Mensaje para ingreso de datos
int n = int.Parse(Console.ReadLine()); // se asigna el valor ingresado a la variable n
int[] primos = new int[n]; // se crea un array de 100 elementos
int posicion = 0; // se crea una variable posicion
int auxiliar = 0; // se crea una variable auxiliar
int numero = 1; // se crea una variable numero

while (posicion < primos.Length) // mientras el contador sea menor al numero de elementos del array
{
    auxiliar = 0; // se reinicia la variable auxiliar
    for (int i = 1; i <= numero; i++) // se recorre el numero ingresado
    {
        if (numero % i == 0) // si el numero ingresado es divisible entre i
        {
            auxiliar++; // se incrementa la variable auxiliar
        }
    }
    if (auxiliar == 2) // si el auxiliar es = 2 quiere decir que el numero tiene sus 2 divisores (por uno y por el mismo numero)
    {
        primos[posicion] = numero; // se asigna el numero al array
        posicion++; // se incrementa el contador
    }
    numero++;
}
Console.Clear();
Console.WriteLine($"Lista de {primos.Length} Numeros Primos:"); // Mensaje para impresion de datos
Console.WriteLine("");
foreach (var item in primos)
{
    Console.Write($" {item} "); // impresion de los elementos del array
}
Console.WriteLine("");
Console.WriteLine(""); */

//Ejercicio Nº 4 - Listas
/*
 * Escribir un programa que permita al usuario confeccionar 
 * una lista de nombres. Se debe ofrecer las siguientes opciones: 
 * agregar un elemento (al final o en una posición determinada), 
 * quitar un elemento, mostrar en qué posición se encuentra 
 * un determinado elemento, invertir la lista.
 */

/* Console.Clear();
Console.WriteLine("BIENVENIDO A LA LISTA DE NOMBRES"); // Mensaje para impresion de datos
var listaNombres = new List<string>(); // se crea una lista de nombres

string entradaUsuario;
do
{
    Console.WriteLine("Seleccione una de las siguientes opciones: "); // Mensaje
    Console.WriteLine("1. Agregar un elemento"); // Mensaje
    Console.WriteLine("2. Quitar un elemento"); // Mensaje
    Console.WriteLine("3. Mostrar en qué posición se encuentra un determinado elemento"); // Mensaje
    Console.WriteLine("4. Invertir la lista"); // Mensaje
    Console.WriteLine("5. Ver Lista"); // Mensaje
    Console.WriteLine("0. Salir"); // Mensaje
    Console.WriteLine("");
    Console.WriteLine("Ingrese la opcion deseada: "); // Mensaje
    entradaUsuario = Console.ReadLine(); // se asigna el valor ingresado a la variable entradaUsuario

    switch (entradaUsuario)
    {
        case "1": //Agregar un elemento
            Console.Clear();
            Console.WriteLine("Agregar Elementos "); // Mensaje
            Console.WriteLine("------------------");
            Console.WriteLine("");
            Console.WriteLine("Dónde desea agregar el elemento?"); // Mensaje
            Console.WriteLine("1. Al final");
            Console.WriteLine("2. En una posición determinada");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la opcion deseada: "); // Mensaje
            String opcion = Console.ReadLine(); // se asigna el valor ingresado a la variable opcion
            switch (opcion)
            {
                case "1": //Al final
                    Console.WriteLine("Ingrese el nombre del elemento: "); // Mensaje
                    String nombre = Console.ReadLine(); // se asigna el valor ingresado a la variable nombre
                    listaNombres.Add(nombre); // se agrega el elemento a la lista
                    Console.WriteLine("");
                    Console.WriteLine("Elemento agregado al final"); // Mensaje
                    Console.WriteLine("");
                    break;
                case "2": //En una posición determinada
                    Console.WriteLine("Ingrese el nombre que descee ubicar: "); // Mensaje
                    String nuevoElemento = Console.ReadLine(); // se asigna el valor ingresado a la variable nombre
                    Console.WriteLine("Ingrese la posición en que desea ingresar: "); // Mensaje
                    int posicion = int.Parse(Console.ReadLine()); // se asigna el valor ingresado a la variable posicion
                    listaNombres.Insert(posicion, nuevoElemento); // se agrega el elemento a la lista en la posicion ingresada
                    Console.WriteLine("");
                    Console.WriteLine($"Elemento se a agregado en la posición {posicion}"); // Mensaje
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
            }
            break;
        case "2": //Quitar un elemento
            Console.Clear();
            Console.WriteLine("Quitar Elementos "); // Mensaje
            Console.WriteLine("----------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del elemento que desea quitar: "); // Mensaje
            String elementoARemover = Console.ReadLine(); // se asigna el valor ingresado a la variable nombre
            listaNombres.Remove(elementoARemover); // se remueve el elemento de la lista
            Console.WriteLine("");
            Console.WriteLine("Elemento removido"); // Mensaje
            Console.WriteLine("");
            Console.ReadKey();
            break;
        case "3": //Mostrar en qué posición se encuentra un determinado elemento
            Console.Clear();
            Console.WriteLine("Mostrar en qué posición se encuentra un determinado elemento"); // Mensaje
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nombre del elemento que desea buscar: "); // Mensaje
            string elementoABuscar = Console.ReadLine(); // se asigna el valor ingresado a la variable nombre
            int ubicacion = listaNombres.IndexOf(elementoABuscar); // se busca el elemento en la lista
            if (ubicacion > -1)
            {
                Console.WriteLine("");
                Console.WriteLine($"El elemento {elementoABuscar} se encuentra en el index {ubicacion}"); // Mensaje
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"El elemento {elementoABuscar} no se encuentra en la lista"); // Mensaje
            }
            Console.ReadKey();
            break;
        case "4": //Invertir la lista
            Console.Clear();
            Console.WriteLine("Invertir la lista"); // Mensaje
            Console.WriteLine("----------------");
            Console.WriteLine("");
            listaNombres.Reverse(); // se invierte la lista            
            Console.WriteLine("Lista invertida"); // Mensaje
            Console.WriteLine("");
            Console.ReadKey();
            break;
        case "5": //Ver Lista
            Console.Clear();
            Console.WriteLine("Ver Lista"); // Mensaje
            Console.WriteLine("--------");
            if (listaNombres.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("La lista esta vacia"); // Mensaje
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("La lista contiene los siguientes elementos: "); // Mensaje
                Console.WriteLine("");
                foreach (var item in listaNombres)
                {
                    Console.WriteLine($" {item} "); // se imprime el elemento de la lista
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.Clear();
            break;
        case "0": //Salir
            Console.Clear();
            Console.WriteLine("Gracias por utilizar nuestro servicio"); // Mensaje
            Console.WriteLine("");
            Console.ReadKey();
            break;

        default:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Opcion no valida"); // Mensaje
            Console.WriteLine("");
            break;
    }
} while (entradaUsuario != "0"); // se repite el ciclo mientras la opcion ingresada no sea 5
 */

//Ejercicio Nº 5
/* 
   1) Pida 10 Números al usuario
   2) Obtener la suma de todos los números ingresados
   3) Obtener cual es el mayor de todos los Números
   4) Obtener cual es el menor de todos los Números
   5) Obtener el promedio de todos los Números
   6) Mostrar todos los números ingresados por pantalla
   7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5
 */

/* Console.Clear();
int[] miArray = new int[10];
int acumulador = 0;

for (int i = 0; i < miArray.Length; i++)
{
    Console.WriteLine($"Ingrese el número {i+1}: ");
    miArray[i] = int.Parse(Console.ReadLine());

}
double promedio = miArray.Sum() / 10d; // se usa el d al final del numero para que convierta a double
Console.WriteLine("");
Console.WriteLine($"La suma de todos los números es de: {miArray.Sum()}");
Console.WriteLine($"El número mayor es: {miArray.Max()}");
Console.WriteLine($"El número menor es: {miArray.Min()}");
Console.WriteLine($"El promedio de todos los números es de: {promedio}");
Console.WriteLine("");
Console.WriteLine("");
for (int i = 0; i < miArray.Length; i++)
{
    Console.Write($" {miArray[i]}");
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
for (int i = 0; i < miArray.Length; i++)
{
    acumulador += miArray[i];
    switch (i + 1)
    {
        case 2:
            Console.WriteLine($"Valor en punto 2: {acumulador}");
            break;
        case 3:
            Console.WriteLine($"Valor en punto 3: {acumulador}");
            break;
        case 4:
            Console.WriteLine($"Valor en punto 4: {acumulador}");
            break;
        case 5:
            Console.WriteLine($"Valor en punto 5: {acumulador}");
            break;
    }
} */



