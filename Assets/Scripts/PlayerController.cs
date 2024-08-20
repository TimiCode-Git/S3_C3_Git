using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed, Rotation;

    void Start()
    {
        Debug.Log("HOLA");
    }

    private void Update()
    {
        Movimiento();
        Debug.Log("Watafac");
    }
    //FUNCION MOVIMIENTO
    public void Movimiento()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(0, 0, h * Time.deltaTime * Speed);
        transform.Rotate(0, v * Time.deltaTime * Rotation, 0);
    }
}
