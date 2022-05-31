// See https://aka.ms/new-console-template for more information
List<Tarea> Lista1 = new List<Tarea>();
List<Tarea> Lista2 = new List<Tarea>();
Console.WriteLine("Cuantas tareas deseas crear?");
int N = int.Parse(Console.ReadLine());
string D;
int a;
Random r = new Random();
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Ingresar la desc de la tarea {i + 1}");
    D = Console.ReadLine();
    a = r.Next(10, 100);
    Lista1.Add(new Tarea(i, D, a));
}


for (int i = 0; i <Lista1.Count; i++)
{
    Lista1[i].Mostrar();
    Console.WriteLine("Esta Tarea esta realizada? S para si N para no");
    if(Console.ReadLine() == "S"){
      Lista2.Add(Lista1[i]);
      Lista1.RemoveAt(i);
      i--;
    }
}
Console.WriteLine("----Lista1---- ");
foreach (var Tarea in Lista1)
{
    Tarea.Mostrar();
}
Console.WriteLine("----Lista2---- ");
foreach (var Tarea in Lista2)
{
    Tarea.Mostrar();
}
Console.Read();