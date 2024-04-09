using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AviaoGravidade : MonoBehaviour
{
    [SerializeField] private GameObject TelaFinal;
    [SerializeField] private TMP_Text pontosFinal;

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
            Time.timeScale = 0f;
            TelaFinal.SetActive(true);
            pontosFinal.text = "Pontos: " + ContarPontos.coin.ToString(); // Acessando diretamente a variável coin de ContarPontos
        }

        if (collision.gameObject.CompareTag("obstaculo"))
        {
            aviaoRigid.useGravity = true;
            Time.timeScale = 0f;
            TelaFinal.SetActive(true);
            pontosFinal.text = "Pontos: " + ContarPontos.coin.ToString(); // Acessando diretamente a variável coin de ContarPontos
        }
    }
}
