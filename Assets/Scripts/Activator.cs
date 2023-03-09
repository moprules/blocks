using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    // public Activator button;
    public Material unactiveMat;
    public Material activeMat;

    void MySet(GameObject[] group, Material mat, bool isActive = true)
    {
        foreach (GameObject el in group)
        {
            el.GetComponent<Renderer>().material = mat;
            el.GetComponent<Collider>().isTrigger = isActive;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        MySet(firstGroup, activeMat, isActive: true);
        MySet(secondGroup, unactiveMat, isActive: false);
        // foreach (GameObject first in firstGroup)
        // {
        //     first.GetComponent<Renderer>().material = normal;
        //     first.GetComponent<Collider>().isTrigger = false;
        // }

        // foreach (GameObject second in secondGroup)
        // {
        //     second.GetComponent<Renderer>().material = trasnparent;
        //     second.GetComponent<Collider>().isTrigger = true;
        // }

        GetComponent<Renderer>().material = activeMat;
    }

    private void OnTriggerExit(Collider other)
    {
        MySet(firstGroup, unactiveMat, isActive: false);
        MySet(secondGroup, activeMat, isActive: true);
        // foreach (GameObject first in firstGroup)
        // {
        //     first.GetComponent<Renderer>().material = normal;
        //     first.GetComponent<Collider>().isTrigger = false;
        // }

        // foreach (GameObject second in secondGroup)
        // {
        //     second.GetComponent<Renderer>().material = trasnparent;
        //     second.GetComponent<Collider>().isTrigger = true;
        // }

        GetComponent<Renderer>().material = unactiveMat;
    }

}
