using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float maxTime;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
       SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            SpawnPipe(true);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnPipe(bool destroyAfter = false)
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        if(destroyAfter)
        {
            Destroy(newPipe, 20f);
        }
    }
}
