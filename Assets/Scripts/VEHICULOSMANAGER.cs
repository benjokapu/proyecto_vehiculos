using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VEHICULOSMANAGER : MonoBehaviour
{

    public Vehiculo vehiculoScript;

    // Start is called before the first frame update
    void Start()
    {
        int CantRuedasVehiculos = vehiculoScript.cantRuedas;
        Debug.Log("Cant ruedas: " + CantRuedasVehiculos);
        if (CantRuedasVehiculos < 6)
        {
            vehiculoScript.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
