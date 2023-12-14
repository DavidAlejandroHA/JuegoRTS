using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumObjetos : MonoBehaviour
{
    // Start is called before the first frame update
    public static int numObjetos = 0;
    public static string objetoTextoOriginal;
    void Start()
    {
        //objetoTextoOriginal = ContadorObjetosTexto.objetoTexto.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void actualizarNumObjetos()
    {
        //Actualiza el texto que muestra el numero de objetos
        ContadorObjetosTexto.objetoTexto.text = objetoTextoOriginal + numObjetos;
    }


}
