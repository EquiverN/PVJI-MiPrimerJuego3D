using UnityEngine;

/// <summary>
/// Permite el compartamiendo del movimiento del jugador
/// </summary>

public class PlayerMovement : MonoBehaviour
{

    #region Atributos
    /// <summary>
    /// Fuerza utilizada para aplicar movimientos.
    /// </summary>
    private Vector3 fuerzaPorAplicar;
    /// <summary>
    /// Representa el tiempo ha transcurrido desde la última aplicacion de fuerza.
    /// </summary>
    private float tiempoDesdeUltimaFuerza;
    /// <summary>
    /// Indica cada cuanto tiempo debe aplicarse la fuerza.
    /// </summary>
    private float intervaloTiempo;
    /// <summary>
    /// Indica la velocidad aplicada en el movimiento lateral.
    /// </summary>
    private float velocidadLateral;
    #endregion

    #region Ciclo de vida del Script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 2f;
    }
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(movimientoHorizontal*velocidadLateral*Time.deltaTime,0,0);
    }
    // Logica para la aplicacion de fuerzas
    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }

    #endregion
}