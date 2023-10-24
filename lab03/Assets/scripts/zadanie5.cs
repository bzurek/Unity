using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5 : MonoBehaviour
{
    public GameObject cube;
    public int numberOfObjects = 10;
    void Start()
    {
        var wygenerowane = new List<(float x, float z)> { };
        int it = 1;
        var temp = Random.Range(-10.0f, 10.0f);
        float x = temp;
        temp = Random.Range(-10.0f, 10.0f);
        float z = temp;
        wygenerowane.Add((x, z));
        while ( it < numberOfObjects )
        {
            temp = Random.Range(-10.0f, 10.0f);
            x = temp;
            temp = Random.Range(-10.0f, 10.0f);
            z = temp;
            foreach (var el in wygenerowane)
            {
                if ((x <= (el.x - 1) || x > (el.x + 1)) && (z <= (el.z - 1) || z > (el.z + 1)))
                {
                    wygenerowane.Add((x, z));
                    it++;
                    break;
                }
            }
        }
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 pos = Vector3.zero + new Vector3(wygenerowane[i].x, 0.5f, wygenerowane[i].z);
            Instantiate(cube, pos, Quaternion.identity);
        }
    }
}
