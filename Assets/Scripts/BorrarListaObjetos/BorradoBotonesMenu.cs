using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class BorradoBotonesMenu : MonoBehaviour, IPointerClickHandler
{
    public GameObject panelOpciones;
    public GameObject panelBorrarObjetos;
    // Start is called before the first frame update
    void Start()
    {
        ValoresAnimaciones.vectorMovOpciones = new Vector3(0f, -ValoresAnimaciones.ocultarPosHaciaAbajo, 0f);
        ValoresAnimaciones.vectorMovMenuObjetos = new Vector3(0f, -ValoresAnimaciones.movimientoMenuObjetos, 0f);
        ValoresAnimaciones.panelOpcionesPos = panelOpciones.transform.position;
        ValoresAnimaciones.panelCrearObjetosPos = panelBorrarObjetos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ocultarMenuPrincipal()
    {
        panelOpciones.transform.position = ValoresAnimaciones.panelOpcionesPos;
        panelBorrarObjetos.transform.position = ValoresAnimaciones.panelCrearObjetosPos;
        LeanTween.moveY(panelOpciones, -ValoresAnimaciones.ocultarPosHaciaAbajo, ValoresAnimaciones.tiempoAnimacion)
            .setEaseInCubic();

        LeanTween.moveX(panelBorrarObjetos, ValoresAnimaciones.panelCrearObjetosPos.x -
            ValoresAnimaciones.movimientoMenuObjetos, ValoresAnimaciones.tiempoAnimacion)
            .setEaseOutCubic();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ocultarMenuPrincipal();
    }
}
