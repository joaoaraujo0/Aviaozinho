using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metralhadora : MonoBehaviour
{
    public float velocidade = 100f;
    public Transform cano;
    public GameObject bala;
    public float intervalo;
    public float forcaBala = 2f;
    private float tempo = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            //incrmente o tempo do tiro
            tempo += Time.deltaTime;

            //verifica se o tempo decorrido é maior ou menor que o intervalo do termpo do tiro
            if(tempo >= intervalo)
            {
                //instancia a bala pelo cano da metralhadora
                GameObject novaBala = Instantiate(bala, cano.position, cano.rotation);

                //ajusta a rotaçã da bala, nem sempre é nescessario usar
                novaBala.transform.Rotate(90,0,0);

                //destroy a balapara ajuste da ememoria
                Destroy(novaBala, 5);

                //é uma boa pratica dar um get, pegar o componente de fisica da bala antes de usar
                Rigidbody rb = novaBala.GetComponent<Rigidbody>();

                //aplica uma força de impulso na bala
                rb.AddForce(cano.forward * velocidade * forcaBala, ForceMode.Impulse);

                //zera o intervalo de termpo 
                tempo = 0f;
            }
        }
        
        
    }
}

