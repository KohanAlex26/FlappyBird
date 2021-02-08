using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public static AudioClip wingSound, hitSound, pointSound;
    static AudioSource audioSrc;
    public GameObject pipeSpawner;
    public GameObject Ground;
    public GameObject bird;
    public GameObject getReady;
    public GameObject tap;
    // Start is called before the first frame update
    public static void playSound(string clip)
    {
        switch (clip){
            case "wing":
                audioSrc.PlayOneShot(wingSound);
                break;
            case "hit":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "point":
                audioSrc.PlayOneShot(pointSound);
                break;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
        wingSound = Resources.Load<AudioClip>("wing");
        hitSound = Resources.Load<AudioClip>("hit");
        pointSound = Resources.Load<AudioClip>("point");
        audioSrc = GetComponent<AudioSource>();
        pipeSpawner.SetActive(false);
        Ground.gameObject.GetComponent<Animator>().enabled = false;
        bird.gameObject.GetComponent<Animator>().enabled = false;
        getReady.SetActive(true);
        tap.SetActive(true);
}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Jump
            getReady.SetActive(false);
            tap.SetActive(false);
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.velocity = Vector2.up * velocity;
            audioSrc.PlayOneShot(wingSound);
            pipeSpawner.SetActive(true);
            Ground.gameObject.GetComponent<Animator>().enabled = true;
            bird.gameObject.GetComponent<Animator>().enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
