using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogo : MonoBehaviour
{
    public GameObject CanvasImage;
    public Sprite[] falas;
    public int count = 0;

    public string MudarCena;
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= falas.Length)
        {
            count =0;
            SceneManager.LoadScene(MudarCena);
        }
        AttFala();
    }
    public void MudarFala()
    {
        if (count < falas.Length)
        {
            count++;
           
        }
        

    }
    public void AttFala()
    {
        CanvasImage.GetComponent<UnityEngine.UI.Image>().sprite = falas[count];
    }
}
