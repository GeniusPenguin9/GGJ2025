using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;
using System.IO;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] _spawnPoints; //刷怪点

    [SerializeField]
    GameObject _monsterPrefabs;

    private Monster[] _availableMonsters;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnNextMonster()
    {
        // TODO
    }

    private void LoadMonster(string filePath)
    {
        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Encoding = Encoding.UTF8,
            Delimiter = ",",
            HeaderValidated = null,
            MissingFieldFound = null,
            BadDataFound = null,
            TrimOptions = TrimOptions.Trim,
            Mode = CsvMode.RFC4180,

        };

        // "rg" -> the monster should be destroyed by red + green bubble
        // monsterName, colors, score, spriteRenderer
        // 1,r,1,/Asserts/Images/Monster1.png
        // 2,rg,2,/Asserts/Images/Monster2.png
        using (var reader = File.OpenText(filePath))
        using (var csv = new CsvReader(reader, configuration))
        {
            while (csv.Read())
            {
                var monsterName = csv.GetField<string>(0);
                var colors = csv.GetField<string>(1);
                var score = csv.GetField<int>(2);
                var spriteRenderer = csv.GetField<string>(3);

                Monster _monster = new Monster();

                
            }
        }
    }
}
