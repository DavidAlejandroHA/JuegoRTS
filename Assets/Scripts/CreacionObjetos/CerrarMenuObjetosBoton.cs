using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CerrarMenuObjetosBoton : MonoBehaviour, IPointerClickHandler
{
    public GameObject panelOpciones;
    public GameObject panelCrearObjetos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mostrarMenuPrincipal()
    {
        panelOpciones.transform.position = panelOpciones.transform.position + ValoresAnimaciones.vectorMovOpciones;
        panelCrearObjetos.transform.position = panelCrearObjetos.transform.position +
            ValoresAnimaciones.vectorMovMenuObjetos;
        LeanTween.moveY(panelOpciones, ValoresAnimaciones.panelOpcionesPos.x, ValoresAnimaciones.tiempoAnimacion)
            .setEaseInCubic();

        LeanTween.moveX(panelCrearObjetos, ValoresAnimaciones.movimientoMenuObjetos, ValoresAnimaciones.tiempoAnimacion)
            .setEaseOutCubic();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        mostrarMenuPrincipal();
    }
}
