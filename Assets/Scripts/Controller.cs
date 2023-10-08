using UnityEngine;

namespace Vancheg
{
    public class Controller : MonoBehaviour, IControllable
    {
        private Model model;
        private View view;
        
        public void OnClick()
        {
            view.ColorChange();
            view.ScoreChange();
        }
    }
}