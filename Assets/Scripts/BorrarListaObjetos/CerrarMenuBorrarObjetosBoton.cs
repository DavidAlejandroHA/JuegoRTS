using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CerrarMenuBorrarObjetosBoton : MonoBehaviour, IPointerClickHandler
{
    public GameObject panelOpciones;
    public GameObject panelBorrarObjetos;
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
        panelOpciones.transform.position = panelOpciones.transform.position;// - ValoresAnimaciones.vectorMovOpciones;
        panelBorrarObjetos.transform.position = panelBorrarObjetos.transform.position;// - ValoresAnimaciones.vectorMovMenuObjetos;
        LeanTween.moveY(panelOpciones, ValoresAnimaciones.panelOpcionesPos.y, ValoresAnimaciones.tiempoAnimacion)
            .setEaseInCubic();

        LeanTween.moveX(panelBorrarObjetos, ValoresAnimaciones.panelCrearObjetosPos.x, ValoresAnimaciones.tiempoAnimacion)
            .setEaseOutCubic();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        mostrarMenuPrincipal();
    }
}
