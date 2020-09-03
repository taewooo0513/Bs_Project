using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private float h;
    private float v;
    private Animator anime;
    public SpriteRenderer spr;
    // Update is called once per frame
    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        v = Input.GetAxis("Vertical")*speed *Time.deltaTime;
        transform.Translate(h,v,0);
        anime.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        anime.SetFloat("MoveY", Input.GetAxis("Vertical"));

      if(h >= 0.0001)
        {
            spr.flipX = false;
        }
       else if (h <= -0.0001)
        {
            spr.flipX = true;
        }
    }
}
