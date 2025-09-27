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
    #endregion

    #region Ciclo de vida del Script
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
    }

    // Update is called once per frame
    void FixedUpdate()
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