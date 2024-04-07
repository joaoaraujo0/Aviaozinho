using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltarBomba : MonoBehaviour
{
    public GameObject bombaPrefab; 
    public KeyCode teclaParaSoltar = KeyCode.M; 

    // Update is called once per frame
    void Update()
    {
        // Verifica se a tecla para soltar a bomba é pressionada
        if (Input.GetKeyDown(teclaParaSoltar))
        {
            GameObject novaBomba = Instantiate(bombaPrefab, transform.position, Quaternion.identity);
            
            // Destroi a bomba após 5 segundos
            Destroy(novaBomba, 2f);
        }
    }
}
