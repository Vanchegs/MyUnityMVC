using System;
using UnityEngine;

namespace Vanchegs
{
    public class Controller : MonoBehaviour
    {
        private View view;
        private Model model;

        private void Start()
        {
            model = new Model();
            view = GetComponent<View>();
            view.SetModel(model);
        }

        public void OnClick()
        {
            view.ViewScore();
            view.RandomColorChange();
        }
    }
}
