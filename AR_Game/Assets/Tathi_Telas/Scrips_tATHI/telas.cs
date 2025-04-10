using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class telas : MonoBehaviour
{
    public string Cena;

    public string[] Cenas;
    public string[] Fases;
    public void MudarCena ()
    {
        SceneManager.LoadScene(Cena);
    }

    public void MudaInicio()
    {
        SceneManager.LoadScene(Cenas[0]);
    }
    public void MudarPontuacao()
    {
        SceneManager.LoadScene(Cenas[1]);
    }
    public void MudarIntrucao()
    {
        SceneManager.LoadScene(Cenas[2]);
    }
    public void MudarRegistro()
    {
        SceneManager.LoadScene(Cenas[3]);
    }
    public void Fase2()
    {
        SceneManager.LoadScene(Fases[0]);
    }
    public void Fase3()
    {
        SceneManager.LoadScene(Fases[1]);
    }
    public void Fase4()
    {
        SceneManager.LoadScene(Fases[2]);
    }
    public void Fase5()
    {
        SceneManager.LoadScene(Fases[3]);
    }
}
