using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;


public class UIController : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    public GameManager gameManager;
    public Button StartDemo;
    public Button StopDemo;
    public Toggle OrderToggle;
    public Toggle DeadLockToggle;
    public Slider ThinkingSlider;
    public Slider EatingSlider;
    public Slider PickUpSlider;
    public Slider DropSlider;
    public Toggle useSynhToggle;


    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        StartDemo = root.Q<Button>("Start");
        StopDemo = root.Q<Button>("Stop");
        useSynhToggle = root.Q<Toggle>("synhEnable"); 
        OrderToggle = root.Q<Toggle>("Ordered");
        DeadLockToggle = root.Q<Toggle>("Deadlock");
        ThinkingSlider = root.Q<Slider>("DurationThinkingSlider");
        EatingSlider = root.Q<Slider>("DurationEatingSlider");
        PickUpSlider = root.Q<Slider>("DurationPickupSlider");
        DropSlider = root.Q<Slider>("DurationDropSlider");

        StartDemo.text = "Start";
        
        StartDemo.clicked += start_ordered;
        StartDemo.clicked += StartButtonPress;
        
        StopDemo.clicked += StopButtonPress;
        StopDemo.clicked += stop_ordered;
        

        //StopDemo.clicked += AfterStopButtonPress;
    }
    
    // Update is called once per frame
    void Update()
    {
        OrderToggle.value = true;
            
        if (!DeadLockToggle.value)
        {
            textMesh.text = "Ordered";
            textMesh.color = Color.green;
        }
        else
        {
            textMesh.text = "Deadlock";
            textMesh.color = Color.red;

        }

        // if (OrderToggle.value == true)
        // {
        //     if (DeadLockToggle.value == true)
        //     {
        //         OrderToggle.value = false;
        //         DeadLockToggle.value = true;
        //     }
        // }
        // else if (DeadLockToggle.value == true)
        // {
        //     if (OrderToggle.value == true)
        //     {
        //         OrderToggle.value = true;
        //         DeadLockToggle.value = false;
        //     }
        // }
    }

    void StartButtonPress()
    {
        Debug.Log("start");
        StartDemo.text = "Restart";
        // AfterRestartPress();
    }
    void StopButtonPress()
    {
        Debug.Log("Stop");
    }

    void start_ordered()
    {
        gameManager.Start_Ordered_Demo();
    }

    void stop_ordered()
    {
        gameManager.Stop_Ordered_Demo();
    }

    void AfterRestartPress()
    {
        //Update UI text
        foreach (var each in gameManager.philosophers)
        {
            // Debug.Log(each.philosopher_Name);
            each.textMesh.text = "Restart Action";
        }
    }
}
