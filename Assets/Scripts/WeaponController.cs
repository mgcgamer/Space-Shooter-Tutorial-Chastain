using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour
{

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;

    private AudioSource audioSource;
    private GameController gameControllerObj;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("Fire", delay, fireRate);
        gameControllerObj = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        audioSource.Play();
        if (gameControllerObj.hardMode == true)
        {
            InvokeRepeating("Fire", delay, .75F);
        }
    }
}