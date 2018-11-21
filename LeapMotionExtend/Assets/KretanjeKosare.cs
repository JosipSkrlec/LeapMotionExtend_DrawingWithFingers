using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KretanjeKosare : MonoBehaviour {

    public static bool igra;
    public static bool kosaraa;

    public GameObject Kosara;
    private Vector3 lijevatocka = new Vector3(-0.1f,0.170f,0.10f);
    private Vector3 desnatocka = new Vector3(0.48f, 0.170f, 0.10f);
    public Transform target;
    public float speed;

    float vrijeme = 0.0f;
    public static int score = 0;


    // Update is called once per frame
    void Update () {
        if (igra == true)
        {
            vrijeme += Time.deltaTime;

            if (vrijeme > 10.0f)
            {
                vrijeme = 0.0f;
            }

            if (Kosara.transform.position.x != desnatocka.x && vrijeme < 5)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, desnatocka, step);
            }
            if (Kosara.transform.position.x != lijevatocka.x && vrijeme > 5)
            {
                float step1 = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, lijevatocka, step1);

            }
        }
        if (kosaraa == false)
        {
            Kosara.SetActive(false);
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            score += 1;
            Debug.Log(score);
            Destroy(other);
        }

    }




}
