using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class telaController : MonoBehaviour
{
    [SerializeField] private GameObject MenuStart;
    [SerializeField] private GameObject MenuCredito;
    [SerializeField] private GameObject MenuEscolha;
    [SerializeField] private GameObject Pontos;
    [SerializeField] private GameObject JogoTerminou;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnIniciar()
    {
        MenuEscolha.SetActive(true);
        MenuStart.SetActive(false);
        MenuCredito.SetActive(false);
        Pontos.SetActive(false);
        JogoTerminou.SetActive(false);
        

    }

    public void BtnCredito()
    {
        MenuCredito.SetActive(true);
        MenuStart.SetActive(false);
        MenuEscolha.SetActive(false);
        Pontos.SetActive(false);
        JogoTerminou.SetActive(false);


    }

    public void BtnVoltar()
    {
        MenuCredito.SetActive(false);
        MenuStart.SetActive(true);
        MenuEscolha.SetActive(false);
        Pontos.SetActive(false);
        JogoTerminou.SetActive(false);

    }

    public void BtnReiniciar()
    {
        MenuCredito.SetActive(false);
        MenuStart.SetActive(false);
        MenuEscolha.SetActive(false);
        Pontos.SetActive(false);
        JogoTerminou.SetActive(false);
            Time.timeScale = 1f;
        ContarPontos.coin = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
