using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;


public class GameManager : MonoBehaviour
{

    [Header("Interface")]
    public GameObject[] UI_Interface;
    public GameObject UI_Collect;
    public Text ScoreText;

    public int Lenght;
    public GameObject CanvasImage;
    public Sprite[] Catch;

    [Header("Realidade Aumentada")]
    public int ID;
    public int Pontuacao = 0;

    [Header("Descanso")]
    public GameObject Fim;
    public bool ResumeTime = true;

    [Header("Coleta")]
    public float[] TimeCollect;
    // public int IDCollected; 

    [Header("Musicas")]
    public AudioSource[] audios;


    void Start()
    {
        Lenght = Catch.Length;
        PlayerPrefs.SetInt("Card", Random.Range(0, Lenght));
        ResumeTime = true;
        Fim.SetActive(false);
        Pontuacao = 0;
        PlayerPrefs.SetInt("Pontuacao", Pontuacao);
        PlayerPrefs.SetInt("TotalCard", Pontuacao);
        //  IDCollected = 0;
        audios[0].Play();

    }

    void Update()
    {
        // PlayerPrefs.SetInt("Card", Teste);
        AttObjetivo();
        Pontuacao = PlayerPrefs.GetInt("Pontuacao");
        ScoreText.text = Pontuacao.ToString();
    }

    //Pontuação
    public void CheckPoint()
    {
        if (ID == 0 && PlayerPrefs.GetInt("Card") == 1)
        {
            AddScore();
        }
        else if (ID == 1 && PlayerPrefs.GetInt("Card") == 2)
        {
            AddScore();
        }
        else if (ID == 2 && PlayerPrefs.GetInt("Card") == 3)
        {

            AddScore();
        }
        else if (ID == 3 && PlayerPrefs.GetInt("Card") == 4)
        {

            AddScore();
        }
        else if (ID == 4 && PlayerPrefs.GetInt("Card") == 5)
        {

            AddScore();
        }
        else if (ID == 5 && PlayerPrefs.GetInt("Card") == 6)
        {

            AddScore();
        }
        else if (ID == 6 && PlayerPrefs.GetInt("Card") == 7)
        {

            AddScore();
        }
        else if (ID == 7 && PlayerPrefs.GetInt("Card") == 8)
        {

            AddScore();
        }
        else if (ID == 8 && PlayerPrefs.GetInt("Card") == 9)
        {

            AddScore();
        }
        else if (ID == 9 && PlayerPrefs.GetInt("Card") == 10)
        {

            AddScore();
        }
        else
        {

            RemoveScore();
        }
    }
    public void AddScore()
    {
        audios[1].Play();
        Pontuacao++;
        PlayerPrefs.SetInt("Pontuacao", Pontuacao);
        // IDCollected++;
        UI_Collect.SetActive(false);
        PlayerPrefs.SetInt("Card", Random.Range(0, Lenght));
        PlayerPrefs.SetInt("TotalCard", PlayerPrefs.GetInt("TotalCard") + 1);
    }
    public void RemoveScore()
    {
        audios[1].Play();
        Pontuacao = Pontuacao -1;
        if (Pontuacao < 0)
        {
            Pontuacao = 0;
        }
        PlayerPrefs.SetInt("TotalCard", PlayerPrefs.GetInt("TotalCard") + 1);
        PlayerPrefs.SetInt("Pontuacao", Pontuacao);
        PlayerPrefs.SetInt("Card", Random.Range(0, Lenght));
    }

    //Interface 
    public void Show_UI()
    {
        if (ID == 1 /*&& IDCollected ==0*/)
        {
            Fig1();
        }
        else if (ID == 2 /*&& IDCollected == 1*/)
        {
            Fig2();
        }
        else if (ID == 3/* && IDCollected == 2*/)
        {
            Fig3();
        }
        else if (ID == 4 /*&& IDCollected == 3*/)
        {
            Fig4();
        }
        else if (ID == 5 /*&& IDCollected == 3*/)
        {
            Fig5();
        }
        else if (ID == 6 /*&& IDCollected == 3*/)
        {
            Fig6();
        }
        else if (ID == 7 /*&& IDCollected == 3*/)
        {
            Fig7();
        }
        else if (ID == 8 /*&& IDCollected == 3*/)
        {
            Fig8();
        }
        else if (ID == 9 /*&& IDCollected == 3*/)
        {
            Fig9();
        }
        else if (ID == 10 /*&& IDCollected == 3*/)
        {
            Fig10();
        }
        else
        {
            UI_Collect.SetActive(false);
        }
    }
    //public void Hide_UI()
    //{
    //    UI_Collect.SetActive(false);

    //}

    IEnumerator TimerCollect()
    {
        yield return new WaitForSeconds(TimeCollect[ID]);
        UI_Collect.SetActive(false);

        //Se precisar colocar condição para somente as figuras que coletar ponto
        // IDCollected++;
    }

    //Ação Figuras
    public void Fig1()
    {
        UI_Collect.SetActive(true);
        TimeCollect[0] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig2()
    {
        UI_Collect.SetActive(true);
        TimeCollect[1] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig3()
    {
        UI_Collect.SetActive(true);
        TimeCollect[2] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig4()
    {
        UI_Collect.SetActive(true);
        TimeCollect[3] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig5()
    {
        UI_Collect.SetActive(true);
        TimeCollect[4] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig6()
    {
        UI_Collect.SetActive(true);
        TimeCollect[5] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig7()
    {
        UI_Collect.SetActive(true);
        TimeCollect[6] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig8()
    {
        UI_Collect.SetActive(true);
        TimeCollect[7] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig9()
    {
        UI_Collect.SetActive(true);
        TimeCollect[8] = 1;
        StartCoroutine("TimerCollect");
    }
    public void Fig10()
    {
        UI_Collect.SetActive(true);
        TimeCollect[9] = 1;
        StartCoroutine("TimerCollect");
    }
    //Interface Desncanso
    public void Descanso()
    {
        //Hide_UI();
        Fim.SetActive(true);
        ResumeTime = false;

    }
    //public void Hide_Descanso_UI()
    //{
    //    Fim.SetActive(false);
    //    ResumeTime = true;
    //}
    public void AttObjetivo()
    {    
            CanvasImage.GetComponent<UnityEngine.UI.Image>().sprite = Catch[PlayerPrefs.GetInt("Card")];
    }
}

