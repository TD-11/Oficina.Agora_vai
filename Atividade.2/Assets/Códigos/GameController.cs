using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int pontuacaoTotal;
    public TMP_Text texto;

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
}
