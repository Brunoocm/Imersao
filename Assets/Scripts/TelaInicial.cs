using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnIniciarClick()
    {
        Debug.Log("carregar cena");
        SceneManager.LoadScene("HelloCardboard");
    }
    public void OnSairClick()
    {
        Debug.Log("saindo");
        Application.Quit();
    }
    public void OnFazNadaClick()
    {
        Debug.Log("Fazendo nada");
    }
}
