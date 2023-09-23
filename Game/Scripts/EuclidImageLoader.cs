using Godot;
using System;

public partial class EuclidImageLoader : Node
{
    public void CargarImagen(string imagen)
    {
        Sprite imagenSprite = GetNode<Sprite>("ImagenSprite");

        Texture textura = (Texture)GD.Load(imagen);
        imagenSprite.Texture = textura;
    }
}
