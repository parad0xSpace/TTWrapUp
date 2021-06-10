using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SILLYBUTTONAAAA : MonoBehaviour
{
    public GameObject player;

    public void EnablePlayer()
    {
        player.gameObject.SetActive(true);
    }

    public void DisablePlayer()
    {
        player.gameObject.SetActive(false);
    }
}
