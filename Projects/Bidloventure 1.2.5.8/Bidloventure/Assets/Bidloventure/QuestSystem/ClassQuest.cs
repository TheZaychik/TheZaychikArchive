using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System;

public class ClassQuest : MonoBehaviour
{
    public float[,] QuestMas;
    public string[,] QuestData;
    string a = "";
    Int32 selectedQuest;
    public DialogUI du;
    player_interaction pi;
    PlayerUI_Script ps;
    Int32 i;
    // Use this for initialization
    void Update()
    {


    }
    void Start()
    {
        pi = this.gameObject.GetComponent<player_interaction>();
        ps = GameObject.FindGameObjectWithTag("UI_Player").GetComponent<PlayerUI_Script>();
        QuestMas = new float[10, 2];
        QuestData = new string[10, 4];
        //QuestsMas 0) Id персонажа, выдающего квест 1)Статус квеста
        QuestMas[0, 0] = 0;
        QuestMas[1, 0] = 1;
        QuestMas[2, 0] = 2; // Расставить id (позже)
        QuestMas[3, 0] = 3;
        QuestMas[4, 0] = 4;
        QuestMas[5, 0] = 5;
        QuestMas[6, 0] = 6;
        QuestMas[7, 0] = 7;
        QuestMas[8, 0] = 8;
        QuestMas[9, 0] = 9;
        //QuestData // 0)Имя квеста 1)Текст во время взятия квеста 2)Текст во время выполнения квеста 3)Текст во время сдачи квеста
        QuestData[0, 0] = "Убить бандита"; QuestData[0, 1] = "Есть одно дело, тебе нужно убить одного бандита в районе Северного леса. За это я тебе выдам неплохую награду"; QuestData[0, 2] = "Как там парень?"; QuestData[0, 3] = "Молодец! Этот парень был действительно плохим, вот твоя награда! (100 Gold)";
        LoadData();
        SaveData();
    }
    public void QuestComlete()
    {
        QuestMas[i, 1] = 2;
        ps.aq.text = "Нет активного задания";
        // награда код 
        pi.QuestTaken = 0;
        SaveData();
        ps.SaveData();
        pi.SaveData();


    }
    public void AcceptQuest()
    {
        QuestMas[i, 1] = 1;
        ps.aq.text = QuestData[selectedQuest, 0];
        pi.QuestTaken = 1;
        SaveData();
        ps.SaveData();
        pi.SaveData();
    }
    public void GetQuest(int id)
    {
        for (i = 0; i < 10; i++)
        {
            if ((QuestMas[i, 0] == id) && (QuestMas[i, 1] == 0))
            {
                selectedQuest = i;
                du.prsn_anst.text = GetText(a);
                du.player_ans1.text = "1) Я берусь";
                du.player_ans2.text = "2) В другой раз";
                return;
            }
        }
        du.prsn_anst.text = "У меня нету заданий для тебя";
    }

    public string GetText(string text)
    {
        if (pi.QuestTaken == 0)
            text = QuestData[selectedQuest, 1];
        if (pi.QuestTaken == 1)
            text = QuestData[selectedQuest, 2];
        if (pi.QuestTaken == 2)
            text = QuestData[selectedQuest, 3];
        return text;
    }
    void LoadData()
    {
        using (StreamReader file = new StreamReader("BidloventureQuest.txt"))
        {
            for (int i = 0; i < 10; i++)
            {
                QuestMas[i, 1] = Convert.ToSingle(file.ReadLine());
            }
            selectedQuest = Convert.ToInt32(file.ReadLine());

        }

    }
    void SaveData()
    {
        using (StreamWriter file = new StreamWriter("BidloventureQuest.txt"))
        {
            for (int i = 0; i < 10; i++)
            {
                file.WriteLine(QuestMas[i, 1]);
            }
            file.WriteLine(selectedQuest);
        }

    }
}
