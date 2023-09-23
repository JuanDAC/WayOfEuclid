using Godot;
using System;
using System.Collections.Generic;

public partial class EuclidDemonstration : Node
{
    private List<string> LogicalSteps;
    private List<string> GraphicSteps;

    public void MostrarDemostracion()
    {
        foreach (string step in LogicalSteps)
        {
            GD.Print("Paso lógico: " + step);
        }

        foreach (string step in GraphicSteps)
        {
            GD.Print("Paso gráfico: " + step);
        }
    }
}
