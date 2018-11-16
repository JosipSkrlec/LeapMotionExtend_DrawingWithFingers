using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proba1 : MonoBehaviour
{
    // Use this for initialization
    public static List<GameObject> iscrtanelinije = new List<GameObject>();

    float a = 0.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Vrh"))
        {
            a += Time.deltaTime;

            if (a > 5)
            {
                foreach (GameObject g in iscrtanelinije)
                {
                    Destroy(g);
                }
                a = 0.0f;
            }


        }
    }


    // PROBA1
    //private HandModel GetHand(Collider other)
    //{
    //    if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
    //        return other.transform.parent.parent.GetComponent<HandModel>();
    //    else
    //        return null;
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    HandModel hand_model = GetHand(other);
    //    if (hand_model != null)
    //    {
    //        Debug.Log("sasadf");
    //        //Debug.Log(hand_model.GetPalmPosition()); // Give me pal position of the hand! (Vector3)
    //    }
    //}


    // PROBA2
    //private bool IsHand(Collider other)
    //{
    //    if (other.transform.parent || other.transform.parent.parent || other.transform.parent.parent.GetComponent<HandModel>())
    //        return true;
    //    else
    //        return false;
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    if (IsHand(other))
    //    {
    //        Debug.Log("Yay! A hand collided!");
    //    }
    //}


}

