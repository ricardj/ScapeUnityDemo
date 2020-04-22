using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneSequence : MonoBehaviour
{

    public GameObject cam1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence()); 
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(4);
        cam1.SetActive(true);
        yield return new WaitForSeconds(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
