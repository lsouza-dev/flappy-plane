using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Text Mesh")]
    [SerializeField] TMP_Text pointText;
    [SerializeField] TMP_Text levelText;
    [SerializeField] private float points = 0f;

    [Header("Level Variables")]
    [SerializeField] private int level = 1;
    [SerializeField] private float nextLevel = 10f;
    // Start is called before the first frame update

    private Obstacles obstacles;
    void Start()
    {
        obstacles = GetComponent<Obstacles>();
    }

    // Update is called once per frame
    void Update()
    {
        CountPoints();
        if (points > nextLevel)
        {
            GetLevel();
        }

        levelText.text = level.ToString();
    }
    
    private void GetLevel()
    {
        level += 1;
        nextLevel *= 2;
    }

    private void CountPoints()
    {
        points += Time.deltaTime;
        pointText.text = $"POINTS: {Mathf.Round(points)}";
    }

    public int ReturnLevel()
    {
        return level;
    }
}
