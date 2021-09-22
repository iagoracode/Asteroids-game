using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{   
    public static System.Action AsteroideDestruido = null;

    public Rigidbody2D meuRigidbody;
    public ComportamentoAsteroide prefabMiniAsteroide;
    public float velocidadeMaxima = 1.0f;
    public int quantidadeFragmentos = 3;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
        
        for (int i = 0; i < quantidadeFragmentos; i++)
        {
            Instantiate(prefabMiniAsteroide, meuRigidbody.position, Quaternion.identity);
        }


        if (AsteroideDestruido != null)
        {
            AsteroideDestruido();
        }
    }


}
