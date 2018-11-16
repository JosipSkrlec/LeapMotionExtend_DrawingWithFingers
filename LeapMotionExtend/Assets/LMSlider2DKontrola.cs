using Leap.Unity.DetectionExamples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LMSlider2DKontrola : MonoBehaviour {

    public GameObject SliderR;
    public GameObject SliderG;
    public GameObject SliderB;
    public GameObject ShowColor;
    public GameObject SliderSize;


    float tempR = 0.0f;
    float tempG = 0.0f;
    float tempB = 0.0f;
    float tempS = 0.0f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        tempR = SliderR.transform.position.x * 614/255;
        tempG = SliderG.transform.position.x * 614/255;
        tempB = SliderB.transform.position.x * 614/255;
        tempS = SliderSize.transform.position.y * 0.01f;

        PinchDraw.virtualTempR = tempR;
        PinchDraw.virtualTempG = tempG;
        PinchDraw.virtualTempB = tempB;
        PinchDraw.virtualTempSize = tempS;        

        ShowColor.GetComponent<Renderer>().material.color = new Color(tempR, tempG , tempB );



    }






}
