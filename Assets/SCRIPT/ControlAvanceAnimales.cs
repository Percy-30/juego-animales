using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlAvanceAnimales : MonoBehaviour
{
    public float speed = 3f;
    //public float ejeZMax = 32f;
    public float ejeZMin= -15f;

    public GameObject Object;

    public int nDisparos = 3;
    int disparos = 0;

    // canvas
    Text canva_puntos;

    //bool isBack = false;

    void Start()
    {
        canva_puntos = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }

    void OnTriggerEnter(Collider col)
    {
        disparos++;
        if (disparos >= nDisparos)
        {
            Destroy(Object);
            GlobalVariables.score++;
            canva_puntos.text = "Puntos: " + GlobalVariables.score;
        }
    }

    void Update()
    {
        /*if (transform.position.z > ejeZMax)
        {
            isBack = false;
        }
        if (transform.position.z < ejeZMin)
        {
            ///transform.Rotate(new Vector3(0f, 0f, 0f));
            isBack = true;
        }

        if (isBack)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }*/

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z < ejeZMin)
        {
            Destroy(Object);
        }
    }
}
