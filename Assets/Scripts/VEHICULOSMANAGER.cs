using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEHICULOSMANAGER : MonoBehaviour
{

    public Vehiculo vehiculoScript;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Cant ruedas: " + vehiculoScript.cantRuedas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
