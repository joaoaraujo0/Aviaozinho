using System.Collections.Generic;
using UnityEngine;

public class menuController : MonoBehaviour
{

    [SerializeField] private GameObject MenuEscolha;
    [SerializeField] public GameObject[] targetListaAviao;

    MetralhadoraTorre metralha = new MetralhadoraTorre();

    public int aviaoEscolhido;

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void BtnInstantiate(int x)
    {
        Debug.Log("deu");
        Debug.Log(x);
        MenuEscolha.SetActive(false);
        Instantiate(targetListaAviao[x]);
        targetListaAviao[x].SetActive(true);
        metralha.Posicao(x);
        aviaoEscolhido = x;

    }
}
