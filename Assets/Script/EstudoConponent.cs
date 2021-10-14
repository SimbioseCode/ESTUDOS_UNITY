using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EstudoConponent : MonoBehaviour
{
    private Rigidbody2D _rig;
    private SpriteRenderer _renderer;
    public float x ;
    public float y ;
   
    public float gravityScale  = 1.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent <SpriteRenderer>();
        x = 1;
        y = 1;
         _rig = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {      
          if(Input.GetKeyDown(KeyCode.Space))
          {
              _renderer.material.color = Color.blue; 
      
            Vector3 local = transform.localScale;
            transform.localScale = new Vector3(x,y,1);
            //Vector3 world = transform.lossyScale;
          }
           if(Input.GetKeyDown(KeyCode.X))
          {
              x = x +2;              
          }

           if(Input.GetKeyDown(KeyCode.Y))
          {
              y = y +2;
          }
             if(Input.GetKeyDown(KeyCode.O))
          {
            _rig.gravityScale =  gravityScale;
          }
        
    }
}
  
