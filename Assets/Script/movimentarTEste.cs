    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentarTEste : MonoBehaviour
{
    [SerializeField]//tornar a variavel vizivel
    private float _rapidez = 10.0f;
     [SerializeField]
    private float _Rapidezforca = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
      Movimantacao(0, 0, Input.GetAxisRaw("Vertical"));
      Rotacao(0, Input.GetAxisRaw("Horizontal"), 0);
     // transform.Rotate(new Vector3 (x : 0 , y: 1, z: 0));
    }
    public void Movimantacao (float x, float y, float z)
    {
        //pegar o input do jogador
        var inputJogador = new Vector3(x,y,z);
        //regular a direcao
        var direção = inputJogador.normalized;
        //velocidade        
        var velocidade = _rapidez * direção;
        //acertar o frame 
        var qtdMov = velocidade * Time.deltaTime;
        //movimentar
        transform.Translate(qtdMov);
    }
   public void Rotacao (float x, float y, float z)
    {
        //pegar o input do jogador
        var inputRotacao = new Vector3(x,y,z);
        //regular a direcao
        var direção = inputRotacao.normalized;
        //velocidade        
        var velocidade = _Rapidezforca * direção            ;
        //acertar o frame 
        var qtdMovRotacao = velocidade * Time.deltaTime;
        //movimentar
        transform.Rotate(qtdMovRotacao);
    }



   
}
