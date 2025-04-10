using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetImage : MonoBehaviour
{
    private GameManager gm;
    public int ID_Image = 0;
    public GameObject UI_Interface;

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    public void Show_UI()
    {
        UI_Interface.SetActive(true); 
        gm.ID = ID_Image;
    }
    public void Hide_UI()
    {
        UI_Interface.SetActive(false);
    }
}
