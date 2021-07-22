using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject[] AnimalesPrefebs;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        /*if (Mathf.Round(time) % 2 == 0)
        {
            Debug.Log("dentro");
            // Generar animales
            int index = Random.Range(0, AnimalesPrefebs.Length);
            Instantiate(
                AnimalesPrefebs[index],
                new Vector3(Random.Range(-20f, 20f), 0f, 24f),
                AnimalesPrefebs[index].transform.rotation
                );
        }*/
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Generar animales
            int index = Random.Range(0, AnimalesPrefebs.Length);
            Instantiate(
                AnimalesPrefebs[index], 
                new Vector3(Random.Range(-20f, 20f), 0f, 24f), 
                AnimalesPrefebs[index].transform.rotation
                );
        }
    }
}
