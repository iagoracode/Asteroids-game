using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float aceleracao;
    public float velocidadeAngular= 180.0f;
    public float velocidadeMaxima = 10.0f;

    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D Projetil = Instantiate(prefabProjetil, meuRigidbody.position, Quaternion.identity);
            Projetil.velocity = transform.up * velocidadeProjetil;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direcao = transform.up * aceleracao;
            meuRigidbody.AddForce(direcao, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            meuRigidbody.rotation += velocidadeAngular * Time.deltaTime;
        }

                if (Input.GetKey(KeyCode.RightArrow))
        {
            meuRigidbody.rotation -= velocidadeAngular * Time.deltaTime;
        }

        if (meuRigidbody.velocity.magnitude > velocidadeMaxima)
        {
            meuRigidbody.velocity = Vector2.ClampMagnitude(meuRigidbody.velocity, velocidadeMaxima);
        } 
    }
    void OnTriggerEnter2D(Collider2D outro)
    {

        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}