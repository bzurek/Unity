using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int generuj = 0;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    List<Material> materialy = new List<Material>();
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    public Transform plane;
    public Plane myPlane;
    Vector3 size;
    void Planesize()
    {
        size = plane.GetComponent<Renderer>().bounds.size;
    }
    void Start()
    {
        materialy.Add(mat1);
        materialy.Add(mat2);
        materialy.Add(mat3);
        materialy.Add(mat4);
        materialy.Add(mat5);
        Planesize();
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(-1 * (int)size.x / 2, (int)size.x).OrderBy(x => Guid.NewGuid()).Take(generuj));
        List<int> pozycje_z = new List<int>(Enumerable.Range(-1 * (int)size.z / 2, (int)size.z).OrderBy(x => Guid.NewGuid()).Take(generuj));

        for (int i = 0; i < generuj; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }
    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            int temp = UnityEngine.Random.Range(0, 5);
            block.GetComponent<MeshRenderer>().material = materialy[temp];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}