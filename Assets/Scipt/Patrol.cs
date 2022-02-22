using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//NavMeshAgentを使用するときに追記する

public class Patrol : MonoBehaviour
{

    public Transform[] points;//周回する時に通過するポイント
    private int destPoint = 0;//次に向かうポイントを決める変数
    private NavMeshAgent agent;//NavMeshAgentを使うための変数

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();//NavmeshAgentを取得する
        agent.autoBraking = false;//速度を落とさずに移動する設定
        GotoNextPoint();//GotoNextPointを実行する
    }

    void GotoNextPoint()//GotoNextPointの処理
    {
        if (points.Length == 0)//もし周回するポイントがなければ、
            return;//返す
        agent.destination = points[destPoint].position;//周回するポイントに向かう
        destPoint = (destPoint + 1) % points.Length;//destPointを(destPoint+1)をpoints.Lengthで割った余りにする
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 10f)//もし、ポイントに近づいたら、
        {
            GotoNextPoint();//次のポイントに変える
        }
    }
}