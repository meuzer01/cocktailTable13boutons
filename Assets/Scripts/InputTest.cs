using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    [Header("Player 1")]
    [SerializeField] GameObject P1_Joystick;
    [SerializeField] GameObject P1_Start;
    [SerializeField] GameObject P1_B1;
    [SerializeField] GameObject P1_B2;
    [SerializeField] GameObject P1_B3;
    [SerializeField] GameObject P1_B4;
    [SerializeField] GameObject P1_B5;
    [SerializeField] GameObject P1_B6;
    [SerializeField] GameObject P1_B7;
    [SerializeField] GameObject P1_B8;
    [SerializeField] GameObject P1_B9;
    [SerializeField] GameObject P1_B10;
    [SerializeField] GameObject P1_B11;
    [SerializeField] GameObject P1_B12;
    [Space(10)]
    [SerializeField] GameObject Reset;

    void Update()
    {
        P1_Joystick.transform.localPosition = new Vector3(Input.GetAxisRaw("P1_Horizontal")*100f, Input.GetAxisRaw("P1_Vertical")*100f, 0);
        P1_B1.SetActive(Input.GetButton("P1_B1"));
        P1_B2.SetActive(Input.GetButton("P1_B2"));
        P1_B3.SetActive(Input.GetButton("P1_B3"));
        P1_B4.SetActive(Input.GetButton("P1_B4"));
        P1_B5.SetActive(Input.GetButton("P1_B5"));
        P1_B6.SetActive(Input.GetButton("P1_B6"));
        P1_B7.SetActive(Input.GetButton("P1_B7"));
        P1_B8.SetActive(Input.GetButton("P1_B8"));
        P1_B9.SetActive(Input.GetButton("P1_B9"));
        P1_B10.SetActive(Input.GetButton("P1_B10"));
        P1_B11.SetActive(Input.GetButton("P1_B11"));
        P1_B12.SetActive(Input.GetButton("P1_B12"));
        P1_Start.SetActive(Input.GetButton("P1_Start"));

        Reset.SetActive(Input.GetButton("Coin"));
    }

}
