using UnityEngine;
using UnityEngine.UI; //Para manipular as UIs
using System.IO; //Para manipular Entrada e saida de Dados
using System.Collections;
using UnityEngine.SceneManagement;

public class SalvarArquivosTexto : MonoBehaviour
{
	public string Cena;

	public Config _config;
	public InputField _texto;
	public InputField _nomeArquivo;
	public InputField nome;
	public InputField idade;
	public InputField sexo;
	public InputField peso;
	public InputField altura;
	public InputField Email;

	// Use this for initialization
	void Start()
	{
		_config = GameObject.Find("Canvas").GetComponent<Config>();

	}
    private void Update()
    {
		PlayerPrefs.SetString("arquivo", _nomeArquivo.text);
		PlayerPrefs.SetString("nome", nome.text);
		PlayerPrefs.SetString("idade", idade.text);
		PlayerPrefs.SetString("sexo", sexo.text);
		PlayerPrefs.SetString("peso", peso.text);
		PlayerPrefs.SetString("altura", altura.text);
		PlayerPrefs.SetString("email", Email.text);

	}

    public void NovoArquivo()
	{
		if (PlayerPrefs.GetString("arquivo") == "")
		{
			_config._msg.text = "Erro: Arquivo ja Existe ou Nome Do Arquivo Em Branco";
		}
		else
		{
			nome.ToString();
			idade.ToString();
			sexo.ToString();
			peso.ToString();
			altura.ToString();
			Email.ToString();


			var _arquivo = File.CreateText(_config._local + "/" + PlayerPrefs.GetString("arquivo") + ".txt");
			_arquivo.WriteLine(PlayerPrefs.GetString("nome") + "\n "+ PlayerPrefs.GetString("idade") + "\n " + PlayerPrefs.GetString("sexo") + "\n " + PlayerPrefs.GetString("peso") + "\n " + PlayerPrefs.GetString("altura") + "\n " + PlayerPrefs.GetString("email") + "\n " + PlayerPrefs.GetInt("Pontuacao") + "\n" + PlayerPrefs.GetInt("TotalCard"));
			_arquivo.Close();
		/*/	nome.text = "";
			idade.text = "";
			sexo.text = "";
			peso.text = "";
			altura.text = "";
		 Email.text = ""; */
			_config._msg.text = "Arquivo Criado Com Sucesso.";
			MudarCena();
		}
	}
	public void AbrirArquivo()
	{
		if (PlayerPrefs.GetString("arquivo") != "")
		{
			if (File.Exists(_config._local + "/" + PlayerPrefs.GetString("arquivo") + ".txt"))
			{
				var _arquivo = File.OpenText(_config._local + "/" + PlayerPrefs.GetString("arquivo") + ".txt");
				_texto.text = _arquivo.ReadLine();
				_arquivo.Close();
				_config._msg.text = "Arquivo Carregado Com Sucesso.";
			}
			else
			{
				_config._msg.text = "Erro: Arquivo Nao Existe.";
			}
		}
		else
		{
			_config._msg.text = "Erro: Nome Do Arquivo Em Branco.";
		}
	}
	public void MudarCena()
	{
		SceneManager.LoadScene(Cena);
	}
}
	/*public void DeletarArquivo()
	{
		if (_nomeArquivo.text != "")
		{
			if (File.Exists(_config._local + "/" + _nomeArquivo.text + ".txt"))
			{
				File.Delete(_config._local + "/" + _nomeArquivo.text + ".txt");
				_config._msg.text = "Arquivo Deletado Com Sucesso.";
			}
			else
			{
				_config._msg.text = "Erro: Arquivo Nao Existe.";
			}
		}
		else
		{
			_config._msg.text = "Erro: Nome Do Arquivo Em Branco.";
		}
	}
}*/