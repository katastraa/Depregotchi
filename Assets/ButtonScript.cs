using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public KeyCode key;
    public Button VideogameButton;
    public Button Music;
    public TimerScript timerScript;
   

    private void Awake()
    {
        VideogameButton = GetComponent<Button>();
        Music = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update() //pa que funcione con el teclao
    {
        if (Input.GetKeyDown( key )) 
        { 
            timerScript.OverstimulationMechanic();
            timerScript.Videogames();
        }

        if (Input.GetKeyDown( key ))
        {
            timerScript.OverThinkingMechanic();
            timerScript.Music();
        }
    }

    

}
