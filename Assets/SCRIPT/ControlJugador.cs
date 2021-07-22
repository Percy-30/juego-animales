using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    public static int score = 0;
}

public class ControlJugador : MonoBehaviour
{
    public float MovimientoHorizontal;
    public float velocidad = 10f;
    public float ejeX = 18f;
    public GameObject Projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Projectile, transform.position, Projectile.transform.rotation);
        }

        if(transform.position.x < -ejeX)
        {
            transform.position = new Vector3(-ejeX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > ejeX)
        {
            transform.position = new Vector3(ejeX, transform.position.y, transform.position.z);
        }

        MovimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * velocidad * Time.deltaTime * MovimientoHorizontal);
    }
}
