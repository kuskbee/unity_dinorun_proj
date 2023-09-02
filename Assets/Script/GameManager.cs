using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level(int score)
    {
        // 점수를 100으로 나누어 속도가 추가되는 로직 작성
        int defaultSpeed = -5;
        int increaseSpeed = (score * -1) / 100;

        if(increaseSpeed < -5) {
            increaseSpeed = -5;
        }

        return defaultSpeed + increaseSpeed;
    }
}
