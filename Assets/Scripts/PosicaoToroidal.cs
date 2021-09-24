using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoToroidal : MonoBehaviour
{
    const float MARGEM = 1.0f;
    public Rigidbody2D meuRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = CameraGameplay.instancia.minhaCamera;

        var maxX = camera.orthographicSize + camera.aspect + MARGEM;
        var maxY = camera.orthographicSize + camera.aspect + MARGEM;


        float limiteEsquerda = -maxX;
        float limiteDireita = maxX;
        float limiteBaixo = -maxY;
        float limiteCima = maxY;

        Vector2 pos = meuRigidbody.position;
        if (pos.x < limiteEsquerda - MARGEM)
        {
            pos.x = limiteDireita + MARGEM;
        }
        else if (pos.x > limiteDireita + MARGEM)
        {
            pos.x = limiteEsquerda - MARGEM;
        }
        if (pos.y < limiteBaixo - MARGEM)
        {
            pos.y = limiteCima + MARGEM;
        }
        else if (pos.y > limiteCima + MARGEM)
        {
            pos.y = limiteBaixo - MARGEM;
        }

        meuRigidbody.position = pos;

    }
}
