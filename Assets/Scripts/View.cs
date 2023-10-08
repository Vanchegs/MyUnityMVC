using UnityEngine;
using UnityEngine.UI;

namespace Vanchegs
{
    public class View : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        
        private Model model;

        public void SetModel(Model model)
        {
            this.model = model;
        }

        public void ViewScore()
        {
            model.ScoreIncrement();
            scoreText.text = "Score: " + model.Score;
        }

        public void RandomColorChange()
        {
            var rndColor = Random.Range(0, 3);

            switch (rndColor)
            {
                case 0:
                    scoreText.color = Color.yellow;
                    break;
                case 1:
                    scoreText.color = Color.green;
                    break;
                case 2:
                    scoreText.color = Color.blue;
                    break;
                case 3:
                    scoreText.color = Color.red;
                    break;
                default: 
                    scoreText.color = Color.black;
                    break;
            }
        }
    }
}

