using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuA : MonoBehaviour
{


    public void OnBotao1()
    {
        Debug.Log("Botão Acionado");
    }
    public void OnBotao2()
    {
      gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
