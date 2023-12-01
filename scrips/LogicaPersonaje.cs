using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float SpeedMovimiento = 5.0f;
    public float SpeedRotacion = 200.0f;
    private Animator anim;
    public float x, y;

    public Rigidbody Rb;
    public float fuerzadesalto = 8.0f;
    public bool puedosaltar;
       

    void Start()
    {
        puedosaltar = false;
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * SpeedRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * SpeedMovimiento);
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (puedosaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salte", true);
                Rb.AddForce(new Vector3(0, fuerzadesalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);
        }
        else
        {
            estoyCayendo();
        }

    }
    public void estoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("Salte", false);
    }
}
