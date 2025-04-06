using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float countTime = 0;
    private float waitTime = 3;

    // Update is called once per frame
    void Update()
    {
        countTime = countTime + 1;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (countTime == waitTime || countTime % 3 == 0))
        {

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            countTime = 0;
            if (countTime == 0)
            {
                Debug.Log("Count Time is 0!");
            }
          
        }

    }
}
