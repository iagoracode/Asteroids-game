using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideWave : MonoBehaviour
{

    public ComportamentoAsteroide prefabAsteroide;
    public int quantosAsteroides = 3;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < quantosAsteroides; i++)
        {
            float x = Random.Range(-16.0f, 16.0f);
            float y = Random.Range(-8.0f, 8.0f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }

}
