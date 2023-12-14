using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BorrarObjeto : MonoBehaviour, IPointerClickHandler
{

    // Start is called before the first frame update
    public GameObject panelOpciones;
    Vector3 panelOpcionesPos;
    Vector3 ocultarAbajo;
    float tiempoAnimacion = 0.5f;
    float ocultarPosHaciaAbajo = 20f;
    int mascara = 1 << 6;
    static bool borrandoObjeto = false;
    void Start()
    {
        ocultarAbajo = new Vector3(0f, -ocultarPosHaciaAbajo, 0f);
        panelOpcionesPos = panelOpciones.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (borrandoObjeto && Input.GetMouseButtonDown(0))
        {
            borrarObjeto();
            borrandoObjeto = false;
            //Debug.Log(borrandoObjeto);
            panelOpciones.transform.position = panelOpciones.transform.position + ocultarAbajo;
            LeanTween.moveY(panelOpciones, panelOpcionesPos.y, tiempoAnimacion)
                .setEaseOutCubic();
        }
    }

    void borrarObjeto()
    {
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit golpeRayo;
        if (Physics.Raycast(rayo, out golpeRayo, 100000f, mascara))
        {
            //Debug.Log("a");
            NumObjetos.numObjetos--;
            NumObjetos.actualizarNumObjetos();
            Destroy(golpeRayo.transform.gameObject);
        }

        /*Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;

        RaycastHit golpe;
        if (Physics.Raycast(origen, direccion, out golpe))
        {
            Debug.Log(golpe.collider.gameObject.name);
            Destroy(golpe.collider.gameObject);
        }*/
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        borrandoObjeto = true;
        Debug.Log(borrandoObjeto);
        panelOpciones.transform.position = panelOpcionesPos;
        LeanTween.moveY(panelOpciones, -ocultarPosHaciaAbajo, tiempoAnimacion).setEaseInCubic();
    }
}
