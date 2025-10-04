using UnityEngine;

public class SpawnBalas : MonoBehaviour
{
    [SerializeField]private GameObject bala;
    void Start()
    {
        InvokeRepeating("CrearBala", 2f, 4f);
    }

    void Update()
    {
        
    }
    public void CrearBala() {
        Instantiate(bala, transform.position, transform.rotation);
    }
}
