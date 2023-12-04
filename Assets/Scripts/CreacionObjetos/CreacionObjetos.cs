using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionObjetos : MonoBehaviour
{
    public GameObject arbol1Original;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit golpeRayo;

            if (Physics.Raycast(rayo, out golpeRayo, 100000f))
            {
                //Debug.Log(golpeRayo.point);
                Object.Instantiate(arbol1Original, golpeRayo.point, arbol1Original.transform.rotation);
            }
        }
    }
}
