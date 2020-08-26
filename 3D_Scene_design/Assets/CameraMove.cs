using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Moveqe()
    {
        bool Q = Input.GetKey(KeyCode.Q);
        if(Q) transform.Translate(0, speed * -Time.deltaTime, 0);

        bool E = Input.GetKey(KeyCode.E);
        if(E) transform.Translate(0, speed * Time.deltaTime, 0);

    }

    
    private void Moves()
    {
        bool S = Input.GetKey(KeyCode.S);

        if (S)
        {
            //ani.SetBool("走路開關", true);
            transform.Translate(0, 0, speed * -Time.deltaTime);

        }
        //else ani.SetBool("走路開關", false);       

    }
    private void Movew()
    {
        bool W = Input.GetKey(KeyCode.W);
        if (W)
        {
            //ani.SetBool("走路開關", true);
            transform.Translate(0, 0, speed * Time.deltaTime);

        }
        //else ani.SetBool("走路開關", false);
        bool A = Input.GetKey(KeyCode.A);
        if (A)
        {
            transform.Rotate(0, speed * -Time.deltaTime * 22, 0);

        }
        bool D = Input.GetKey(KeyCode.D);
        if (D)
        {
            transform.Rotate(0, speed * Time.deltaTime * 22, 0);

        }




    }
    private void FixedUpdate()
    {
        Moves();
        Movew();
        Moveqe();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
