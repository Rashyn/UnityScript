using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class battle : MonoBehaviour {

    GameObject player;
    GameObject enemy;

    CharaStatus CharaScript; //player script
    Enemy EnemyScript; //enemy script

    // Use this for initialization
    void Start () {
        Debug.Log("バトル発生");
        player = GameObject.Find("Chara1");
        CharaScript = player.GetComponent<CharaStatus>(); //味方ステータス読み込み 
        enemy = GameObject.Find("enemy");
        EnemyScript = enemy.GetComponent<Enemy>(); //敵ステータス読み込み

        Debug.Log("CharaScript.HP" + CharaScript.HP);
        Debug.Log("EnemyScript.HP" + EnemyScript.HP);
        //ステータス表示パネル表示
        int turn;
        turn = 1;
        while (turn <= 4)
        {
            //speed define i++
            for (int i = 0; i < ActionCharas().Length; i++)
            {
                Debug.Log(ActionCharas()[i]);

            }
            //while array speed >= 100
            //action 敵味方のスクリプトに作った行動を読み取る　private functionとか
            //statusdefine
            //    //    break  敵味方どちらかが全滅するまで
            //    chara.speed = 0
            Debug.Log("turn" + turn);

            turn++;

        }
        //speed array = 0

    }
	
	// Update is called once per frame
	void Update () {


	}

    int[] ActionCharas(int charaSpeedGage, int enemySpeedGage)
    {
        
        int[] actionCharas = { 1, 2};
        return actionCharas;

    }

    int decideDamage(int power)
    {
        return power;
    }
    public static void Main(string[] args)//Linqの例
    {
        var list = new List<int> { 1, 84, 95, 95, 40, 6 };

        // list の最初の要素を取得する
        Debug.Log("First: " + list.First());
        // list の最後の要素を取得する
        Debug.Log("Last: " + list.Last());

        int[] array = { 0, 1, 2 };
        int[] result = array.Concat(new int[] { 3 }).ToArray();
    }

}
