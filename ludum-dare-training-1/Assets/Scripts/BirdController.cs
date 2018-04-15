using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public float initialImpulse;
    public float impulse;
    public float maxVelocity;

    private Rigidbody2D _body;

	// Use this for initialization
	void Start () {
        _body = GetComponent<Rigidbody2D>();

        _body.AddForce(Vector2.up * initialImpulse, ForceMode2D.Impulse);
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            _body.AddForce(Vector2.up * impulse, ForceMode2D.Impulse);

        var v = _body.velocity;
        v.y = Mathf.Min(v.y, maxVelocity);
        _body.velocity = v;
        }
    }
}
