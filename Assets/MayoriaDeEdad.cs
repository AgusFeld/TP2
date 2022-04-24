using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int EdadUsuario;
    public Text MiTexto;
    
    void Start()
    {
        if (EdadUsuario >= 18)
        {
            MiTexto.text = "Es mayor de edad.";
            Debug.Log("Es mayor de edad.");
        }
        else
        {
            MiTexto.text = "No es mayor de edad.";
            Debug.Log("No es mayor de edad.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
