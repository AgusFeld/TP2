using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasena : MonoBehaviour
{
    string contrasenaCorrecta;
    string contrasena;
    public Text Ingreso;
    public Text textoMsj;
    public GameObject cartelitoMsj;
    
    void Start()
    {
        contrasenaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContrasena()
    {
        contrasena = Ingreso.text;
        if(contrasenaCorrecta == contrasena)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido.";
            Debug.Log("Bienvenido.");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contrasena Incorrecta.";
            Debug.Log("Contrasena Incorrecta.");
        }
    }
}
