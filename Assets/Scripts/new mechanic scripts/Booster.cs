using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{

    public float Nitro;
    public float speedBoost;
    public float Decay;
    private float timer;
    private float cooldown;
    private bool wait = true;
    private float cooldown2;
    private float timer2;
    private bool wait2 = true;
    public float FuelLoss;


    public PlaneController pc;

    public KeyCode boostKey = KeyCode.Space;

    private void Start()
    {
        pc = GetComponent<PlaneController>();

    }

    private void Update()
    {
        timer = Time.time;
        timer2 = Time.time;
        if (Input.GetKey(boostKey) && Nitro > 0f)
        {
            pc.throttleInput = speedBoost;
            count();
        }
        else
        {
            pc.throttleInput = 10f;
        }
        if (wait2)
        {
            Nitro -= 1f;
            print(Nitro);
            cooldown2 = timer2 + FuelLoss;
            wait2 = false;
        }
        else
        {
            if (cooldown2 < timer2)
            {
                wait2 = true;
            }
        }
    }

    private void count()
    {
        if (wait)
        {
            Nitro -= 1f;
            print(Nitro);
            cooldown = timer + Decay;
            wait = false;
        }
        else
        {
            if (cooldown < timer)
            {
                wait = true;
            }
        }
     
       
    }

}
