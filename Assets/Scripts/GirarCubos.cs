using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarCubos : MonoBehaviour {

    public float VelocidadRotacion;
    [Space]
    public Transform CuboM;
    [Space]
    public Transform CuboH1;
    public Transform CuboH2;
    public Transform CuboH3;
    public Transform CuboH4;

    private float rotacion;

    void Update ()
    {
        rotacion = Input.GetAxis("Horizontal") * VelocidadRotacion * Time.fixedDeltaTime;

        CuboM.Rotate(new Vector3(0, rotacion, 0));

        CuboH1.Rotate(new Vector3(0, rotacion, 0));
        CuboH2.Rotate(new Vector3(0, rotacion, 0));
        CuboH3.Rotate(new Vector3(0, rotacion, 0));
        CuboH4.Rotate(new Vector3(0, rotacion, 0));
    }
}
