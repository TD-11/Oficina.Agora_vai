using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int pontuacaoTotal;
    public Text texto;

    public static GameController instancia;
    // Start is called before the first frame update
    void Start()
    {
        instancia = this;
    }

    public void AtualizarTexto()
    {
        texto.text = pontuacaoTotal.ToString();
    }
}
