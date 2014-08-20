using UnityEngine;
using System.Collections;

public class Button_1tier : MonoBehaviour {

    public GameObject Zombie_1tier;

	void OnMouseDown()
    {
        if (GM.Player.money >= 30)
        {
            Instantiate(Zombie_1tier, new Vector3(-60f, -5.9f), Quaternion.Euler(0, 180f, 0));
            GM.Player.money -= 30;
        }
    }
}
