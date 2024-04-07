using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetralhadoraTorre : MonoBehaviour
{
    public float velocidade = 0.1f;
    public Transform cano;
    public GameObject bala;
    public float intervaloEntreTiros = 0.5f; // Intervalo mínimo entre os tiros
    public float forcaBala = 2f;
    private float tempoUltimoTiro; 
    [SerializeField] public float velocidadeVisor;
    [SerializeField] private Transform[] targetListaAviao;

    void Update()
    {
        VerificaAlturaAviao();
    }

    public void VerificaAlturaAviao()
    {
        
        if (targetListaAviao[menuController.posicao] != null)
        {
            float alturaDoTorpedo = transform.position.y;
            float alturaDoAviao = targetListaAviao[menuController.posicao].position.y;

            if (alturaDoAviao >= alturaDoTorpedo)
            {
                cano.LookAt(targetListaAviao[menuController.posicao]);
                Atirar();
            }
        }
    }

    public void Atirar()
    {
        // Verifica se o tempo entre os tiros já passou
        if (Time.time >= tempoUltimoTiro + intervaloEntreTiros)
        {
            GameObject novaBala = Instantiate(bala, cano.position, cano.rotation);
            Rigidbody rb = novaBala.GetComponent<Rigidbody>();
            rb.AddForce(cano.forward * velocidade * forcaBala, ForceMode.Impulse);
            Destroy(novaBala, 2);

            // Atualiza o tempo do último tiro
            tempoUltimoTiro = Time.time;
        }
    }
}
