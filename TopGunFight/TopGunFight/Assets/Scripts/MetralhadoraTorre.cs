using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetralhadoraTorre : MonoBehaviour
{
    public float velocidade = 0.1f;
    public Transform cano;
    public GameObject bala;
    public float intervalo;
    public float forcaBala = 2f;
    private float tempo = 5f;
    [SerializeField] public Transform torreta;
    [SerializeField] public float velocidadeVisor;
    [SerializeField] private Transform[] targetListaAviao;
    private int posicaoAviao;
    menuController menuController = new menuController();
    public void Posicao(int posicao)
    {
        posicaoAviao = posicao;
        Debug.Log(posicao);
    }


    void Update()
    {
        VerificaAlturaAviao();
        

    }

    public void VerificaAlturaAviao()
    {
        if (targetListaAviao[menuController.aviaoEscolhido] != null)
        {
            float alturaDoTorpedo = transform.position.y;
            float alturaDoAviao = targetListaAviao[menuController.aviaoEscolhido].position.y;

            if (alturaDoAviao >= alturaDoTorpedo)
            {
                if (torreta != null)
                {
                    torreta.LookAt(targetListaAviao[menuController.aviaoEscolhido]);
                    Debug.Log("Aviao escolhido" + menuController.aviaoEscolhido);
                    Atirar();
                    // targetListaAviao[posicaoAviao] = null;
                }
                else
                {
                    Debug.LogError("Torreta is not assigned.");
                }
            }
        }
    }

    public void Atirar()
    {

        tempo += Time.deltaTime;

        if (tempo >= intervalo)
        {

            GameObject novaBala = Instantiate(bala, cano.position, cano.rotation);

            novaBala.transform.Rotate(90, 0, 0);

            Rigidbody rb = novaBala.GetComponent<Rigidbody>();

            rb.AddForce(cano.forward * velocidade * forcaBala, ForceMode.Impulse);

            Destroy(novaBala, 2);


        }
    }
}

