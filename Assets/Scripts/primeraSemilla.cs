using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primeraSemilla : MonoBehaviour
{
    public GameObject semilla;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);

        Instantiate(semilla, new Vector3(x, -5, z), Quaternion.identity);

    }
}
