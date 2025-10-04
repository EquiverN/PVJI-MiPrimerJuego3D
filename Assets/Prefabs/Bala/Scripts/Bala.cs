using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("shoot", 2f);
        InvokeRepeating("mmc", 4f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(5f * Time.deltaTime,0,0);
    }

    public void shoot()
    {
        Debug.Log("Una vez");
    }
    public void mmc()
    {
        Debug.Log("Repetitivo");
    }
}
