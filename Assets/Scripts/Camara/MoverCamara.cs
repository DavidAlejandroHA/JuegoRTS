using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    //public float sensitivity;
    public static bool cambiandoPosCamara = false;
    public static bool moviendoVertical = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cambiandoPosCamara)
        {
            float movX = Input.GetAxis("Mouse X");
            float movY = 0f;
            float movZ = Input.GetAxis("Mouse Y");
            
            if (moviendoVertical)
            {
                movY = movZ;
                movZ = 0f;
            }
            
            transform.position = transform.position + new Vector3(movX, movY, movZ);
        }
    }
}
