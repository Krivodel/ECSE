using UnityEngine;
using UnityEngine.UI;
using System;

using Project.EventBusSystem;

namespace Project
{
    public class CounterText : MonoBehaviour
    {
        private Text _text;

        private int count;
        private float lastAverageTime;
        private float averageTime;

        private void Awake()
        {
            _text = GetComponent<Text>();

            EventBus.Instance.Register<ClickEvent>(OnClick);
        }

        private void OnClick(ClickEvent data)
        {
            count++;

            averageTime = data.Time - lastAverageTime;

            _text.text = "<color=red>" + count + "</color>" + " count in average time " + Math.Round(averageTime, 2);

            lastAverageTime = Time.time;
        }
    }
}
