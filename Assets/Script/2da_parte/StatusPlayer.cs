using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StatusPlayer : MonoBehaviour
 {
    public int Life = 1;
    public int Dead = 00;
    private float Timer = 0.0f;
    private GameObject TimerO;
    private Text textTimer;
    private GameObject LifeO;
    private Text textLife;
    private GameObject DeadO;
    private Text textDead;

    // Start is called before the first frame update
    void Start()
    {
        // SEARCH TEXT
        this.TimerO = GameObject.Find("Time");
        this.textTimer = this.TimerO.GetComponent<Text>();
        this.LifeO =  GameObject.Find("ColliderText");
        this.textLife = this.LifeO.GetComponent<Text>();

        this.DeadO =  GameObject.Find("lifeText");
        this.textDead = this.DeadO.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        this.LifesText();
        this.DeadText();
        this.Timerf();
        this.Timer = Time.time;
    }

    public void Timerf() {
        // this.start += Time.deltaTime;
        //     return Mathf.RoundToInt(this.start).ToString();
        float TimerControl = Time.time + Timer;
        string mins = ((int)TimerControl/60).ToString("00");
        string segs = (TimerControl % 60).ToString("00");
        string milisegs = ((TimerControl * 100)%100).ToString ("00");
            
        string TimerString = string.Format ("{00}:{01}:{02}", mins, segs, milisegs);

        this.textTimer.text = TimerString.ToString();

    }
    private void LifesText() {
        if (this.Life < 10) {
            this.textLife.text = "x 0" + this.Life.ToString();    
        } else {
            this.textLife.text = "x " + this.Life.ToString();
        }
    }
    private void DeadText() {
        if (this.Dead < 10) {
            this.textDead.text = "x " + this.Dead.ToString();    
        }

        if (this.Dead < 0) {
            this.textDead.text = "x " + this.Dead.ToString();
        }
        if (this.Dead > 10 && this.Dead > 0) {
            this.textDead.text = "x " + this.Dead.ToString();
        }
    }
}
