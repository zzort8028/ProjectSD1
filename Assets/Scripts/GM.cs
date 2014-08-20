using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

    public static class Player
    {
        public static int money = 0;
    }

    public GameObject Money;

    float money_increase_time = 0;

	void Update()
    {
        money_increase_time += Time.deltaTime;
        if(money_increase_time > 0.1f)
        {
            GM.Player.money++;
            money_increase_time = 0;
        }



        Money.GetComponent<TextMesh>().text = GM.Player.money+"원";
    }
}
