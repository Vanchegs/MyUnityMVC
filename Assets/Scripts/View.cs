using UnityEngine;

namespace Vancheg
{
    public class View : IViewable
    {
        private Model model;
        
        public void ScoreChange()
        {
            model.Score++;
        }

        public void ColorChange()
        {
            var rndColor = Random.Range(0, 2);

            switch (rndColor)
            {
                case 0:
                    model.Text.color = Color.black;
                    break;
                case 1:
                    model.Text.color = Color.cyan;
                    break;
                case 2:
                    model.Text.color = Color.green;
                    break;
                default:
                    model.Text.color = Color.white;
                    break;
            }
            
        }
    }
}