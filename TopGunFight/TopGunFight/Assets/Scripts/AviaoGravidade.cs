using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviaoGravidade : MonoBehaviour
{
    private Rigidbody aviaoRigid;

    private bool colisao = false;
    void Start()
    {
        aviaoRigid = GetComponent<Rigidbody>();

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("bala"))
        {
            aviaoRigid.useGravity = true;
        }


    }
}
