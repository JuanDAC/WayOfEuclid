using Godot;
using System;

public partial class EuclidConcept : Node
{
	private string Content;
	private EuclidImageLoader ImageLoader;

	public void MostrarConcepto()
	{
		GD.Print(Content);
	}

	public void MostrarImagen(string imagen)
	{
	}
}
