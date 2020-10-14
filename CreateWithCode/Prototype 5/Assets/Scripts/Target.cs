using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;

    private float minSpeed = 12f;

    private float maxSpeed = 16f;

    private float maxTorque = 10f;

    private float xRange = 4f;
    private float ySpawnPos = -2f;
    private GameManager GameManager;
    public int pointValue;
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }
    


    // Update is called once per frame
    void Update()
    {
    }
    private void OnMouseDown()
    {
        if (GameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            GameManager.UpdateScore(pointValue);
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            GameManager.GameOver();
        }
    }
    Vector3 RandomForce()
        {
            return Vector3.up * Random.Range(minSpeed, maxSpeed);
        }

        float RandomTorque()
        {
            return Random.Range(-maxTorque, maxTorque);
        }

        Vector3 RandomSpawnPos()
        {
            return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
        }
    }