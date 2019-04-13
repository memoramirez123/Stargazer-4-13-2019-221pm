using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weatherpowerup : MonoBehaviour
{
    public CircleCollider2D bruh;
    public GameObject panel;
    public Button WeatherButton;
    public InputField location;
    public string yo = "";
   //[SerializeField] private panel customPanel;
    void Start()
    {
         
        panel.SetActive(false);
        //WeathertButton.interactable = false;
        OnTriggerEnter2D(bruh);
        WeatherButton.onClick.AddListener(Exit);
        
       // yo = location.text;
        //Debug.Log("this is the input "+yo);
        //OnTriggerExit2D(bruh);
    }

    void Update()
    {
      
    }
    void OnTriggerEnter2D(Collider2D bruh){
       
        if (bruh.name == "Player") {
            panel.SetActive(true);
            Time.timeScale = 0f;
            //gameObject.SetActive(false);
            //gameObject.renderer.enabled= false;
            //gameObject.GetComponent<Renderer>().enabled = false;

        }
            
     }

     void Exit(){
         Debug.Log("Button has been clicked please check your button");
         //if (bruh.name == "Player") {
             yo = location.text;
            
            Debug.Log("this is the input "+yo);
           // }
           GameObject input = GameObject.Find("Weather");
        Weather w = input.GetComponent<Weather>();
        StartCoroutine(w.GetWeatherIntput(yo));
        panel.SetActive(false);
        Time.timeScale = 1f;
        //gameObject.SetActive(false);
    }

}
