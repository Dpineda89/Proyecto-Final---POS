public class Cliente : Persona
{
    public double saldo {get; set; }
    public Cliente(int codigo, string nombre, string telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono; 
    }
}
