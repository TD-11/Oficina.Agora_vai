using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int pontuacaoTotal;
    public TMP_Text texto;
    public GameObject derrota;
    public GameObject msg;

    public static GameController instancia;
    // Start is called before the first frame update
    void Start()
    {
        instancia = this;
    }

    void Update()
    {
        texto.text = pontuacaoTotal.ToString();
    }

    public void MostrarDerrota()
    {
        derrota.SetActive(true);
    }
    public void Recomeçar(string lvlNome)
    {
        SceneManager.LoadScene(lvlNome);
    }
    public void MostrarMSG()
    {
        msg.SetActive(true);
    }
}
