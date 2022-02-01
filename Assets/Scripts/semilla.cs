using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semilla : MonoBehaviour
{
    public GameObject arbol;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("germinar", tiempo);
    }

    private void germinar()
    {
        if(transform.position.y < 0.8f)
        {
            Vector3 pos = new Vector3(transform.position.x, 7.55f, transform.position.z);
            Instantiate(arbol, pos, Quaternion.identity);
        }
        Destroy(this.gameObject);
    }
}
