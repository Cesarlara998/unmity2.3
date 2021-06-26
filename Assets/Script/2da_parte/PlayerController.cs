using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float timegame = 5;
    private Rigidbody2D Object;
    private int Life;
    private int Dead;
    // Start is called before the first frame update
    void Start()
    {
        this.Object = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        this.Moves(H,V);
    }
    private void Moves(float h, float v){
        
        float x = h * this.timegame;
        float y = v * this.timegame;
        this.Object.velocity = new Vector2(x,y);    
    }
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag ==  "GameController") {
            GetComponent<StatusPlayer>().Dead = GetComponent<StatusPlayer>().Dead - 1;
            Debug.Log(this.Dead);
        }
        if (col.gameObject.name ==  "Vida") {
            GetComponent<StatusPlayer>().Life = GetComponent<StatusPlayer>().Life + 1;
            Debug.Log(this.Dead);
        }
    }
}
