using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    private float velocidadActual = 0f;
    //private float aceleracion = 2f;
    public void Move(Transform transform, Player player, float direccion)
    {
        //velocidadActual += Input.GetAxis("Horizontal") * player.Aceleracion * Time.deltaTime;
        velocidadActual += direccion * player.Aceleracion * Time.deltaTime;
        velocidadActual = Mathf.Clamp(velocidadActual, -player.Velocidad, player.Velocidad);
        transform.Translate(velocidadActual * Time.deltaTime, 0, 0);
    }
}
