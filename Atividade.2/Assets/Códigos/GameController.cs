using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int pontuacaoTotal;

    public static GameController instancia;
    // Start is called before the first frame update
    void Start()
    {
        instancia = this;
    }
}
