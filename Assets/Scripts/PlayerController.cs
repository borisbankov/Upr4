using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 movement;
    [SerializeField]
    float speed = 5.0f;
    TextMeshProUGUI score;
    Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        score = GameObject.Find("Points").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //transform.Translate(movement);
    }

    private void FixedUpdate()
    {
        rb.AddForce(movement * speed, ForceMode.Force);
        //rb.velocity = movement * speed;
    }

    public void UpdateScore(int points)
    {
        score.text = int.Parse(score.text) + points + "";
    }
}
