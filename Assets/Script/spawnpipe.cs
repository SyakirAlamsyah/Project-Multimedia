using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpipe : MonoBehaviour
{
    [SerializeField] private float maxtime = 1.5f;
    [SerializeField] private float height = 0.5f;
    [SerializeField] private GameObject pipe;

    private float timer;

    private void spawnPipe()
    {
        Vector3 SpawnPos = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        GameObject pipe = Instantiate(this.pipe, SpawnPos, Quaternion.identity);
        Destroy(pipe, 5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxtime)
        {
            spawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
