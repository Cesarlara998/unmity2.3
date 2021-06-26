using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D Object;
    public float timegame = 5;
    private GameObject TextObject;
    private Text text;
    private GameObject imageObject;
    void Start()
    {
        this.TextObject = GameObject.Find("Text");
        this.text = this.TextObject.GetComponent<Text>();
        this.imageObject = GameObject.Find("Image");
        this.imageObject.SetActive(false);
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
        if (col.gameObject.name ==  "Collider") {
            this.text.text = "He llegado a la meta";
            this.imageObject.SetActive(true);
        }
    }
}
