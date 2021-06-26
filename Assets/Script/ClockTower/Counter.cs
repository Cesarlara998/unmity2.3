using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    public string ConditionText = "Ha llegado tarde a CLOCK Towers";
    public int limit = 100;
    private float start = 0.0f;
    void Start()
    {
        this.text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        this.text.text = this.Timer();
    }
    public string Timer() {
        if (Mathf.RoundToInt(this.start) > this.limit) {
            return this.ConditionText;
        } 
        else {
            this.start += Time.deltaTime;
            return Mathf.RoundToInt(this.start).ToString();
        }
    }
}
