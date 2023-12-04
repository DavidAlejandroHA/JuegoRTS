using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class CreacionBotonesMenu : MonoBehaviour, IPointerClickHandler {
    public GameObject panelOpciones;
    public GameObject panelCrearObjetos;
    //Vector3 panelOpcionesPos;
    //Vector3 panelCrearObjetosPos;
    //Vector3 vectorMovOpciones;
    //Vector3 vectorMovMenuObjetos;
    //float tiempoAnimacion = 0.5f;
    //float ocultarPosHaciaAbajo = 20f;
    //float movimientoMenuObjetos = 240f;
    // Start is called before the first frame update
    void Start()
    {
        ValoresAnimaciones.vectorMovOpciones = new Vector3(0f, -ValoresAnimaciones.ocultarPosHaciaAbajo, 0f);
        ValoresAnimaciones.vectorMovMenuObjetos = new Vector3(0f, -ValoresAnimaciones.movimientoMenuObjetos, 0f);
        ValoresAnimaciones.panelOpcionesPos = panelOpciones.transform.position;
        ValoresAnimaciones.panelCrearObjetosPos = panelCrearObjetos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ocultarMenuPrincipal()
    {
        panelOpciones.transform.position = ValoresAnimaciones.panelOpcionesPos;
        panelCrearObjetos.transform.position = ValoresAnimaciones.panelCrearObjetosPos;
        LeanTween.moveY(panelOpciones, -ValoresAnimaciones.ocultarPosHaciaAbajo, ValoresAnimaciones.tiempoAnimacion)
            .setEaseInCubic();

        LeanTween.moveX(panelCrearObjetos, ValoresAnimaciones.panelCrearObjetosPos.x - 
            ValoresAnimaciones.movimientoMenuObjetos, ValoresAnimaciones.tiempoAnimacion)
            .setEaseOutCubic();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ocultarMenuPrincipal();
    }
}
