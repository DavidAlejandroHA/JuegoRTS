using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BorrarObjetoLista : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public GameObject objetoABorrar;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject[] listaObjetosTag = GameObject.FindGameObjectsWithTag(objetoABorrar.tag);
        foreach (GameObject gObj in listaObjetosTag)
        {
            if (!gObj.GetComponent<ObjetoOriginal>().original)
            {
                NumObjetos.numObjetos--;
                NumObjetos.actualizarNumObjetos();
                Destroy(gObj);
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
