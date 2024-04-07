using System.Collections.Generic;
using UnityEngine;

public class menuController : MonoBehaviour
{

    [SerializeField] private GameObject MenuEscolha;
    [SerializeField] private GameObject Pontos;
    [SerializeField] private GameObject[] targetListaAviao;
    private MetralhadoraTorre metralha;
    public static int posicao;

    void Start()
    {
        metralha = FindObjectOfType<MetralhadoraTorre>();
    }

    void Update()
    {
        
    }

   
    public void BtnInstantiate(int x)
    {
        Debug.Log("deu");
        MenuEscolha.SetActive(false);
        Pontos.SetActive(true);
        Instantiate(targetListaAviao[x]);
        targetListaAviao[x].SetActive(true);
        posicao = x;
        // metralha.posicao(x);

    }
}
