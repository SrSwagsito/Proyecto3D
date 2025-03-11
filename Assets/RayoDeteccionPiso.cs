using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoDeteccionPiso : MonoBehaviour
{

    [SerializeField] Transform objetivo;
    [SerializeField] LayerMask Capadeteccion;
    

    //Se valida frame a frame que esta sucediendo
    private void Update()
    {
        //Una variable que siempre crea un rayo en la posicion del mouse segun la pantalla
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Se ejecuta el codigo cuando detecte un clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            //Una variable que se encarga de guardar el valor que retorna la colision del rayo
            RaycastHit hit;
            //Si el rayo detecta una colision se ejecuta el codigo
            if (Physics.Raycast(rayo, out hit, Mathf.Infinity, Capadeteccion))
                //El rayo se genera //Se devuelven las cordenadas del impacto del rayo //Distancia del rayo //Capas con las que unicamente colisiona el rayo
            {
                objetivo.transform.position = hit.point;

            }
        }
    }
}



