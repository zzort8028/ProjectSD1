using UnityEngine;
using System.Collections;

public class Z_Tier1 : MonoBehaviour {
    int hp;
    int attack_damage;
    float attack_speed;
    int move_speed;
    int cost;

    int isStop = 0;
    int enemy_damage;
    float time = 0;

    public GameObject enemy = null;
	// Use this for initialization
    void Start()
    {
        float posy = Random.Range(-5.0f, -4.0f);
        hp = 40;
        attack_damage = 10;
        attack_speed = 1.0f;
        cost = 30;
        move_speed = 10;
        gameObject.transform.position = new Vector3(-62, posy, 0);
    }
	
	// Update is called once per frame
	void Update () {

        if (isStop == 0)
        {
            gameObject.transform.Translate(Vector3.left * move_speed * Time.deltaTime);
        }
        else
        {
            time += Time.deltaTime;
            if (time > attack_speed)

            {
                if (enemy != null)
                { 
                   enemy.SendMessage("receiveDamage", attack_damage, SendMessageOptions.DontRequireReceiver);
                   time = 0;
                }
            }
            if(enemy == null)
            {
                isStop = 0;
            }
        } 
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Unit"))
        {
            isStop = 1;
            print("isStop : " + isStop);

            enemy = other.gameObject;
            
        }
    }
    void receiveDamage(int ak)
    {
        enemy_damage = ak;
       
    }    
}
