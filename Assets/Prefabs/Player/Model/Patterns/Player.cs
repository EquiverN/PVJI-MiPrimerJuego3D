using UnityEngine;

public class Player
{
    private float velocidad;
    private float aceleracion;

    public Player(float velocidad, float aceleracion)
    {
        this.velocidad = velocidad;
        this.aceleracion = aceleracion;
    }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    public float Aceleracion { get => aceleracion; set => aceleracion = value; }
}