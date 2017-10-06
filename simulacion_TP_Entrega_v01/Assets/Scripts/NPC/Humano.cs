﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour, NPC {

    public static List<Zombie> zombies= new List<Zombie>();
    public static List<GameObject> puntos = new List<GameObject>();
    private float velocidad;

    private GameObject _zombie;

    private StateMachine stateMachine;
    private Animator animator;
    private IEnumerable<string> animations;

    // Use this for initialization
    void Awake () {
		animator = GetComponent<Animator> ();

        Zombie.humanos.Add(this);
        animations = new string[] { "Walk", "SprintJump" };
        velocidad = 5;
        stateMachine = new StateMachine();
        stateMachine.AddState(new EscaparState(stateMachine, this));
        stateMachine.AddState(new CircularState(stateMachine, this));
        stateMachine.SetState<CircularState>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public float GetSpeed()
    {
        return velocidad;
    }

    public void Animate(string animationName)
    {
        foreach (var animation in animations)
        {
            animator.SetBool(animation, (animation.ToUpper() == animationName.ToUpper()));
        }
    }

    public Transform GetTransform()
    {
        return transform;
    }
    public GameObject GetZombie()
    {
        return _zombie;
    }


}
