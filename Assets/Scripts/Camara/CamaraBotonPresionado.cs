using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class CamaraBotonPresionado : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //Button botonCamara;
    public GameObject panelOpciones;
    Vector3 panelOpcionesPos;
    Vector3 ocultarAbajo;
    float tiempoAnimacion = 0.5f;
    float ocultarPosHaciaAbajo = 20f;

    // Start is called before the first frame update
    void Start()
    {
        ocultarAbajo = new Vector3(0f, -ocultarPosHaciaAbajo, 0f);
        panelOpcionesPos = panelOpciones.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        MoverCamara.cambiandoPosCamara = true;
        comprobarCambioAVertical();

        panelOpciones.transform.position = panelOpcionesPos;
        LeanTween.moveY(panelOpciones, -ocultarPosHaciaAbajo, tiempoAnimacion).setEaseInCubic();
        //Debug.Log(MoverCamara.cambiandoPosCamara + " down");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        MoverCamara.cambiandoPosCamara = false;

        panelOpciones.transform.position = panelOpciones.transform.position + ocultarAbajo;
        LeanTween.moveY(panelOpciones, panelOpcionesPos.y, tiempoAnimacion)
            .setEaseOutCubic();
        //Debug.Log(MoverCamara.cambiandoPosCamara + " - up");
    }

    void comprobarCambioAVertical()
    {
        /* Ej:
         *  if(Input.GetMouseButtonDown(0)) Debug.Log("Pressed left click.");
            if(Input.GetMouseButtonDown(1)) Debug.Log("Pressed right click.");
            if(Input.GetMouseButtonDown(2)) Debug.Log("Pressed middle click.");
        */
        if (Input.GetMouseButtonDown(1))
        {
            MoverCamara.moviendoVertical = true;
            Debug.Log(MoverCamara.cambiandoPosCamara + " -");
        } else
        {
            MoverCamara.moviendoVertical = false;
        }
    }
}
