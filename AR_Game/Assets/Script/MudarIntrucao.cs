using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MudarIntrucao : MonoBehaviour
{
    public GameObject CanvasImage;
    public Sprite[] Instrucao;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if (count >= Instrucao.Length)
        {
            count = 0;

        }
        AttInstrucao();
    }
    public void Mudar()
    {
        count++;
    }
    public void AttInstrucao()
    {
        CanvasImage.GetComponent<UnityEngine.UI.Image>().sprite = Instrucao[count];
    }
}
