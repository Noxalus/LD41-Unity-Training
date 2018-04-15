using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BirdDeath : MonoBehaviour {

    [Serializable]
    public class DeathAction : UnityEvent { }
    public DeathAction death;

    // Use this for initialization
    void Start () {
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Animator>().SetBool("isDead", true);
        death.Invoke();
    }

    // Update is called once per frame
    void Update () {
    }
}
