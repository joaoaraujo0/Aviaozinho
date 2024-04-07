using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContarPontos : MonoBehaviour
{
    [SerializeField] private TMP_Text pontosLabel;
    public static int coin = 0;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("balaAviao"))
        {
            coin++;
            pontosLabel.text = coin.ToString();
            Destroy(collision.gameObject);
        }


    }
}
