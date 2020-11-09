using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject positionText;
    public float speed;
    public Text countText;
    
    public Text movementText;

    private Rigidbody rb;
    private int count;
    private int Movement;

    public Vector3 pos;



    // Start is called before the first frame update
    void Start()
    {
        positionText.GetComponent<Text>().text = "Position: " + pos;

        pos = transform.position;
        Debug.Log("Position is " + pos);



    }

    // Update is called once per frame
    void Update()
    {
     positionText.GetComponent<Text>().text = " " + count.ToString();
     
    }
}