using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class executarAcao : MonoBehaviour
{
     public GameObject obj;

    // Start is called before the first frame update
    void Start() {
      
      Desativar(false);
      Rotacionar (); 
     
    }

    // Update is called once per frame
    void Update(){
        
    }

    void Desativar(bool acao){
      //gameObject.SetActive(false);//pegar o objeto do script
      obj.SetActive(acao); //pegar o objeto publico
    }

    void Rotacionar(){
       Quaternion target = Quaternion.Euler(0, 0, 90);
       obj.transform.rotation = target;   
    }
}
