    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float forcaPulo;
    // Start is called before the first frame update
    void Start()  {
       rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update() {
       Move();
       Pular();
    }
    void Move() {
        // MOVIMENTACAO
        Vector3 moviment = new Vector3 (Input .GetAxis("Horizontal"),0f,0f);
        transform.position  += moviment * Time.deltaTime * speed;     

        //MUTAR ROTACAO P/DIREITA
        if(Input.GetAxis("Horizontal") > 0f)   {
            transform.eulerAngles  = new Vector3(0f,0f,0f);
        }
          //MUTAR ROTACAO P/ESQUERDA
        if(Input.GetAxis("Horizontal") < 0f) {
            transform.eulerAngles  = new Vector3(0f,180f,0f);
        }

    }
    void Pular()  {
        if(Input.GetButtonDown("Jump")) {
            rb.AddForce(new Vector2(0f,forcaPulo),ForceMode2D.Impulse );
        }
    }
   void OnCollisionEnter2D(Collision2D collision)  {
        if (collision.gameObject.tag == "parede")  {
            Destroy(gameObject, 0f);           
        }
    }
}
