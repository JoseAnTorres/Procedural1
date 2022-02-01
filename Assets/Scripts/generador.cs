using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour
{
    public GameObject piedra;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("gen");
    }

    IEnumerator gen()
    {
        int totalPiedras = 20;
        while (totalPiedras > 0)
        {
            float x = Random.Range(-20.0F, 20.0F);
            float z = Random.Range(-20.0F, 20.0F);

            Vector3 pos = new Vector3(x, 20, z);

            Instantiate(piedra, pos, Quaternion.identity);

            totalPiedras--;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
