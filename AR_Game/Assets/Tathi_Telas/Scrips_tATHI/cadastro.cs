using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cadastro : MonoBehaviour
{
    [SerializeField] InputField nome;
    [SerializeField] InputField idade;
    [SerializeField] InputField sexo;
    [SerializeField] InputField peso;
    [SerializeField] InputField altura;
    [SerializeField] InputField email;

    void update()
    {
        nome.text = PlayerPrefs.GetString("Nome");
        idade.text = PlayerPrefs.GetString("Idade");
        sexo.text = PlayerPrefs.GetString("sexo");
        peso.text = PlayerPrefs.GetString("peso");
        altura.text = PlayerPrefs.GetString("altura");
        email.text = PlayerPrefs.GetString("Email");
    }

    // Coloque esse m�todo em um bot�o, quando apertar salva as informa��es
    public void Salvar()
    {
        PlayerPrefs.SetString("Nome", nome.text);
        PlayerPrefs.SetString("Idade", idade.text);
        PlayerPrefs.SetString("sexo", email.text);
        PlayerPrefs.SetString("peso", nome.text);
        PlayerPrefs.SetString("altura", idade.text);
        PlayerPrefs.SetString("Email", email.text);
    }
}

// Coloque esse m�todo em um bot�o, quando apertar excluir as informa��es
/*public void Excluir()
{
    PlayerPrefs.DeleteAll();
    nome.text = PlayerPrefs.GetString("Nome");
    idade.text = PlayerPrefs.GetString("Idade");
    email.text = PlayerPrefs.GetString("Email");
}
}
*/