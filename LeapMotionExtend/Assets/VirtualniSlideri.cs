using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualniSlideri : MonoBehaviour {

    public GameObject PanelSaSLiderima;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    float a = 0.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Vrh"))
        {
            a += Time.deltaTime;

            if (a > 5)
            {
                PanelSaSLiderima.SetActive(true);
                
            }
          
        }


        }
    }
