using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodestruction : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Destroythis());
    }

    IEnumerator Destroythis()
    {
        yield return new WaitForSeconds(7);
        //Debug.Log("nashe");
        Destroy(gameObject);
    }
}
