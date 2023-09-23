using Godot;
using System;
using System.Collections.Generic;

public partial class EuclidGame : Node
{
    private List<EuclidConcept> ConceptList;
    private List<EuclidDemonstration> DemonstrationList;
    private EuclidConcept currentConcept;

    public override void _Ready()
    {
        ConceptList = new List<EuclidConcept>();
        DemonstrationList = new List<EuclidDemonstration>();

        IniciarJuego();
    }

    public void CambiarConcepto(EuclidConcept concepto)
    {
        currentConcept = concepto;
        currentConcept.MostrarConcepto();
    }

    public void MostrarDemostracion(EuclidDemonstration demostracion)
    {
        demostracion.MostrarDemostracion();
    }

    public void MostrarMenu()
    {
    }
}
