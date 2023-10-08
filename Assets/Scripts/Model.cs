using UnityEngine.UI;

namespace Vancheg
{
    public class Model : IModelable
    {
        private View view;
        public int Score { get; set; }
        public Text Text { get; set; }
    }
}