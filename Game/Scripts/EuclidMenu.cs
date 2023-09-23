using Godot;
using System;
using System.Collections.Generic;

public partial class EuclidMenu : Node
{
    private List<string> Options;

    public void MostrarMenu()
    {
        Control menuControl = GetNode<Control>("MenuControl");

        foreach (string opcion in Options)
        {
            Button botonOpcion = new Button();
            botonOpcion.Text = opcion;

            botonOpcion.Connect("pressed", this, "SeleccionarOpcion", new Godot.Collections.Array { opcion });

            menuControl.AddChild(botonOpcion);
        }
    }

    public void SeleccionarOpcion(string opcion)
    {
        GD.Print("Opción seleccionada: " + opcion);
    }
}
