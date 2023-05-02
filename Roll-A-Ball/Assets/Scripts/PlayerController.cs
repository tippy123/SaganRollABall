using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;

    public TMPro.TextMeshProUGUI scoreText;
    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject pickupParticle;



    public int score;
    public int maxScore;

    void Start()
    {
        maxScore = GameObject.FindGameObjectsWithTag("Pick Up").Length;
        rb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text = "Score: " + score.ToString() + "/" + maxScore.ToString();

        Time.timeScale = 1;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);


    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pick Up")
        {
            Instantiate(pickupParticle, other.transform.position, other.transform.rotation);
            score++;
            scoreText.text = "Score: " + score.ToString() + "/" + maxScore.ToString();
            Destroy(other.gameObject);
            if (score >= maxScore)
            {
                winPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
        if(other.tag == "Death")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
