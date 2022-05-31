public class Tarea
{
    public int TareaID;
    public string Descripcion;
    public int Duracion;
    public Tarea(int ID,string D,int R)
    {    TareaID=ID;
         Descripcion=D;
         Duracion=R;
    }
    public void Mostrar(){
        Console.WriteLine($"ID= {TareaID} \n Descripcion= {Descripcion} \n Duracion= {Duracion} ");
    }

}