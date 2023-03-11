using System;
//palindromo 
static bool palindromo(String palabra)
{
    int longitud = palabra.Length;

    string pal = "";
    for (int c = longitud - 1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpper();
    }

    if (palabra.ToUpper().Equals(pal))
    {
        return true;    
    }
    return false;
}

string palabra;
palabra = "Ana";
bool esPalindromo = palindromo("anA");

if (esPalindromo)
{
    Console.WriteLine("Es palindromo");
}
else
{
    Console.WriteLine("nel");
}
  
/*static void marque(string palabra)
{
  int longitud=palabra.Length;
for (int c=4; c>longitud;c--)
{
  Console.SetCursorPosition(5,10+c);//iteracion
  Console.WriteLine(palabra[c]);
  

}
  Console.WriteLine(palabra[2]);
}
  string palabra;
  palabra="maria";
  marque(palabra);
  */

//no debuelve valor es un metodo 
/*static void saludar(string nomsal)
{
  Console.WriteLine($"un gran saludo a  {nomsal}");
}
//debuelve valor es una funcion 
static int calculo_año_nacimiento(int edad)
{
  int anio=2023-edad;
  return anio;
}*/

/*string nombre;
int edad;
Console.Write("como estas");
nombre=Console.ReadLine();
saludar(nombre);
  
Console.WriteLine($"hola mucho gusto saludarte {nombre}");
Console.WriteLine($"cuantos años tienes {nombre}");
edad=Convert.ToInt32(Console.ReadLine());
  
Console.WriteLine($"bonita edad{edad} naciste en {calculo_año_nacimiento(edad)}");*/

