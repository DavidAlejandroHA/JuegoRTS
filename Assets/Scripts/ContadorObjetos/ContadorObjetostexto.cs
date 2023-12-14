using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorObjetosTexto : MonoBehaviour
{
    // Start is called before the first frame update
    public static TextMeshProUGUI objetoTexto;
    void Start()
    {
        objetoTexto = GetComponent<TextMeshProUGUI>();
        //objetoTexto.text = objetoTexto.text + "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
