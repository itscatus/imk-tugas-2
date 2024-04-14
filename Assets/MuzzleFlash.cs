using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject muzzle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            MuzzleEffect();
    }

    private void MuzzleEffect()
    {
        // Instantiate muzzle flash only when shooting
        GameObject muzzleFlashEffect = Instantiate(muzzle, spawnPoint.position, spawnPoint.rotation);
        muzzleFlashEffect.transform.parent = spawnPoint;
    }
}
