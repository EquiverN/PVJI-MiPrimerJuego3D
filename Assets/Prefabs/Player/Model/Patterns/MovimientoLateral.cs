using UnityEngine;

public class MovimientoLateral : IMovementStrategy
{
    public void Move(Transform transform, Player player)
    {
        float direccion = Input.GetAxis("Horizontal");
        transform.Translate(direccion * player.Velocidad * Time.deltaTime, 0, 0);
    }
}
