using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAvance : MonoBehaviour
{
    public float speed = 30f;
    public float ejeZRebote = 32f;
    public float ejeZDestroy = -15f;
    public GameObject Object;

    bool isBack = false;

    void OnTriggerEnter(Collider col)
    {
        Destroy(Object);
    }

    void Start()
    {
        
    }

    void Update()
    {

        if(transform.position.z > ejeZRebote)
        {
            isBack = true;
        }

        // Rebote
        if (isBack)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // Destruccion del objeto
        if (transform.position.z < ejeZDestroy)
        {
            Destroy(Object);
        }

    }
}
