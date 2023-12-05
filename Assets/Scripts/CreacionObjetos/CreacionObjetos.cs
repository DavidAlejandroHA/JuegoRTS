using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CreacionObjetos : MonoBehaviour, IPointerClickHandler
{
    public GameObject objeto;
    GameObject objetoCopiado;
    Material[] materialesObjeto;
    Material[] materialesOriginalesObjeto;
    //Color32 colorOriginalObjeto;
    bool objetoSiendoArrastrado = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        generarObjeto(objeto);
    }

    void generarObjeto(GameObject objeto)
    {
        if (!objetoSiendoArrastrado) // Para que solo se pueda generar un objeto al mismo tiempo
                                     // hasta que no se coloque
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit golpeRayo;
            if (Physics.Raycast(rayo, out golpeRayo, 100000f))
            {
                objetoCopiado = Object.Instantiate(objeto, golpeRayo.point, objeto.transform.rotation);
                //objetoCopiado.GetComponent<MeshRenderer>().material.SetColor("_Color", new Color(49f, 255f, 255f)); // x

                materialesObjeto = objetoCopiado.GetComponent<Renderer>().materials;
                //Debug.Log(materialesOriginalesObjeto);
                materialesOriginalesObjeto = materialesObjeto;
                foreach (Material mat in materialesObjeto)
                {
                    mat.color = new Color32(49, 255, 255, 255);
                    //Debug.Log(mat.color);
                }

                /*colorOriginalObjeto = objetoCopiado.GetComponent<Renderer>().material.color;
                objetoCopiado.GetComponent<Renderer>().material.color = new Color32(49, 255, 255, 255); // v
                */
                objetoSiendoArrastrado = true;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetoSiendoArrastrado)
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit golpeRayo;
            if (Physics.Raycast(rayo, out golpeRayo, 100000f))
            {
                objetoCopiado.gameObject.transform.position = golpeRayo.point;
            }

            if (Input.GetMouseButtonDown(0))
            {
                //objetoCopiado.GetComponent<Renderer>().material.color = colorOriginalObjeto;
                //objetoCopiado.GetComponent<Renderer>().materials = materialesOriginalesObjeto; // ?
                foreach (Material mat in objetoCopiado.GetComponent<Renderer>().materials)
                {
                    mat.color = new Color32(255, 255, 255, 255);
                    //Debug.Log(mat.color);
                }
                objetoSiendoArrastrado = false;
            }
        }
    }
}
