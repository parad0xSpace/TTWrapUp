using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerGenerator : MonoBehaviour
{

    public GameObject[] customers;

    void Start()
    {
        int i = Random.Range(0, customers.Length - 1);
        Instantiate(customers[i], transform.position, transform.rotation);
    }
}
