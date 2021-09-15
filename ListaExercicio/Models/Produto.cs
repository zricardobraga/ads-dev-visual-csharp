using System;

namespace ListaExercicio.Models
public class Produto
{
    private string name;
    private double price;
    private int quantity;

    public string getName() 
    {
        return this.name;
    }

    public void setName(string name) 
    {
        this.name = name;
    }
}
