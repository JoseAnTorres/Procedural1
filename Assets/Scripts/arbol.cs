using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbol : MonoBehaviour
{
    public GameObject semilla;
    private GameObject flor;
    // Start is called before the first frame update
    void Start()
    {
        flor = transform.GetChild(6).gameObject;
        StartCoroutine("generarSemilla");
    }

    IEnumerator generarSemilla()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);

            float x = flor.transform.position.x + Random.Range(-0.2f, 0.2f);
            float z = flor.transform.position.z + Random.Range(-0.2f, 0.2f);
            float y = flor.transform.position.y;

            Vector3 pos = new Vector3(x, y, z);

            Instantiate(semilla, pos, Quaternion.identity);
        }
    }
}
