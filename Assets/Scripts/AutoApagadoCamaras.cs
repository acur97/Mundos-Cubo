using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoApagadoCamaras : MonoBehaviour {

    public Transform camM;
    [Space]
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    private float rotacion;

    void Update ()
    {
        rotacion = camM.rotation.eulerAngles.y;
        //Debug.Log(rotacion);

        if (rotacion < 249 && rotacion > 111)
        {
            cam1.SetActive(true);
        }
        else
        {
            cam1.SetActive(false);
        }

        if (rotacion < 339 && rotacion > 202)
        {
            cam2.SetActive(true);
        }
        else
        {
            cam2.SetActive(false);
        }

        if (rotacion > 291 && rotacion < 360)
        {
            cam3.SetActive(true);
        }
        else if (rotacion >= 0 && rotacion < 69)
        {
            cam3.SetActive(true);
        }
        else
        {
            cam3.SetActive(false);
        }

        if (rotacion < 159 && rotacion > 22)
        {
            cam4.SetActive(true);
        }
        else
        {
            cam4.SetActive(false);
        }
    }
}
