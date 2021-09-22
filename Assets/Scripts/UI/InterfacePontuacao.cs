using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfacePontuacao : MonoBehaviour
{
    public TMP_Text textoPontuacao;
    public int pontuacao;

    void Awake()
    {
        textoPontuacao.text = "";

        ComportamentoAsteroide.AsteroideDestruido += AsteroideFoiDestruido;
    }

    void OnDestroy()
    {
        ComportamentoAsteroide.AsteroideDestruido -= AsteroideFoiDestruido;
    }

    void AsteroideFoiDestruido()
    {
        pontuacao += 100;
        AtualizaTextoPontuacao();
        Debug.Log("sucesso");
    }

    void AtualizaTextoPontuacao()
    {
        textoPontuacao.text = pontuacao.ToString();
    }
}
